using AutoRest.Core;
using AutoRest.Core.Utilities;
using AutoRest.Modeler.Model;
using Microsoft.Perks.JsonRPC;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRest.Modeler
{
	public class Program : NewPlugin
	{
		public static int Main(string[] args)
		{
			if (args != null && args.Length > 0 && args[0] == "--server")
			{
				var connection = new Connection(Console.OpenStandardOutput(), Console.OpenStandardInput());
				connection.Dispatch("GetPluginNames", () => Task.FromResult(new[] { "imodeler1" }));
				connection.Dispatch<string, string, bool>("Process", (plugin, sessionId) => new Program(connection, plugin, sessionId).Process());
				connection.DispatchNotification("Shutdown", connection.Stop);

				// wait for something to do.
				connection.GetAwaiter().GetResult();

				Console.Error.WriteLine("Shutting Down");
				return 0;
			}
			Console.WriteLine("This is not an entry point.");
			Console.WriteLine("Please invoke this extension through AutoRest.");
			return 1;
		}

		public Program(Connection connection, string plugin, string sessionId) : base(connection, plugin, sessionId) { }

		protected override async Task<bool> ProcessInternal()
		{
			if (true == await this.GetValue<bool?>($"modeler.debugger"))
			{
				AutoRest.Core.Utilities.Debugger.Await();
			}

			var settings = new Settings
			{
				Namespace = await GetValue("namespace") ?? ""
			};

			var files = await ListInputs();
			if (files.Length != 1)
			{
				return false;
			}

			var content = await ReadFile(files[0]);
			var fs = new MemoryFileSystem();
			fs.WriteAllText(files[0], content);

			var serviceDefinition = SwaggerParser.Parse(fs.ReadAllText(files[0]));

			EnumFix(serviceDefinition.Components.Schemas.Values);
			ResponseFix(serviceDefinition.Paths.Values.SelectMany(x => x.Values));

			var modeler = new SwaggerModeler(settings, true == await GetValue<bool?>("generate-empty-classes"));
			var codeModel = modeler.Build(serviceDefinition);

			var modelAsJson = JsonConvert.SerializeObject(codeModel, new JsonSerializerSettings
			{
				Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) },
				NullValueHandling = NullValueHandling.Ignore,
				ContractResolver = CodeModelContractResolver.Instance,
				PreserveReferencesHandling = PreserveReferencesHandling.Objects
			});

			WriteFile("code-model-v1.yaml", modelAsJson, null);

			return true;

			static void EnumFix(IEnumerable<Model.Schema> schemas)
			{
				foreach (var enumSchema in schemas.Where(
					x => x.Enum?.Count > 0
					&& x.Extensions.ContainsKey(Core.Model.XmsExtensions.Metadata.Name)
					&& !x.Extensions.ContainsKey(Core.Model.XmsExtensions.Enum.Name)
				))
				{
					var metadata = enumSchema.Extensions[Core.Model.XmsExtensions.Metadata.Name] as JObject;
					var extension = new JObject(
						new JProperty("name", metadata["name"]),
						new JProperty("modelAsString", false)
					);
					enumSchema.Extensions.Add(Core.Model.XmsExtensions.Enum.Name, extension);
				}
			}

			static void ResponseFix(IEnumerable<Model.Operation> operations)
			{
				// keeps only 2xx responses
				foreach (var operation in operations)
				{
					if (operation.Responses.Count > 1)
					{
						var validResponses = operation.Responses
							.Where(x => x.Key == "default" || x.Key.StartsWith("2"))
							.ToArray();

						operation.Responses.Clear();

						foreach (var response in validResponses)
						{
							operation.Responses.Add(response.Key, response.Value);
						}
					}
				}
			}
		}
	}
}
