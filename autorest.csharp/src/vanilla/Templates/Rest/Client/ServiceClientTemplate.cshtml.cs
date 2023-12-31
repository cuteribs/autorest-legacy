// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "ServiceClientTemplate.cshtml"
using System

#line default
#line hidden
    ;
#line 2 "ServiceClientTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 4 "ServiceClientTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientTemplate : AutoRest.Core.Template<CodeModelCs>
    {
        #line hidden
        public ServiceClientTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 6 "ServiceClientTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 7 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nusing Microsoft.Rest;\nusing ");
#line 9 "ServiceClientTemplate.cshtml"
  Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral(".");
#line 9 "ServiceClientTemplate.cshtml"
                        Write(Settings.InterfaceFolder);

#line default
#line hidden
            WriteLiteral(";\n");
#line 10 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 11 "ServiceClientTemplate.cshtml"
     Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 13 "ServiceClientTemplate.cshtml"
 foreach (var usingString in Model.Usings)
{

#line default
#line hidden

            WriteLiteral("    using ");
#line 15 "ServiceClientTemplate.cshtml"
       Write(usingString);

#line default
#line hidden
            WriteLiteral(";\n");
#line 16 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 17 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 18 "ServiceClientTemplate.cshtml"
    

#line default
#line hidden

#line 18 "ServiceClientTemplate.cshtml"
     if (!string.IsNullOrWhiteSpace(Model.Documentation))
    {

#line default
#line hidden

            WriteLiteral("    /// <summary>\n    ");
#line 21 "ServiceClientTemplate.cshtml"
 Write(WrapComment("/// ", Model.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n");
#line 23 "ServiceClientTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("\n    public partial class ");
#line 25 "ServiceClientTemplate.cshtml"
                    Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" : Microsoft.Rest.ServiceClient<");
#line 25 "ServiceClientTemplate.cshtml"
                                                               Write(Model.Name);

#line default
#line hidden
            WriteLiteral(">, I");
#line 25 "ServiceClientTemplate.cshtml"
                                                                               Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\n    {\n        ");
#line 27 "ServiceClientTemplate.cshtml"
    Write(Include(new ServiceClientBodyTemplate(), Model));

#line default
#line hidden
            WriteLiteral(@"

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary> 
        partial void CustomInitialize();

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
");
#line 39 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 39 "ServiceClientTemplate.cshtml"
         foreach (var operation in Model.AllOperations) 
        {

#line default
#line hidden

            WriteLiteral("            this.");
#line 41 "ServiceClientTemplate.cshtml"
               Write(operation.NameForProperty);

#line default
#line hidden
            WriteLiteral(" = new ");
#line 41 "ServiceClientTemplate.cshtml"
                                                  Write(operation.TypeName);

#line default
#line hidden
            WriteLiteral("(this);\n");
#line 42 "ServiceClientTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("\n");
#line 44 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 44 "ServiceClientTemplate.cshtml"
         if (Model.IsCustomBaseUri)
        {

#line default
#line hidden

            WriteLiteral("            this.BaseUri = \"");
#line 46 "ServiceClientTemplate.cshtml"
                         Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\";\n");
#line 47 "ServiceClientTemplate.cshtml"
        }
        else
        {

#line default
#line hidden

            WriteLiteral("            this.BaseUri = new System.Uri(\"");
#line 50 "ServiceClientTemplate.cshtml"
                                        Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\");\n");
#line 51 "ServiceClientTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("\n");
#line 53 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 53 "ServiceClientTemplate.cshtml"
         foreach (var property in Model.Properties.Where(p => !p.DefaultValue.IsNullOrEmpty()))
        {

#line default
#line hidden

            WriteLiteral("            this.");
#line 55 "ServiceClientTemplate.cshtml"
               Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 55 "ServiceClientTemplate.cshtml"
                                  Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral(";\n");
#line 56 "ServiceClientTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral(@"
            SerializationSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new Microsoft.Rest.Serialization.ReadOnlyJsonContractResolver(),
                Converters = new  System.Collections.Generic.List<Newtonsoft.Json.JsonConverter>
                    {
                        new Microsoft.Rest.Serialization.Iso8601TimeSpanConverter()
                    }
            };
");
#line 71 "ServiceClientTemplate.cshtml"
            

#line default
#line hidden

#line 71 "ServiceClientTemplate.cshtml"
             if (Model.NeedsTransformationConverter)
            {

#line default
#line hidden

            WriteLiteral("            SerializationSettings.Converters.Add(new Microsoft.Rest.Serialization.TransformationJsonConverter());\n");
#line 74 "ServiceClientTemplate.cshtml"
            }

#line default
#line hidden

            WriteLiteral(@"            DeserializationSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new Microsoft.Rest.Serialization.ReadOnlyJsonContractResolver(),
                Converters = new System.Collections.Generic.List<Newtonsoft.Json.JsonConverter>
                    {
                        new Microsoft.Rest.Serialization.Iso8601TimeSpanConverter()
                    }
            };
");
#line 87 "ServiceClientTemplate.cshtml"
            

#line default
#line hidden

#line 87 "ServiceClientTemplate.cshtml"
             foreach (var polymorphicType in Model.ModelTypes.Where(t => t.IsPolymorphic))
            {

#line default
#line hidden

            WriteLiteral("            SerializationSettings.Converters.Add(new Microsoft.Rest.Serialization.PolymorphicSerializeJsonConverter<");
#line 89 "ServiceClientTemplate.cshtml"
                                                                                                                  Write(polymorphicType.Name);

#line default
#line hidden
            WriteLiteral(">(\"");
#line 89 "ServiceClientTemplate.cshtml"
                                                                                                                                            Write(polymorphicType.PolymorphicDiscriminator);

#line default
#line hidden
            WriteLiteral("\"));\n            DeserializationSettings.Converters.Add(new  Microsoft.Rest.Serialization.PolymorphicDeserializeJsonConverter<");
#line 90 "ServiceClientTemplate.cshtml"
                                                                                                                       Write(polymorphicType.Name);

#line default
#line hidden
            WriteLiteral(">(\"");
#line 90 "ServiceClientTemplate.cshtml"
                                                                                                                                                 Write(polymorphicType.PolymorphicDiscriminator);

#line default
#line hidden
            WriteLiteral("\"));\n");
#line 91 "ServiceClientTemplate.cshtml"
            }

#line default
#line hidden

            WriteLiteral("\n            CustomInitialize();\n            \n");
#line 95 "ServiceClientTemplate.cshtml"
            

#line default
#line hidden

#line 95 "ServiceClientTemplate.cshtml"
             if (Model.NeedsTransformationConverter)
            {

#line default
#line hidden

            WriteLiteral("            DeserializationSettings.Converters.Add(new Microsoft.Rest.Serialization.TransformationJsonConverter());\n");
#line 98 "ServiceClientTemplate.cshtml"
            }

#line default
#line hidden

            WriteLiteral("    \n        }    \n    \n");
#line 102 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 102 "ServiceClientTemplate.cshtml"
         foreach (MethodCs method in Model.Methods.Where( m => m.Group.IsNullOrEmpty()))
        {

#line default
#line hidden

            WriteLiteral("        ");
#line 104 "ServiceClientTemplate.cshtml"
      Write(Include(new MethodTemplate(), method));

#line default
#line hidden
            WriteLiteral("\n");
#line 105 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 105 "ServiceClientTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 105 "ServiceClientTemplate.cshtml"
                  

#line default
#line hidden

            WriteLiteral("        \n");
#line 107 "ServiceClientTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("    }\n}");
        }
        #pragma warning restore 1998
    }
}
