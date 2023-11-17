// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Common
{
#line 1 "ExtensibleEnumTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "ExtensibleEnumTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ExtensibleEnumTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.EnumTypeCs>
    {
        #line hidden
        public ExtensibleEnumTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 4 "ExtensibleEnumTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 5 "ExtensibleEnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 6 "ExtensibleEnumTemplate.cshtml"
      Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral(".");
#line 6 "ExtensibleEnumTemplate.cshtml"
                            Write(Settings.ModelsName);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 8 "ExtensibleEnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    /// <summary>\n    ");
#line 10 "ExtensibleEnumTemplate.cshtml"
Write(WrapComment("/// ", "Defines values for " + Model.Name + "."));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n");
#line 12 "ExtensibleEnumTemplate.cshtml"
    

#line default
#line hidden

#line 12 "ExtensibleEnumTemplate.cshtml"
      var underlyingType = (Model.UnderlyingType?.ClassName == null)? "string" : Model.UnderlyingType.ClassName;
    var hasAllowedValues = Model.Values.Any(val=>val.AllowedValues.Any());

#line default
#line hidden

            WriteLiteral("    \n    /// <summary>\n    ");
#line 16 "ExtensibleEnumTemplate.cshtml"
Write(WrapComment("/// ", "Determine base value for a given allowed value if exists, else return the value itself"));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n    [Newtonsoft.Json.JsonConverter(typeof(");
#line 18 "ExtensibleEnumTemplate.cshtml"
                                      Write(Model.ClassName + "Converter");

#line default
#line hidden
            WriteLiteral("))]\n    ");
#line 19 "ExtensibleEnumTemplate.cshtml"
Write(Model.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n    public struct ");
#line 20 "ExtensibleEnumTemplate.cshtml"
             Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" : System.IEquatable<");
#line 20 "ExtensibleEnumTemplate.cshtml"
                                                  Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(">\n    {\n        private ");
#line 22 "ExtensibleEnumTemplate.cshtml"
           Write(Model.ClassName);

#line default
#line hidden
#line 22 "ExtensibleEnumTemplate.cshtml"
                            Write("("+underlyingType);

#line default
#line hidden
            WriteLiteral(" underlyingValue)\n        {\n            UnderlyingValue=underlyingValue;\n        }\n    \n        ");
#line 27 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 28 "ExtensibleEnumTemplate.cshtml"
        

#line default
#line hidden

#line 28 "ExtensibleEnumTemplate.cshtml"
         foreach (var t in Model.Values)
        {
            if (t.Description != null)
            {

#line default
#line hidden

            WriteLiteral("\n        /// <summary>\n        ");
#line 34 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", t.Description));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>");
#line 35 "ExtensibleEnumTemplate.cshtml"
                             
            }
            var initName = (underlyingType == "string") ? "\""+t.SerializedName+"\"": t.SerializedName;

#line default
#line hidden

            WriteLiteral("\n        public static readonly ");
#line 39 "ExtensibleEnumTemplate.cshtml"
                          Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" ");
#line 39 "ExtensibleEnumTemplate.cshtml"
                                           Write(t.MemberName);

#line default
#line hidden
            WriteLiteral(" = ");
#line 39 "ExtensibleEnumTemplate.cshtml"
                                                            Write(initName);

#line default
#line hidden
            WriteLiteral(";\n        ");
#line 40 "ExtensibleEnumTemplate.cshtml"
               
        

#line default
#line hidden

#line 41 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 41 "ExtensibleEnumTemplate.cshtml"
                  
        }

#line default
#line hidden

            WriteLiteral("    \n\n");
#line 45 "ExtensibleEnumTemplate.cshtml"
        

#line default
#line hidden

#line 45 "ExtensibleEnumTemplate.cshtml"
         if(hasAllowedValues)
        {

#line default
#line hidden

            WriteLiteral("        ");
#line 47 "ExtensibleEnumTemplate.cshtml"
     Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 49 "ExtensibleEnumTemplate.cshtml"
     Write(WrapComment("/// ", "Determine base value for a given allowed value if exists, else return the value itself"));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        private static ");
#line 51 "ExtensibleEnumTemplate.cshtml"
                    Write(underlyingType);

#line default
#line hidden
            WriteLiteral(" GetBaseValueForAllowedValue(");
#line 51 "ExtensibleEnumTemplate.cshtml"
                                                                Write(underlyingType);

#line default
#line hidden
            WriteLiteral(" value)\n        {\n            switch(value)\n            {\n");
#line 55 "ExtensibleEnumTemplate.cshtml"
                

#line default
#line hidden

#line 55 "ExtensibleEnumTemplate.cshtml"
                 foreach(var enumValue in Model.Values)
                {
                    

#line default
#line hidden

#line 57 "ExtensibleEnumTemplate.cshtml"
                     if(enumValue.AllowedValues.Any())
                    {
                    

#line default
#line hidden

#line 59 "ExtensibleEnumTemplate.cshtml"
                     foreach(var allowedValue in enumValue.AllowedValues)
                    {

#line default
#line hidden

            WriteLiteral("                case ");
#line 61 "ExtensibleEnumTemplate.cshtml"
                   Write((underlyingType=="string")? "\""+allowedValue+"\"":allowedValue);

#line default
#line hidden
            WriteLiteral(":\n");
#line 62 "ExtensibleEnumTemplate.cshtml"
                    }

#line default
#line hidden

#line 62 "ExtensibleEnumTemplate.cshtml"
                     

#line default
#line hidden

            WriteLiteral("                    return ");
#line 63 "ExtensibleEnumTemplate.cshtml"
                         Write((underlyingType=="string")? "\""+enumValue.Name+"\"": enumValue.Name);

#line default
#line hidden
            WriteLiteral(";\n");
#line 64 "ExtensibleEnumTemplate.cshtml"
                    }

#line default
#line hidden

#line 64 "ExtensibleEnumTemplate.cshtml"
                     
                }

#line default
#line hidden

#line 65 "ExtensibleEnumTemplate.cshtml"
                 

#line default
#line hidden

            WriteLiteral("                default:\n                    return value;\n            }\n        }\n");
#line 70 "ExtensibleEnumTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("\n        ");
#line 72 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 74 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Underlying value of enum "+Model.ClassName));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        private readonly ");
#line 76 "ExtensibleEnumTemplate.cshtml"
                    Write(underlyingType);

#line default
#line hidden
            WriteLiteral(" UnderlyingValue;\n\n        ");
#line 78 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 80 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Returns string representation for "+Model.ClassName));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public override string ToString()\n        { \n            return UnderlyingValue == null ? null : UnderlyingValue.ToString(); \n        }\n\n        ");
#line 87 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 89 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Compares enums of type "+Model.ClassName));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public bool Equals(");
#line 91 "ExtensibleEnumTemplate.cshtml"
                      Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" e) \n        {\n            return ");
#line 93 "ExtensibleEnumTemplate.cshtml"
               Write((hasAllowedValues)? "GetBaseValueForAllowedValue(e.UnderlyingValue).Equals(GetBaseValueForAllowedValue(UnderlyingValue))" : "UnderlyingValue.Equals(e.UnderlyingValue)");

#line default
#line hidden
            WriteLiteral(";\n        }\n\n        ");
#line 96 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 98 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Implicit operator to convert "+underlyingType+" to "+Model.ClassName));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public static implicit operator ");
#line 100 "ExtensibleEnumTemplate.cshtml"
                                    Write(Model.ClassName  +"("+ underlyingType +" value)");

#line default
#line hidden
            WriteLiteral(" \n        {\n            return new ");
#line 102 "ExtensibleEnumTemplate.cshtml"
                   Write(Model.ClassName+"(value)");

#line default
#line hidden
            WriteLiteral(";\n        }\n\n        ");
#line 105 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 107 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Implicit operator to convert "+Model.ClassName+" to "+underlyingType));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public static implicit operator string(");
#line 109 "ExtensibleEnumTemplate.cshtml"
                                          Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" e)\n        { \n            return e.UnderlyingValue;\n        }\n\n        ");
#line 114 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 116 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Overriding == operator for enum "+Model.ClassName));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public static bool operator == (");
#line 118 "ExtensibleEnumTemplate.cshtml"
                                   Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" e1, ");
#line 118 "ExtensibleEnumTemplate.cshtml"
                                                        Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" e2) \n        { \n            return e2.Equals(e1); \n        }\n\n        ");
