using AutoRest.Core.Utilities;
using AutoRest.Modeler;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestProject1;

public class ModelerTest
{
	[Fact]
	public void Test1()
	{
		var path = @"C:\git\dnv\ApiClients\assets\swagger.json";
		var swagger = File.ReadAllText(path);
		var serviceDefinition = SwaggerParser.Parse(swagger);
		Assert.NotNull(serviceDefinition);

		foreach (var enumSchema in serviceDefinition.Components.Schemas.Where(
			x => x.Value.Enum?.Count > 0 && x.Value.Extensions.Count == 0
		))
		{
			var extension = new JObject(new JProperty("name", enumSchema.Key), new JProperty("modelAsString", false));
			enumSchema.Value.Extensions.Add(AutoRest.Core.Model.XmsExtensions.Enum.Name, extension);
		}

		var modeler = new SwaggerModeler();
		var codeModel = modeler.Build(serviceDefinition);
		Assert.NotNull(codeModel);


		var modelAsJson = JsonConvert.SerializeObject(codeModel, new JsonSerializerSettings
		{
			Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) },
			NullValueHandling = NullValueHandling.Ignore,
			ContractResolver = CodeModelContractResolver.Instance,
			PreserveReferencesHandling = PreserveReferencesHandling.Objects
		});
		using var sw = new StreamWriter(@"C:\git\dnv\ApiClients\assets\codeModel.txt");
		sw.WriteLine(modelAsJson);
	}
}