﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoRest.Core.Utilities;
using Newtonsoft.Json.Linq;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.Core
{
	public interface IHost
	{
		Task<string> ReadFile(string filename);
		Task<T> GetValue<T>(string key);
		Task<string> GetValue(string key);
		Task<string[]> ListInputs();
		Task<string[]> ListInputs(string artifactType);
		Task ProtectFiles(string path);
		Task<string> GetConfigurationFile(string filename);
		void UpdateConfigurationFile(string filename, string content);
		void WriteFile(string filename, string content, object sourcemap);
		void WriteFile(string filename, string content, object sourcemap, string artifactType);
	}

	public class NullHost : IHost
	{
		public Task<string> ReadFile(string filename) => string.Empty.AsResultTask();
		public Task<T> GetValue<T>(string key) => (default(T)).AsResultTask();
		public Task<string> GetValue(string key) => string.Empty.AsResultTask();
		public Task<string[]> ListInputs() => (new string[0]).AsResultTask();
		public Task<string[]> ListInputs(string artifactType) => (new string[0]).AsResultTask();
		public Task ProtectFiles(string path) => string.Empty.AsResultTask();
		public Task<string> GetConfigurationFile(string filename) => string.Empty.AsResultTask();
		public void UpdateConfigurationFile(string filename, string content) { }
		public void WriteFile(string filename, string content, object sourcemap) { }
		public void WriteFile(string filename, string content, object sourcemap, string artifactType) { }
	}
	public class Settings : IsSingleton<Settings>
	{
		public const int DefaultMaximumCommentColumns = 80;

		/// <summary>
		/// Returns the version of this instance of AutoRest.
		/// </summary>
		public static string Version => typeof(Settings).GetAssembly().GetName().Version.ToString();

		public const string DefaultCodeGenerationHeader = @"Code generated by Microsoft (R) AutoRest Code Generator {0}
Changes may cause incorrect behavior and will be lost if the code is regenerated.";

		public const string DefaultCodeGenerationHeaderWithoutVersion = @"Code generated by Microsoft (R) AutoRest Code Generator.
Changes may cause incorrect behavior and will be lost if the code is regenerated.";

		public const string MicrosoftApacheLicenseHeader = @"Copyright (c) Microsoft and contributors.  All rights reserved.

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

See the License for the specific language governing permissions and
limitations under the License.
";

		public const string MicrosoftMitLicenseHeader = @"Copyright (c) Microsoft Corporation.
Licensed under the MIT License.
";

		public IHost Host = new NullHost();
		private string _header;

		public Settings()
		{
			// this instance of the settings object should be used for subsequent 
			// requests for settings.
			Singleton<Settings>.Instance = this;

			FileSystemInput = new MemoryFileSystem();
			FileSystemOutput = new MemoryFileSystem();
			CustomSettings = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
			Header = string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeaderWithoutVersion, Settings.Version);
			CodeGenerator = "CSharp";
			ModelsName = "Models";
			CodeGenerationMode = "rest-client";
			MaximumCommentColumns = DefaultMaximumCommentColumns;
		}

		/// <summary>
		/// Gets or sets the IFileSystem used by code generation.
		/// </summary>
		public MemoryFileSystem FileSystemInput { get; set; }

		/// <summary>
		/// Gets the Uri for the path to the folder that contains the input specification file.
		/// </summary>
		public MemoryFileSystem FileSystemOutput { get; set; }

		/// <summary>
		/// Custom provider specific settings.
		/// </summary>
		public IDictionary<string, object> CustomSettings { get; private set; }

		// The CommandLineInfo attribute is reflected to display help.
		// Prefer to show required properties before optional.
		// Although not guaranteed by the Framework, the iteration order matches the
		// order of definition.

		#region ordered_properties

		public int MaximumCommentColumns { get; set; }

		/// <summary>
		/// Gets or sets the path to the input specification file.
		/// </summary>
		public string Input { get; set; }

		/// <summary>
		/// Gets or sets a name for the generated client models Namespace and Models output folder
		/// </summary>
		public string ModelsName { get; set; }

		/// <summary>
		/// Gets or sets a name for the generated client interfaces Namespace and Models output folder
		/// </summary>
		public string InterfaceFolder { get; set; } =  "Interfaces";

		/// <summary>
		/// Gets or sets a base namespace for generated code.
		/// </summary>
		public string Namespace { get; set; }

		/// <summary>
		/// Gets or sets the code generation language.
		/// </summary>
		public string CodeGenerator { get; set; }

		/// <summary>
		/// Gets or sets a custom base interface for generated API Client.
		/// </summary>
		public string CustomInterface { get; set; }

		#endregion

		/// <summary>
		/// Gets or sets a name of the generated client type. If not specified, will use
		/// a value from the specification. For Swagger specifications,
		/// the value of the 'Title' field is used.
		/// </summary>
		public string ClientName { get; set; }

		/// <summary>
		/// Gets or sets the maximum number of properties in the request body.
		/// If the number of properties in the request body is less than or
		/// equal to this value, then these properties will be represented as method arguments.
		/// </summary>
		public int PayloadFlatteningThreshold { get; set; }

		/// <summary>
		/// Gets or sets the code generation mode (Server or Client)
		/// If the CodeGenerationMode is Server, AutoRest generates the server code for given spec
		/// else generates (by default) the client code for spec
		/// </summary>
		public string CodeGenerationMode { get; set; }

		/// <summary>
		/// Gets or sets a comment header to include in each generated file.
		/// </summary>
		public string Header
		{
			get { return _header; }
			set
			{
				if (value == "MICROSOFT_MIT")
				{
					_header = MicrosoftMitLicenseHeader + Environment.NewLine + string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeader, Settings.Version);
				}
				else if (value == "MICROSOFT_APACHE")
				{
					_header = MicrosoftApacheLicenseHeader + Environment.NewLine + string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeader, Settings.Version);
				}
				else if (value == "MICROSOFT_MIT_NO_VERSION")
				{
					_header = MicrosoftMitLicenseHeader + Environment.NewLine + DefaultCodeGenerationHeaderWithoutVersion;
				}
				else if (value == "MICROSOFT_APACHE_NO_VERSION")
				{
					_header = MicrosoftApacheLicenseHeader + Environment.NewLine + DefaultCodeGenerationHeaderWithoutVersion;
				}
				else if (value == "MICROSOFT_MIT_NO_CODEGEN")
				{
					_header = MicrosoftMitLicenseHeader + Environment.NewLine + "Code generated by Microsoft (R) AutoRest Code Generator.";
				}
				else if (value == "NONE")
				{
					_header = String.Empty;
				}
				else if (value == "MICROSOFT_MIT_SMALL")
				{
					_header = MicrosoftMitLicenseHeader + "Code generated by Microsoft (R) AutoRest Code Generator.";
				}
				else if (value == "MICROSOFT_MIT_SMALL_NO_CODEGEN")
				{
					_header = MicrosoftMitLicenseHeader;
				}
				else
				{
					_header = value;
				}
			}
		}

		/// <summary>
		/// If set to true, generate client with a ServiceClientCredentials property and optional constructor parameter.
		/// </summary>
		public bool AddCredentials { get; set; }

		/// <summary>
		/// If set, will cause generated code to be output to a single file. Not supported by all code generators.
		/// </summary>
		public string OutputFileName { get; set; }

		/// <summary>
		/// If set to true, collect and print out more detailed messages.
		/// </summary>
		public bool Verbose { get; set; }

		/// <summary>
		/// PackageName of then generated code package. Should be then names wanted for the package in then package manager.
		/// </summary>
		public string PackageName { get; set; }

		/// <summary>
		/// PackageName of then generated code package. Should be then names wanted for the package in then package manager.
		/// </summary>
		public string PackageVersion { get; set; }

		/// <summary>
		/// Sets object properties from the dictionary matching keys to property names or aliases.
		/// </summary>
		/// <param name="entityToPopulate">Object to populate from dictionary.</param>
		/// <param name="settings">Dictionary of settings.Settings that are populated get removed from the dictionary.</param>
		/// <returns>Dictionary of settings that were not matched.</returns>
		public static void PopulateSettings(object entityToPopulate, IDictionary<string, object> settings)
		{
			if (entityToPopulate == null)
			{
				throw new ArgumentNullException("entityToPopulate");
			}

			if (settings != null && settings.Count > 0)
			{
				// Setting property value from dictionary
				foreach (var setting in settings.ToArray())
				{
					PropertyInfo property = entityToPopulate.GetType().GetProperties()
						.FirstOrDefault(p => setting.Key.EqualsIgnoreCase(p.Name));

					if (property != null)
					{
						Type propertyType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
						try
						{
							if (propertyType == typeof(bool) && (setting.Value == null || setting.Value.ToString().IsNullOrEmpty()))
							{
								property.SetValue(entityToPopulate, true);
							}
							else if (propertyType.IsEnum())
							{
								property.SetValue(entityToPopulate, Enum.Parse(propertyType, setting.Value.ToString(), true));
							}
							else if (propertyType.IsArray && setting.Value.GetType() == typeof(JArray))
							{
								var elementType = propertyType.GetElementType();
								if (elementType == typeof(string))
								{
									var stringArray = ((JArray)setting.Value).Children().
									Select(
										c => c.ToString())
									.ToArray();

									property.SetValue(entityToPopulate, stringArray);
								}
								else if (elementType == typeof(int))
								{
									var intValues = ((JArray)setting.Value).Children().
										 Select(c => (int)Convert.ChangeType(c, elementType, CultureInfo.InvariantCulture))
										 .ToArray();
									property.SetValue(entityToPopulate, intValues);
								}
							}
							else if (property.CanWrite)
							{
								property.SetValue(entityToPopulate,
									Convert.ChangeType(setting.Value, propertyType, CultureInfo.InvariantCulture), null);
							}

							settings.Remove(setting.Key);
						}
						catch (Exception exception)
						{
							throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "Parameter '{0}' value is not valid. Expect '{1}'",
								setting.Key, property.GetType().Name), exception);
						}
					}
				}
			}
		}
	}
}