#line 123 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 125 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Overriding != operator for enum "+Model.ClassName));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public static bool operator != (");
#line 127 "ExtensibleEnumTemplate.cshtml"
                                   Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" e1, ");
#line 127 "ExtensibleEnumTemplate.cshtml"
                                                        Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" e2) \n        { \n            return !e2.Equals(e1); \n        }\n\n        ");
#line 132 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 134 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Overrides Equals operator for "+Model.ClassName));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public override bool Equals(object obj) \n        {\n            return obj is ");
#line 138 "ExtensibleEnumTemplate.cshtml"
                     Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(" && this.Equals((");
#line 138 "ExtensibleEnumTemplate.cshtml"
                                                      Write(Model.ClassName);

#line default
#line hidden
            WriteLiteral(")obj);\n        }\n            \n        ");
#line 141 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        ");
#line 143 "ExtensibleEnumTemplate.cshtml"
   Write(WrapComment("/// ", "Returns for hashCode "+Model.ClassName));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public override int GetHashCode()\n        {\n            return ");
#line 147 "ExtensibleEnumTemplate.cshtml"
               Write((hasAllowedValues)? "GetBaseValueForAllowedValue(UnderlyingValue).GetHashCode()" :"UnderlyingValue.GetHashCode()");

#line default
#line hidden
            WriteLiteral(";\n        }\n\n        ");
#line 150 "ExtensibleEnumTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("    \n    }\n}");
        }
        #pragma warning restore 1998
    }
}
