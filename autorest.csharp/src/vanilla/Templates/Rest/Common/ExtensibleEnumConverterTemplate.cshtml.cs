// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Common
{
#line 1 "ExtensibleEnumConverterTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "ExtensibleEnumConverterTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ExtensibleEnumConverterTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.EnumTypeCs>
    {
        #line hidden
        public ExtensibleEnumConverterTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 4 "ExtensibleEnumConverterTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 5 "ExtensibleEnumConverterTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nusing System.Reflection;\n");
#line 7 "ExtensibleEnumConverterTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 8 "ExtensibleEnumConverterTemplate.cshtml"
      Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral(".");
#line 8 "ExtensibleEnumConverterTemplate.cshtml"
                            Write(Settings.ModelsName);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 10 "ExtensibleEnumConverterTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    /// <summary>\n    ");
#line 12 "ExtensibleEnumConverterTemplate.cshtml"
Write(WrapComment("/// ", "Defines values for " + Model.Name + "."));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n");
#line 14 "ExtensibleEnumConverterTemplate.cshtml"
    

#line default
#line hidden

#line 14 "ExtensibleEnumConverterTemplate.cshtml"
      var underlyingType = (Model.UnderlyingType?.ClassName == null)? "string" : Model.UnderlyingType.ClassName;

#line default
#line hidden

            WriteLiteral("    \n    public sealed class ");
#line 16 "ExtensibleEnumConverterTemplate.cshtml"
                    Write(Model.ClassName+"Converter");

#line default
#line hidden
            WriteLiteral(" : Newtonsoft.Json.JsonConverter\n    {\n        ");
#line 18 "ExtensibleEnumConverterTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 20 "ExtensibleEnumConverterTemplate.cshtml"
   Write(WrapComment("/// ", "Returns if objectType can be converted to " + Model.Name + " by the converter."));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public override bool CanConvert(System.Type objectType) \n        { \n            return typeof(");
#line 24 "ExtensibleEnumConverterTemplate.cshtml"
                     Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(").GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());\n        }\n\n        ");
#line 27 "ExtensibleEnumConverterTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 29 "ExtensibleEnumConverterTemplate.cshtml"
   Write(WrapComment("/// ", "Overrides ReadJson and converts token to " + Model.Name + "."));

#line default
#line hidden
            WriteLiteral(@"
        /// </summary>
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
            {
                return null;
            }
            return (");
#line 37 "ExtensibleEnumConverterTemplate.cshtml"
               Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(")serializer.Deserialize<");
#line 37 "ExtensibleEnumConverterTemplate.cshtml"
                                                       Write(underlyingType);

#line default
#line hidden
            WriteLiteral(">(reader);\n        }\n\n        ");
#line 40 "ExtensibleEnumConverterTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 42 "ExtensibleEnumConverterTemplate.cshtml"
   Write(WrapComment("/// ", "Overriding WriteJson for " + Model.Name + " for serialization."));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) \n        { \n            writer.WriteValue(value.ToString());\n        }\n        ");
#line 48 "ExtensibleEnumConverterTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    }\n}");
        }
        #pragma warning restore 1998
    }
}
