// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Common
{
#line 1 "EnumTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "EnumTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class EnumTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.EnumTypeCs>
    {
        #line hidden
        public EnumTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 4 "EnumTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 5 "EnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 6 "EnumTemplate.cshtml"
      Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral(".");
#line 6 "EnumTemplate.cshtml"
                            Write(Settings.ModelsName);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 8 "EnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    /// <summary>\n    ");
#line 10 "EnumTemplate.cshtml"
Write(WrapComment("/// ", "Defines values for " + Model.Name + "."));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n");
#line 12 "EnumTemplate.cshtml"
    

#line default
#line hidden

#line 12 "EnumTemplate.cshtml"
     if (!Model.OldModelAsString)
    {

#line default
#line hidden

            WriteLiteral("    ");
#line 14 "EnumTemplate.cshtml"
  Write(Model.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]\n    public enum ");
#line 16 "EnumTemplate.cshtml"
             Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral("\n    {\n");
#line 18 "EnumTemplate.cshtml"
        var last = Model.Values.Last();
        foreach (var value in Model.Values)
        {
            if (value.Description != null)
            {

#line default
#line hidden

            WriteLiteral("\n        /// <summary>\n        ");
#line 24 "EnumTemplate.cshtml"
   Write(WrapComment("/// ", value.Description));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 26 "EnumTemplate.cshtml"
       
        }

#line default
#line hidden

            WriteLiteral("        [System.Runtime.Serialization.EnumMember(Value = \"");
#line 28 "EnumTemplate.cshtml"
                                                       Write(value.SerializedName);

#line default
#line hidden
            WriteLiteral("\")]\n");
#line 29 "EnumTemplate.cshtml"
          if (value == last)
          {

#line default
#line hidden

            WriteLiteral("        ");
#line 31 "EnumTemplate.cshtml"
      Write(value.MemberName);

#line default
#line hidden
            WriteLiteral("\n");
#line 32 "EnumTemplate.cshtml"
          }
          else
          {

#line default
#line hidden

            WriteLiteral("        ");
#line 35 "EnumTemplate.cshtml"
      Write(value.MemberName);

#line default
#line hidden
            WriteLiteral(",\n");
#line 36 "EnumTemplate.cshtml"
          }
        }

#line default
#line hidden

            WriteLiteral("    }\n\n    internal static class ");
#line 40 "EnumTemplate.cshtml"
                      Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral("EnumExtension\n    {\n        internal static string ToSerializedValue(this ");
#line 42 "EnumTemplate.cshtml"
                                                  Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral("? value)\n        {\n            return value == null ? null : ((");
#line 44 "EnumTemplate.cshtml"
                                        Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(")value).ToSerializedValue();\n        }\n");
#line 46 "EnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        internal static string ToSerializedValue(this ");
#line 47 "EnumTemplate.cshtml"
                                                  Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" value)\n        {\n            switch( value )\n            {\n");
#line 51 "EnumTemplate.cshtml"
            

#line default
#line hidden

#line 51 "EnumTemplate.cshtml"
             for (int i = 0; i < Model.Values.Count; i++)
            {

#line default
#line hidden

            WriteLiteral("\n                case ");
#line 53 "EnumTemplate.cshtml"
                 Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(".");
#line 53 "EnumTemplate.cshtml"
                                    Write(Model.Values[i].MemberName);

#line default
#line hidden
            WriteLiteral(":\n                    return \"");
#line 54 "EnumTemplate.cshtml"
                       Write(Model.Values[i].SerializedName);

#line default
#line hidden
            WriteLiteral("\";");
#line 54 "EnumTemplate.cshtml"
                                                                    
            }

#line default
#line hidden

            WriteLiteral("\n            }\n            return null;\n        }\n");
#line 60 "EnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        internal static ");
#line 61 "EnumTemplate.cshtml"
                    Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral("? Parse");
#line 61 "EnumTemplate.cshtml"
                                             Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral("(this string value)\n        {\n            switch( value )\n            {\n");
#line 65 "EnumTemplate.cshtml"
            

#line default
#line hidden

#line 65 "EnumTemplate.cshtml"
             for (int i = 0; i < Model.Values.Count; i++)
            {

#line default
#line hidden

            WriteLiteral("\n                case \"");
#line 67 "EnumTemplate.cshtml"
                 Write(Model.Values[i].SerializedName);

#line default
#line hidden
            WriteLiteral("\":\n                    return ");
#line 68 "EnumTemplate.cshtml"
                       Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(".");
#line 68 "EnumTemplate.cshtml"
                                          Write(Model.Values[i].MemberName);

#line default
#line hidden
            WriteLiteral(";");
#line 68 "EnumTemplate.cshtml"
                                                                                   
            }

#line default
#line hidden

            WriteLiteral("\n            }\n            return null;\n        }\n    }\n");
#line 75 "EnumTemplate.cshtml"
       
    }
    else
    {

#line default
#line hidden

            WriteLiteral("    ");
#line 79 "EnumTemplate.cshtml"
  Write(Model.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n    public static class ");
#line 80 "EnumTemplate.cshtml"
                     Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral("\n    {\n");
#line 82 "EnumTemplate.cshtml"
        foreach (var t in Model.Values)
        {
            if (t.Description != null)
            {

#line default
#line hidden

            WriteLiteral("\n        /// <summary>\n        ");
#line 87 "EnumTemplate.cshtml"
   Write(WrapComment("/// ", t.Description));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 89 "EnumTemplate.cshtml"
       
            }

#line default
#line hidden

            WriteLiteral("        public const string ");
#line 91 "EnumTemplate.cshtml"
                         Write(t.MemberName);

#line default
#line hidden
            WriteLiteral(" = \"");
#line 91 "EnumTemplate.cshtml"
                                          Write(t.SerializedName);

#line default
#line hidden
            WriteLiteral("\";\n");
#line 92 "EnumTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("    }\n");
#line 94 "EnumTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("}");
        }
        #pragma warning restore 1998
    }
}
