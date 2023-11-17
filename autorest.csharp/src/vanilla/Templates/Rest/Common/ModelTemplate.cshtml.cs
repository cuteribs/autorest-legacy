// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Common
{
#line 1 "ModelTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "ModelTemplate.cshtml"
using AutoRest.Core

#line default
#line hidden
    ;
#line 3 "ModelTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "ModelTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "ModelTemplate.cshtml"
using AutoRest.CSharp

#line default
#line hidden
    ;
#line 6 "ModelTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
#line 7 "ModelTemplate.cshtml"
using AutoRest.Extensions

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ModelTemplate : Template<global::AutoRest.CSharp.Model.CompositeTypeCs>
    {
        #line hidden
        public ModelTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 9 "ModelTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 10 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 11 "ModelTemplate.cshtml"
      Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral(".");
#line 11 "ModelTemplate.cshtml"
                            Write(Settings.ModelsName);

#line default
#line hidden
            WriteLiteral("\n{\n    using System.Linq;\n");
#line 14 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 16 "ModelTemplate.cshtml"
 if (!string.IsNullOrEmpty(Model.EffectiveDocumentation))
{

#line default
#line hidden

            WriteLiteral("    /// <summary>\n    ");
#line 19 "ModelTemplate.cshtml"
 Write(WrapComment("/// ", Model.EffectiveDocumentation));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n");
#line 21 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 22 "ModelTemplate.cshtml"
 if (!string.IsNullOrEmpty(Model.Summary) && !string.IsNullOrWhiteSpace(Model.Documentation))
{

#line default
#line hidden

            WriteLiteral("    /// <remarks>\n    ");
#line 25 "ModelTemplate.cshtml"
 Write(WrapComment("/// ", Model.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n    /// </remarks>\n");
#line 27 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 28 "ModelTemplate.cshtml"
 if (Model.NeedsPolymorphicConverter)
{

#line default
#line hidden

            WriteLiteral("    [Newtonsoft.Json.JsonObject(\"");
#line 30 "ModelTemplate.cshtml"
                              Write(Model.SerializedName);

#line default
#line hidden
            WriteLiteral("\")]\n");
#line 31 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 32 "ModelTemplate.cshtml"
 if (Model.NeedsTransformationConverter)
{

#line default
#line hidden

            WriteLiteral("    [Microsoft.Rest.Serialization.JsonTransformation]\n");
#line 35 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    ");
#line 36 "ModelTemplate.cshtml"
Write(Model.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n    public partial class ");
#line 37 "ModelTemplate.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#line 37 "ModelTemplate.cshtml"
                                Write(Model.BaseModelType != null ? " : " + Model.BaseModelType.Name : "");

#line default
#line hidden
            WriteLiteral("\n    {\n        /// <summary>\n        ");
#line 40 "ModelTemplate.cshtml"
   Write(WrapComment("/// ", ("Initializes a new instance of the " + Model.Name + " class.").EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public ");
#line 42 "ModelTemplate.cshtml"
           Write(Model.Name);

#line default
#line hidden
            WriteLiteral("()\n        {\n");
#line 44 "ModelTemplate.cshtml"
 foreach(var property in Model.ComposedProperties.Where(p => p.ModelType is CompositeType ct
    && !p.IsConstant
    && p.IsRequired
    && ct.ContainsConstantProperties))
{

#line default
#line hidden

            WriteLiteral("            this.");
#line 49 "ModelTemplate.cshtml"
               Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = new ");
#line 49 "ModelTemplate.cshtml"
                                      Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral("();\n");
#line 50 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            CustomInit();\n        }\n\n        ");
#line 54 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 56 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 56 "ModelTemplate.cshtml"
         if (!string.IsNullOrEmpty(Model.ConstructorParameters))
        {

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 59 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", ("Initializes a new instance of the " + Model.Name + " class.").EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 61 "ModelTemplate.cshtml"
foreach (var parameter in Model.ConstructorParametersDocumentation)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 63 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", parameter));

#line default
#line hidden
            WriteLiteral("\n");
#line 64 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        public ");
#line 65 "ModelTemplate.cshtml"
             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 65 "ModelTemplate.cshtml"
                          Write(Model.ConstructorParameters);

#line default
#line hidden
            WriteLiteral(")\n");
#line 66 "ModelTemplate.cshtml"
if (!string.IsNullOrEmpty(Model.BaseConstructorCall))
{

#line default
#line hidden

            WriteLiteral("            ");
#line 68 "ModelTemplate.cshtml"
          Write(Model.BaseConstructorCall);

#line default
#line hidden
            WriteLiteral("\n");
#line 69 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        {\n");
#line 71 "ModelTemplate.cshtml"

foreach (var property in Model.InstanceProperties)
{

#line default
#line hidden

            WriteLiteral("            this.");
#line 74 "ModelTemplate.cshtml"
               Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 74 "ModelTemplate.cshtml"
                                  Write(CodeNamer.Instance.CamelCase(property.Name));

#line default
#line hidden
            WriteLiteral(";\n");
#line 75 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            CustomInit();\n        }\n");
#line 78 "ModelTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("\n");
#line 80 "ModelTemplate.cshtml"
 if (Model.ClassProperties.Any())
{

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 83 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", ("Static constructor for " + Model.Name + " class.").EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        static ");
#line 85 "ModelTemplate.cshtml"
             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("()\n        {\n");
#line 87 "ModelTemplate.cshtml"
foreach (var property in Model.ClassProperties)
{

#line default
#line hidden

            WriteLiteral("            ");
#line 89 "ModelTemplate.cshtml"
          Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 89 "ModelTemplate.cshtml"
                             Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral(";\n");
#line 90 "ModelTemplate.cshtml"
}


#line default
#line hidden

            WriteLiteral("        }\n");
#line 93 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 94 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        /// An initialization method that performs custom operations like setting defaults\n        /// </summary>\n        partial void CustomInit();\n        \n        ");
#line 100 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 101 "ModelTemplate.cshtml"
 foreach (PropertyCs property in Model.InstanceProperties)
{

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 104 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.GetFormattedPropertySummary()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 106 "ModelTemplate.cshtml"
            if(!string.IsNullOrEmpty(property.Summary) && !string.IsNullOrEmpty(property.Documentation))
            { 

#line default
#line hidden

            WriteLiteral("        /// <remarks>\n        ");
#line 109 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.Documentation));

#line default
#line hidden
            WriteLiteral("\n        /// </remarks>\n");
#line 111 "ModelTemplate.cshtml"
            }
foreach (var conv in property.JsonConverters)
{

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonConverter(typeof(");
#line 114 "ModelTemplate.cshtml"
                                           Write(conv);

#line default
#line hidden
            WriteLiteral("))]\n");
#line 115 "ModelTemplate.cshtml"
}
switch (property.Flavor)
{
    case PropertyFlavor.AdditionalProperties:

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonExtensionData]\n");
#line 120 "ModelTemplate.cshtml"
        break;
    case PropertyFlavor.ForwardTo:
    case PropertyFlavor.Implementation:

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonIgnore]\n");
#line 124 "ModelTemplate.cshtml"
        break;
    case PropertyFlavor.Regular:

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonProperty(PropertyName = \"");
#line 126 "ModelTemplate.cshtml"
                                                   Write(property.SerializedName);

#line default
#line hidden
            WriteLiteral("\")]\n");
#line 127 "ModelTemplate.cshtml"
        break;
    default:
        throw new System.NotImplementedException();
}

#line default
#line hidden

            WriteLiteral("        ");
#line 131 "ModelTemplate.cshtml"
      Write(property.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n");
#line 132 "ModelTemplate.cshtml"
switch (property.Flavor)
{
    case PropertyFlavor.ForwardTo:

#line default
#line hidden

            WriteLiteral("        public ");
#line 135 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 135 "ModelTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral("\n        { \n            get { return this.");
#line 137 "ModelTemplate.cshtml"
                            Write(property.ForwardTo.Name);

#line default
#line hidden
            WriteLiteral("; }\n            set { this.");
#line 138 "ModelTemplate.cshtml"
                     Write(property.ForwardTo.Name);

#line default
#line hidden
            WriteLiteral(" = value; }\n        }\n");
#line 140 "ModelTemplate.cshtml"
        break;
    case PropertyFlavor.Implementation:
        var impl = property.GetImplementation("csharp");
        if (impl == null)
        {

#line default
#line hidden

            WriteLiteral("        public ");
#line 145 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 145 "ModelTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get; ");
#line 145 "ModelTemplate.cshtml"
                                                           Write(property.IsReadOnly ? "private " : "");

#line default
#line hidden
            WriteLiteral("set; }\n");
#line 146 "ModelTemplate.cshtml"
        }
        else
        {

#line default
#line hidden

            WriteLiteral("        public ");
#line 149 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 149 "ModelTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral("\n        { \n        ");
#line 151 "ModelTemplate.cshtml"
     Write(impl);

#line default
#line hidden
            WriteLiteral("\n        }\n");
#line 153 "ModelTemplate.cshtml"
        }
        break;
    case PropertyFlavor.AdditionalProperties:
    case PropertyFlavor.Regular:

#line default
#line hidden

            WriteLiteral("        public ");
#line 157 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 157 "ModelTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get; ");
#line 157 "ModelTemplate.cshtml"
                                                           Write(property.IsReadOnly ? "private " : "");

#line default
#line hidden
            WriteLiteral("set; }\n");
#line 158 "ModelTemplate.cshtml"
        break;
    default:
        throw new System.NotImplementedException();
}
        

#line default
#line hidden

#line 162 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 162 "ModelTemplate.cshtml"
                  
}

#line default
#line hidden

            WriteLiteral("\n");
#line 165 "ModelTemplate.cshtml"
 foreach (var property in Model.ClassProperties)
{

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 168 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 170 "ModelTemplate.cshtml"
foreach (var conv in property.JsonConverters)
{

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonConverter(typeof(");
#line 172 "ModelTemplate.cshtml"
                                           Write(conv);

#line default
#line hidden
            WriteLiteral("))]\n");
#line 173 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonProperty(PropertyName = \"");
#line 174 "ModelTemplate.cshtml"
                                                   Write(property.SerializedName);

#line default
#line hidden
            WriteLiteral("\")]\n        ");
#line 175 "ModelTemplate.cshtml"
      Write(property.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n        public static ");
#line 176 "ModelTemplate.cshtml"
                   Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 176 "ModelTemplate.cshtml"
                                           Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get; private set; }\n");
#line 177 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 177 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 177 "ModelTemplate.cshtml"
                  
}

#line default
#line hidden

#line 179 "ModelTemplate.cshtml"
 if(@Model.ShouldValidateChain())
{

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        /// Validate the object.\n        /// </summary>\n        /// <exception cref=\"Microsoft.Rest.ValidationException\">\n        /// Thrown if validation fails\n        /// </exception>\n        public ");
#line 187 "ModelTemplate.cshtml"
            Write(Model.MethodQualifier);

#line default
#line hidden
            WriteLiteral(" void Validate()\n        {\n");
#line 189 "ModelTemplate.cshtml"
bool anythingToValidate = false;

if (Model.BaseModelType != null && Model.BaseModelType.ShouldValidateChain())
{
    anythingToValidate = true;

#line default
#line hidden

            WriteLiteral("            base.Validate();\n");
#line 195 "ModelTemplate.cshtml"
}

foreach (PropertyCs property in Model.InstanceProperties.Where(p => p.IsRequired && !p.IsReadOnly && p.IsNullable() ))
{
    anythingToValidate = true;

#line default
#line hidden

            WriteLiteral("            if (this.");
#line 200 "ModelTemplate.cshtml"
                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" == null)\n            {\n                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, \"");
#line 202 "ModelTemplate.cshtml"
                                                                                                        Write(property.Name);

#line default
#line hidden
            WriteLiteral("\");\n            }\n");
#line 204 "ModelTemplate.cshtml"
}
foreach (var property in Model.InstanceProperties.Where(p => p.Constraints.Any() || !(p.ModelType is PrimaryType)))
{
    anythingToValidate = true;

#line default
#line hidden

            WriteLiteral("            ");
#line 208 "ModelTemplate.cshtml"
         Write(property.ModelType.ValidateType(Model, $"this.{property.Name}", property.IsNullable(), property.Constraints));

#line default
#line hidden
            WriteLiteral("\n");
#line 209 "ModelTemplate.cshtml"
}
if (!anythingToValidate)
{

#line default
#line hidden

            WriteLiteral("            //Nothing to validate\n");
#line 213 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        }\n");
#line 215 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 217 "ModelTemplate.cshtml"
    

#line default
#line hidden

#line 217 "ModelTemplate.cshtml"
     if (Model.CodeModel.ShouldGenerateXmlSerialization) {

#line default
#line hidden

            WriteLiteral("\n        /// <summary>\n        /// Serializes the object to an XML node\n        /// </summary>\n        internal System.Xml.Linq.XElement XmlSerialize(System.Xml.Linq.XElement result)\n        {");
#line 222 "ModelTemplate.cshtml"
                
        foreach(var property in Model.InstanceProperties.Where(p => !p.WasFlattened())) {

#line default
#line hidden

            WriteLiteral("\n");
#line 224 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 224 "ModelTemplate.cshtml"
         if (property.IsNullable()) {

#line default
#line hidden

            WriteLiteral("\n            if( null != ");
#line 225 "ModelTemplate.cshtml"
                    Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ) \n            {");
#line 226 "ModelTemplate.cshtml"
                    }

#line default
#line hidden

            WriteLiteral("                ");
#line 227 "ModelTemplate.cshtml"
                 if (property.ModelType is CompositeType) {

#line default
#line hidden

            WriteLiteral("\n                result.Add(");
#line 228 "ModelTemplate.cshtml"
                       Write(property.Name);

#line default
#line hidden
            WriteLiteral(".XmlSerialize(new System.Xml.Linq.XElement( \"");
#line 228 "ModelTemplate.cshtml"
                                                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\" )));");
#line 228 "ModelTemplate.cshtml"
                                                                                                                        
                }
                else if (property.ModelType is DictionaryType)
                {
                    var vt = ((DictionaryType)property.ModelType).ValueType;
                    if (vt is DictionaryType || vt is SequenceType)
                    {
                        // todo: nothing right now.
                    } else if (vt is CompositeType) {

#line default
#line hidden

            WriteLiteral("\n                var dict = new System.Xml.Linq.XElement(\"");
#line 237 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\");\n                foreach( var key in ");
#line 238 "ModelTemplate.cshtml"
                                Write(property.Name);

#line default
#line hidden
            WriteLiteral(".Keys ) {\n                    dict.Add(");
#line 239 "ModelTemplate.cshtml"
                         Write(property.Name);

#line default
#line hidden
            WriteLiteral("[key].XmlSerialize(new System.Xml.Linq.XElement(key) ) );\n                }\n                result.Add(dict);");
#line 241 "ModelTemplate.cshtml"
                                        
                } else {

#line default
#line hidden

            WriteLiteral("\n                var dict = new System.Xml.Linq.XElement(\"");
#line 243 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\");\n                foreach( var key in ");
#line 244 "ModelTemplate.cshtml"
                                Write(property.Name);

#line default
#line hidden
            WriteLiteral(".Keys ){\n                    dict.Add(new System.Xml.Linq.XElement( key, ");
#line 245 "ModelTemplate.cshtml"
                                                            Write(property.Name);

#line default
#line hidden
            WriteLiteral("[key] ) );\n                }\n                result.Add(dict);");
#line 247 "ModelTemplate.cshtml"
                                        }
                }
                else if (property.ModelType is SequenceType)
                {
                    var et = ((SequenceType)property.ModelType).ElementType;
                    if (et is DictionaryType || et is SequenceType)
                    {
                        // todo: nothing right now.
                    } else if (et is CompositeType) {if ((property.ModelType as SequenceType).XmlIsWrapped) {

#line default
#line hidden

            WriteLiteral("\n                var seq = new System.Xml.Linq.XElement(\"");
#line 256 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\");\n                foreach( var value in ");
#line 257 "ModelTemplate.cshtml"
                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ){\n                    seq.Add(value.XmlSerialize( new System.Xml.Linq.XElement( \"");
#line 258 "ModelTemplate.cshtml"
                                                                           Write((property.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\") ) );\n                }\n                result.Add(seq);");
#line 260 "ModelTemplate.cshtml"
                                       } 
                else {

#line default
#line hidden

            WriteLiteral("\n                foreach( var value in ");
#line 262 "ModelTemplate.cshtml"
                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ){\n                    result.Add(value.XmlSerialize( new System.Xml.Linq.XElement( \"");
#line 263 "ModelTemplate.cshtml"
                                                                             Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\") ) );\n                }");
#line 264 "ModelTemplate.cshtml"
                        }} else {if ((property.ModelType as SequenceType).XmlIsWrapped) {

#line default
#line hidden

            WriteLiteral("\n                var seq = new System.Xml.Linq.XElement(\"");
#line 265 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\");\n                foreach( var value in ");
#line 266 "ModelTemplate.cshtml"
                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ){\n                    seq.Add(new System.Xml.Linq.XElement( \"");
#line 267 "ModelTemplate.cshtml"
                                                       Write((property.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\", value ) );\n                }\n                result.Add(seq);");
#line 269 "ModelTemplate.cshtml"
                                       } 
                else {

#line default
#line hidden

            WriteLiteral("\n                foreach( var value in ");
#line 271 "ModelTemplate.cshtml"
                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ){\n                    result.Add(new System.Xml.Linq.XElement( \"");
#line 272 "ModelTemplate.cshtml"
                                                         Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", value ) );\n                }");
#line 273 "ModelTemplate.cshtml"
                        }}
                } else if (property.ModelType is EnumType && !((EnumType)property.ModelType).ModelAsString) {
                    // serialize it as a enum type.
                    if (property.XmlIsAttribute) {

#line default
#line hidden

            WriteLiteral("\n                result.Add(new System.Xml.Linq.XAttribute(\"");
#line 277 "ModelTemplate.cshtml"
                                                      Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 277 "ModelTemplate.cshtml"
                                                                           Write(property.Name);

#line default
#line hidden
            WriteLiteral(".ToSerializedValue()) );");
#line 277 "ModelTemplate.cshtml"
                                                                                                                              
                    } else {

#line default
#line hidden

            WriteLiteral("\n                result.Add(new System.Xml.Linq.XElement(\"");
#line 279 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 279 "ModelTemplate.cshtml"
                                                                         Write(property.Name);

#line default
#line hidden
            WriteLiteral(".ToSerializedValue()) );");
#line 279 "ModelTemplate.cshtml"
                                                                                                                            
                    }
                } else {
                    // serialize it as a primitive/value type.
                    var primitiveExpression = property.Name;
                    var knownType = (property.ModelType as PrimaryType)?.KnownPrimaryType;
                    if (knownType == KnownPrimaryType.DateTimeRfc1123)
                    {
                        primitiveExpression = property.IsNullable()
                            ? $"{primitiveExpression}?.ToUniversalTime().ToString(\"R\")"
                            : $"{primitiveExpression}.ToUniversalTime().ToString(\"R\")";
                    }
                    if (property.XmlIsAttribute) {

#line default
#line hidden

            WriteLiteral("\n                result.Add(new System.Xml.Linq.XAttribute(\"");
#line 292 "ModelTemplate.cshtml"
                                                      Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 292 "ModelTemplate.cshtml"
                                                                           Write(primitiveExpression);

#line default
#line hidden
            WriteLiteral(") );");
#line 292 "ModelTemplate.cshtml"
                                                                                                                
                    } else {

#line default
#line hidden

            WriteLiteral("\n                result.Add(new System.Xml.Linq.XElement(\"");
#line 294 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 294 "ModelTemplate.cshtml"
                                                                         Write(primitiveExpression);

#line default
#line hidden
            WriteLiteral(") );");
#line 294 "ModelTemplate.cshtml"
                                                                                                              
                    }
                }

#line default
#line hidden

            WriteLiteral("        ");
#line 297 "ModelTemplate.cshtml"
         if (property.IsNullable()) {

#line default
#line hidden

            WriteLiteral("\n            }\n        ");
#line 299 "ModelTemplate.cshtml"
               }

#line default
#line hidden

            WriteLiteral("    ");
#line 300 "ModelTemplate.cshtml"
           }

#line default
#line hidden

            WriteLiteral("\n            return result;\n        }\n\n        /// <summary>\n        /// Deserializes an XML node to an instance of ");
#line 306 "ModelTemplate.cshtml"
                                                  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        internal static ");
#line 308 "ModelTemplate.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" XmlDeserialize(string payload) \n        {\n            // deserialize to xml and use the overload to do the work\n            return XmlDeserialize( System.Xml.Linq.XElement.Parse( payload ) );\n        }    \n\n        internal static ");
#line 314 "ModelTemplate.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" XmlDeserialize(System.Xml.Linq.XElement payload) \n        {\n            var result = new ");
#line 316 "ModelTemplate.cshtml"
                         Write(Model.Name);

#line default
#line hidden
            WriteLiteral("();\n");
#line 317 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 317 "ModelTemplate.cshtml"
         if (Model.InstanceProperties.Any(p => !p.WasFlattened() && p.XmlIsAttribute)) {

#line default
#line hidden

            WriteLiteral("\n            System.Xml.Linq.XAttribute attribute;");
#line 318 "ModelTemplate.cshtml"
                                                        
        }
        

#line default
#line hidden

#line 322 "ModelTemplate.cshtml"
           

#line default
#line hidden

            WriteLiteral("\n");
#line 324 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 324 "ModelTemplate.cshtml"
         foreach(var property in Model.InstanceProperties.Where(p => !p.WasFlattened())) {
            

#line default
#line hidden

#line 325 "ModelTemplate.cshtml"
             if (property.XmlIsAttribute) {

#line default
#line hidden

            WriteLiteral("\n            if( null != (attribute = payload.Attribute(\"");
#line 326 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\")))\n            {\n");
#line 328 "ModelTemplate.cshtml"
                

#line default
#line hidden

#line 328 "ModelTemplate.cshtml"
                 if (property.ModelType is EnumType && !((EnumType)property.ModelType).ModelAsString) {

#line default
#line hidden

            WriteLiteral("\n                \n                result.");
#line 330 "ModelTemplate.cshtml"
                   Write(property.Name);

#line default
#line hidden
            WriteLiteral(" =attribute.Value.Parse");
#line 330 "ModelTemplate.cshtml"
                                                          Write(property.ModelType.Name);

#line default
#line hidden
            WriteLiteral("();\n                \n                ");
#line 332 "ModelTemplate.cshtml"
                       } else {

#line default
#line hidden

            WriteLiteral(" \n                result.");
#line 333 "ModelTemplate.cshtml"
                   Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = (");
#line 333 "ModelTemplate.cshtml"
                                      Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(")attribute;\n                ");
#line 334 "ModelTemplate.cshtml"
                       }

#line default
#line hidden

            WriteLiteral("            }\n            ");
#line 336 "ModelTemplate.cshtml"
                   
                continue;
            }

#line default
#line hidden

#line 338 "ModelTemplate.cshtml"
             
            
            var deserializerName = $"deserialize{property.Name}";
            var resultName = $"result{property.Name}";


#line default
#line hidden

            WriteLiteral("\n            var ");
#line 344 "ModelTemplate.cshtml"
            Write(deserializerName);

#line default
#line hidden
            WriteLiteral(" = ");
#line 344 "ModelTemplate.cshtml"
                                  Write(XmlSerialization.GenerateDeserializer(Model.CodeModel, property.ModelType, property.ModelTypeName));

#line default
#line hidden
            WriteLiteral(";\n            ");
#line 345 "ModelTemplate.cshtml"
       Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 345 "ModelTemplate.cshtml"
                                Write(resultName);

#line default
#line hidden
            WriteLiteral(";\n            if (");
#line 346 "ModelTemplate.cshtml"
            Write(deserializerName);

#line default
#line hidden
            WriteLiteral("(payload, \"");
#line 346 "ModelTemplate.cshtml"
                                         Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", out ");
#line 346 "ModelTemplate.cshtml"
                                                                  Write(resultName);

#line default
#line hidden
            WriteLiteral("))\n            {\n                result.");
#line 348 "ModelTemplate.cshtml"
                   Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 348 "ModelTemplate.cshtml"
                                      Write(resultName);

#line default
#line hidden
            WriteLiteral(";\n            }\n");
#line 350 "ModelTemplate.cshtml"
       
        }

#line default
#line hidden

            WriteLiteral("            return result;\n        } \n    ");
#line 354 "ModelTemplate.cshtml"
           }

#line default
#line hidden

            WriteLiteral("    \n    }\n}");
        }
        #pragma warning restore 1998
    }
}
