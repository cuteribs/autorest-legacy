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
            WriteLiteral("\nusing System.Linq;\n");
#line 12 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 13 "ModelTemplate.cshtml"
      Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral(".");
#line 13 "ModelTemplate.cshtml"
                            Write(Settings.ModelsName);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 15 "ModelTemplate.cshtml"
 if (!string.IsNullOrEmpty(Model.EffectiveDocumentation))
{

#line default
#line hidden

            WriteLiteral("    /// <summary>\n    ");
#line 18 "ModelTemplate.cshtml"
 Write(WrapComment("/// ", Model.EffectiveDocumentation));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n");
#line 20 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 21 "ModelTemplate.cshtml"
 if (!string.IsNullOrEmpty(Model.Summary) && !string.IsNullOrWhiteSpace(Model.Documentation))
{

#line default
#line hidden

            WriteLiteral("    /// <remarks>\n    ");
#line 24 "ModelTemplate.cshtml"
 Write(WrapComment("/// ", Model.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n    /// </remarks>\n");
#line 26 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 27 "ModelTemplate.cshtml"
 if (Model.NeedsPolymorphicConverter)
{

#line default
#line hidden

            WriteLiteral("    [Newtonsoft.Json.JsonObject(\"");
#line 29 "ModelTemplate.cshtml"
                              Write(Model.SerializedName);

#line default
#line hidden
            WriteLiteral("\")]\n");
#line 30 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 31 "ModelTemplate.cshtml"
 if (Model.NeedsTransformationConverter)
{

#line default
#line hidden

            WriteLiteral("    [Microsoft.Rest.Serialization.JsonTransformation]\n");
#line 34 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    ");
#line 35 "ModelTemplate.cshtml"
Write(Model.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n    public partial class ");
#line 36 "ModelTemplate.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#line 36 "ModelTemplate.cshtml"
                                Write(Model.BaseModelType != null ? " : " + Model.BaseModelType.Name : "");

#line default
#line hidden
            WriteLiteral("\n    {\n        /// <summary>\n        ");
#line 39 "ModelTemplate.cshtml"
   Write(WrapComment("/// ", ("Initializes a new instance of the " + Model.Name + " class.").EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public ");
#line 41 "ModelTemplate.cshtml"
           Write(Model.Name);

#line default
#line hidden
            WriteLiteral("()\n        {\n");
#line 43 "ModelTemplate.cshtml"
 foreach(var property in Model.ComposedProperties.Where(p => p.ModelType is CompositeType ct
    && !p.IsConstant
    && p.IsRequired
    && ct.ContainsConstantProperties))
{

#line default
#line hidden

            WriteLiteral("            this.");
#line 48 "ModelTemplate.cshtml"
               Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = new ");
#line 48 "ModelTemplate.cshtml"
                                      Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral("();\n");
#line 49 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            CustomInit();\n        }\n\n        ");
#line 53 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 55 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 55 "ModelTemplate.cshtml"
         if (!string.IsNullOrEmpty(Model.ConstructorParameters))
        {

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 58 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", ("Initializes a new instance of the " + Model.Name + " class.").EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 60 "ModelTemplate.cshtml"
foreach (var parameter in Model.ConstructorParametersDocumentation)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 62 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", parameter));

#line default
#line hidden
            WriteLiteral("\n");
#line 63 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        public ");
#line 64 "ModelTemplate.cshtml"
             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 64 "ModelTemplate.cshtml"
                          Write(Model.ConstructorParameters);

#line default
#line hidden
            WriteLiteral(")\n");
#line 65 "ModelTemplate.cshtml"
if (!string.IsNullOrEmpty(Model.BaseConstructorCall))
{

#line default
#line hidden

            WriteLiteral("            ");
#line 67 "ModelTemplate.cshtml"
          Write(Model.BaseConstructorCall);

#line default
#line hidden
            WriteLiteral("\n");
#line 68 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        {\n");
#line 70 "ModelTemplate.cshtml"

foreach (var property in Model.InstanceProperties)
{

#line default
#line hidden

            WriteLiteral("            this.");
#line 73 "ModelTemplate.cshtml"
               Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 73 "ModelTemplate.cshtml"
                                  Write(CodeNamer.Instance.CamelCase(property.Name));

#line default
#line hidden
            WriteLiteral(";\n");
#line 74 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            CustomInit();\n        }\n");
#line 77 "ModelTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("\n");
#line 79 "ModelTemplate.cshtml"
 if (Model.ClassProperties.Any())
{

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 82 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", ("Static constructor for " + Model.Name + " class.").EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        static ");
#line 84 "ModelTemplate.cshtml"
             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("()\n        {\n");
#line 86 "ModelTemplate.cshtml"
foreach (var property in Model.ClassProperties)
{

#line default
#line hidden

            WriteLiteral("            ");
#line 88 "ModelTemplate.cshtml"
          Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 88 "ModelTemplate.cshtml"
                             Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral(";\n");
#line 89 "ModelTemplate.cshtml"
}


#line default
#line hidden

            WriteLiteral("        }\n");
#line 92 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 93 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        /// An initialization method that performs custom operations like setting defaults\n        /// </summary>\n        partial void CustomInit();\n        \n        ");
#line 99 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 100 "ModelTemplate.cshtml"
 foreach (PropertyCs property in Model.InstanceProperties)
{

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 103 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.GetFormattedPropertySummary()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 105 "ModelTemplate.cshtml"
            if(!string.IsNullOrEmpty(property.Summary) && !string.IsNullOrEmpty(property.Documentation))
            { 

#line default
#line hidden

            WriteLiteral("        /// <remarks>\n        ");
#line 108 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.Documentation));

#line default
#line hidden
            WriteLiteral("\n        /// </remarks>\n");
#line 110 "ModelTemplate.cshtml"
            }
foreach (var conv in property.JsonConverters)
{

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonConverter(typeof(");
#line 113 "ModelTemplate.cshtml"
                                           Write(conv);

#line default
#line hidden
            WriteLiteral("))]\n");
#line 114 "ModelTemplate.cshtml"
}
switch (property.Flavor)
{
    case PropertyFlavor.AdditionalProperties:

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonExtensionData]\n");
#line 119 "ModelTemplate.cshtml"
        break;
    case PropertyFlavor.ForwardTo:
    case PropertyFlavor.Implementation:

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonIgnore]\n");
#line 123 "ModelTemplate.cshtml"
        break;
    case PropertyFlavor.Regular:

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonProperty(PropertyName = \"");
#line 125 "ModelTemplate.cshtml"
                                                   Write(property.SerializedName);

#line default
#line hidden
            WriteLiteral("\")]\n");
#line 126 "ModelTemplate.cshtml"
        break;
    default:
        throw new System.NotImplementedException();
}

#line default
#line hidden

            WriteLiteral("        ");
#line 130 "ModelTemplate.cshtml"
      Write(property.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n");
#line 131 "ModelTemplate.cshtml"
switch (property.Flavor)
{
    case PropertyFlavor.ForwardTo:

#line default
#line hidden

            WriteLiteral("        public ");
#line 134 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 134 "ModelTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral("\n        { \n            get { return this.");
#line 136 "ModelTemplate.cshtml"
                            Write(property.ForwardTo.Name);

#line default
#line hidden
            WriteLiteral("; }\n            set { this.");
#line 137 "ModelTemplate.cshtml"
                     Write(property.ForwardTo.Name);

#line default
#line hidden
            WriteLiteral(" = value; }\n        }\n");
#line 139 "ModelTemplate.cshtml"
        break;
    case PropertyFlavor.Implementation:
        var impl = property.GetImplementation("csharp");
        if (impl == null)
        {

#line default
#line hidden

            WriteLiteral("        public ");
#line 144 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 144 "ModelTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get; ");
#line 144 "ModelTemplate.cshtml"
                                                           Write(property.IsReadOnly ? "private " : "");

#line default
#line hidden
            WriteLiteral("set; }\n");
#line 145 "ModelTemplate.cshtml"
        }
        else
        {

#line default
#line hidden

            WriteLiteral("        public ");
#line 148 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 148 "ModelTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral("\n        { \n        ");
#line 150 "ModelTemplate.cshtml"
     Write(impl);

#line default
#line hidden
            WriteLiteral("\n        }\n");
#line 152 "ModelTemplate.cshtml"
        }
        break;
    case PropertyFlavor.AdditionalProperties:
    case PropertyFlavor.Regular:

#line default
#line hidden

            WriteLiteral("        public ");
#line 156 "ModelTemplate.cshtml"
            Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 156 "ModelTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get; ");
#line 156 "ModelTemplate.cshtml"
                                                           Write(property.IsReadOnly ? "private " : "");

#line default
#line hidden
            WriteLiteral("set; }\n");
#line 157 "ModelTemplate.cshtml"
        break;
    default:
        throw new System.NotImplementedException();
}
        

#line default
#line hidden

#line 161 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 161 "ModelTemplate.cshtml"
                  
}

#line default
#line hidden

            WriteLiteral("\n");
#line 164 "ModelTemplate.cshtml"
 foreach (var property in Model.ClassProperties)
{

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 167 "ModelTemplate.cshtml"
     Write(WrapComment("/// ", property.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 169 "ModelTemplate.cshtml"
foreach (var conv in property.JsonConverters)
{

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonConverter(typeof(");
#line 171 "ModelTemplate.cshtml"
                                           Write(conv);

#line default
#line hidden
            WriteLiteral("))]\n");
#line 172 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        [Newtonsoft.Json.JsonProperty(PropertyName = \"");
#line 173 "ModelTemplate.cshtml"
                                                   Write(property.SerializedName);

#line default
#line hidden
            WriteLiteral("\")]\n        ");
#line 174 "ModelTemplate.cshtml"
      Write(property.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n        public static ");
#line 175 "ModelTemplate.cshtml"
                   Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 175 "ModelTemplate.cshtml"
                                           Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get; private set; }\n");
#line 176 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 176 "ModelTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 176 "ModelTemplate.cshtml"
                  
}

#line default
#line hidden

#line 178 "ModelTemplate.cshtml"
 if(@Model.ShouldValidateChain())
{

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        /// Validate the object.\n        /// </summary>\n        /// <exception cref=\"Microsoft.Rest.ValidationException\">\n        /// Thrown if validation fails\n        /// </exception>\n        public ");
#line 186 "ModelTemplate.cshtml"
            Write(Model.MethodQualifier);

#line default
#line hidden
            WriteLiteral(" void Validate()\n        {\n");
#line 188 "ModelTemplate.cshtml"
bool anythingToValidate = false;

if (Model.BaseModelType != null && Model.BaseModelType.ShouldValidateChain())
{
    anythingToValidate = true;

#line default
#line hidden

            WriteLiteral("            base.Validate();\n");
#line 194 "ModelTemplate.cshtml"
}

foreach (PropertyCs property in Model.InstanceProperties.Where(p => p.IsRequired && !p.IsReadOnly && p.IsNullable() ))
{
    anythingToValidate = true;

#line default
#line hidden

            WriteLiteral("            if (this.");
#line 199 "ModelTemplate.cshtml"
                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" == null)\n            {\n                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, \"");
#line 201 "ModelTemplate.cshtml"
                                                                                                        Write(property.Name);

#line default
#line hidden
            WriteLiteral("\");\n            }\n");
#line 203 "ModelTemplate.cshtml"
}
foreach (var property in Model.InstanceProperties.Where(p => p.Constraints.Any() || !(p.ModelType is PrimaryType)))
{
    anythingToValidate = true;

#line default
#line hidden

            WriteLiteral("            ");
#line 207 "ModelTemplate.cshtml"
         Write(property.ModelType.ValidateType(Model, $"this.{property.Name}", property.IsNullable(), property.Constraints));

#line default
#line hidden
            WriteLiteral("\n");
#line 208 "ModelTemplate.cshtml"
}
if (!anythingToValidate)
{

#line default
#line hidden

            WriteLiteral("            //Nothing to validate\n");
#line 212 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        }\n");
#line 214 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 216 "ModelTemplate.cshtml"
    

#line default
#line hidden

#line 216 "ModelTemplate.cshtml"
     if (Model.CodeModel.ShouldGenerateXmlSerialization) {

#line default
#line hidden

            WriteLiteral("\n        /// <summary>\n        /// Serializes the object to an XML node\n        /// </summary>\n        internal System.Xml.Linq.XElement XmlSerialize(System.Xml.Linq.XElement result)\n        {");
#line 221 "ModelTemplate.cshtml"
                
        foreach(var property in Model.InstanceProperties.Where(p => !p.WasFlattened())) {

#line default
#line hidden

            WriteLiteral("\n");
#line 223 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 223 "ModelTemplate.cshtml"
         if (property.IsNullable()) {

#line default
#line hidden

            WriteLiteral("\n            if( null != ");
#line 224 "ModelTemplate.cshtml"
                    Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ) \n            {");
#line 225 "ModelTemplate.cshtml"
                    }

#line default
#line hidden

            WriteLiteral("                ");
#line 226 "ModelTemplate.cshtml"
                 if (property.ModelType is CompositeType) {

#line default
#line hidden

            WriteLiteral("\n                result.Add(");
#line 227 "ModelTemplate.cshtml"
                       Write(property.Name);

#line default
#line hidden
            WriteLiteral(".XmlSerialize(new System.Xml.Linq.XElement( \"");
#line 227 "ModelTemplate.cshtml"
                                                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\" )));");
#line 227 "ModelTemplate.cshtml"
                                                                                                                        
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
#line 236 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\");\n                foreach( var key in ");
#line 237 "ModelTemplate.cshtml"
                                Write(property.Name);

#line default
#line hidden
            WriteLiteral(".Keys ) {\n                    dict.Add(");
#line 238 "ModelTemplate.cshtml"
                         Write(property.Name);

#line default
#line hidden
            WriteLiteral("[key].XmlSerialize(new System.Xml.Linq.XElement(key) ) );\n                }\n                result.Add(dict);");
#line 240 "ModelTemplate.cshtml"
                                        
                } else {

#line default
#line hidden

            WriteLiteral("\n                var dict = new System.Xml.Linq.XElement(\"");
#line 242 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\");\n                foreach( var key in ");
#line 243 "ModelTemplate.cshtml"
                                Write(property.Name);

#line default
#line hidden
            WriteLiteral(".Keys ){\n                    dict.Add(new System.Xml.Linq.XElement( key, ");
#line 244 "ModelTemplate.cshtml"
                                                            Write(property.Name);

#line default
#line hidden
            WriteLiteral("[key] ) );\n                }\n                result.Add(dict);");
#line 246 "ModelTemplate.cshtml"
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
#line 255 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\");\n                foreach( var value in ");
#line 256 "ModelTemplate.cshtml"
                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ){\n                    seq.Add(value.XmlSerialize( new System.Xml.Linq.XElement( \"");
#line 257 "ModelTemplate.cshtml"
                                                                           Write((property.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\") ) );\n                }\n                result.Add(seq);");
#line 259 "ModelTemplate.cshtml"
                                       } 
                else {

#line default
#line hidden

            WriteLiteral("\n                foreach( var value in ");
#line 261 "ModelTemplate.cshtml"
                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ){\n                    result.Add(value.XmlSerialize( new System.Xml.Linq.XElement( \"");
#line 262 "ModelTemplate.cshtml"
                                                                             Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\") ) );\n                }");
#line 263 "ModelTemplate.cshtml"
                        }} else {if ((property.ModelType as SequenceType).XmlIsWrapped) {

#line default
#line hidden

            WriteLiteral("\n                var seq = new System.Xml.Linq.XElement(\"");
#line 264 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\");\n                foreach( var value in ");
#line 265 "ModelTemplate.cshtml"
                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ){\n                    seq.Add(new System.Xml.Linq.XElement( \"");
#line 266 "ModelTemplate.cshtml"
                                                       Write((property.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\", value ) );\n                }\n                result.Add(seq);");
#line 268 "ModelTemplate.cshtml"
                                       } 
                else {

#line default
#line hidden

            WriteLiteral("\n                foreach( var value in ");
#line 270 "ModelTemplate.cshtml"
                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" ){\n                    result.Add(new System.Xml.Linq.XElement( \"");
#line 271 "ModelTemplate.cshtml"
                                                         Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", value ) );\n                }");
#line 272 "ModelTemplate.cshtml"
                        }}
                } else if (property.ModelType is EnumType && !((EnumType)property.ModelType).ModelAsString) {
                    // serialize it as a enum type.
                    if (property.XmlIsAttribute) {

#line default
#line hidden

            WriteLiteral("\n                result.Add(new System.Xml.Linq.XAttribute(\"");
#line 276 "ModelTemplate.cshtml"
                                                      Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 276 "ModelTemplate.cshtml"
                                                                           Write(property.Name);

#line default
#line hidden
            WriteLiteral(".ToSerializedValue()) );");
#line 276 "ModelTemplate.cshtml"
                                                                                                                              
                    } else {

#line default
#line hidden

            WriteLiteral("\n                result.Add(new System.Xml.Linq.XElement(\"");
#line 278 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 278 "ModelTemplate.cshtml"
                                                                         Write(property.Name);

#line default
#line hidden
            WriteLiteral(".ToSerializedValue()) );");
#line 278 "ModelTemplate.cshtml"
                                                                                                                            
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
#line 291 "ModelTemplate.cshtml"
                                                      Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 291 "ModelTemplate.cshtml"
                                                                           Write(primitiveExpression);

#line default
#line hidden
            WriteLiteral(") );");
#line 291 "ModelTemplate.cshtml"
                                                                                                                
                    } else {

#line default
#line hidden

            WriteLiteral("\n                result.Add(new System.Xml.Linq.XElement(\"");
#line 293 "ModelTemplate.cshtml"
                                                    Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 293 "ModelTemplate.cshtml"
                                                                         Write(primitiveExpression);

#line default
#line hidden
            WriteLiteral(") );");
#line 293 "ModelTemplate.cshtml"
                                                                                                              
                    }
                }

#line default
#line hidden

            WriteLiteral("        ");
#line 296 "ModelTemplate.cshtml"
         if (property.IsNullable()) {

#line default
#line hidden

            WriteLiteral("\n            }\n        ");
#line 298 "ModelTemplate.cshtml"
               }

#line default
#line hidden

            WriteLiteral("    ");
#line 299 "ModelTemplate.cshtml"
           }

#line default
#line hidden

            WriteLiteral("\n            return result;\n        }\n\n        /// <summary>\n        /// Deserializes an XML node to an instance of ");
#line 305 "ModelTemplate.cshtml"
                                                  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        internal static ");
#line 307 "ModelTemplate.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" XmlDeserialize(string payload) \n        {\n            // deserialize to xml and use the overload to do the work\n            return XmlDeserialize( System.Xml.Linq.XElement.Parse( payload ) );\n        }    \n\n        internal static ");
#line 313 "ModelTemplate.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" XmlDeserialize(System.Xml.Linq.XElement payload) \n        {\n            var result = new ");
#line 315 "ModelTemplate.cshtml"
                         Write(Model.Name);

#line default
#line hidden
            WriteLiteral("();\n");
#line 316 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 316 "ModelTemplate.cshtml"
         if (Model.InstanceProperties.Any(p => !p.WasFlattened() && p.XmlIsAttribute)) {

#line default
#line hidden

            WriteLiteral("\n            System.Xml.Linq.XAttribute attribute;");
#line 317 "ModelTemplate.cshtml"
                                                        
        }
        

#line default
#line hidden

#line 321 "ModelTemplate.cshtml"
           

#line default
#line hidden

            WriteLiteral("\n");
#line 323 "ModelTemplate.cshtml"
        

#line default
#line hidden

#line 323 "ModelTemplate.cshtml"
         foreach(var property in Model.InstanceProperties.Where(p => !p.WasFlattened())) {
            

#line default
#line hidden

#line 324 "ModelTemplate.cshtml"
             if (property.XmlIsAttribute) {

#line default
#line hidden

            WriteLiteral("\n            if( null != (attribute = payload.Attribute(\"");
#line 325 "ModelTemplate.cshtml"
                                                   Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\")))\n            {\n");
#line 327 "ModelTemplate.cshtml"
                

#line default
#line hidden

#line 327 "ModelTemplate.cshtml"
                 if (property.ModelType is EnumType && !((EnumType)property.ModelType).ModelAsString) {

#line default
#line hidden

            WriteLiteral("\n                \n                result.");
#line 329 "ModelTemplate.cshtml"
                   Write(property.Name);

#line default
#line hidden
            WriteLiteral(" =attribute.Value.Parse");
#line 329 "ModelTemplate.cshtml"
                                                          Write(property.ModelType.Name);

#line default
#line hidden
            WriteLiteral("();\n                \n                ");
#line 331 "ModelTemplate.cshtml"
                       } else {

#line default
#line hidden

            WriteLiteral(" \n                result.");
#line 332 "ModelTemplate.cshtml"
                   Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = (");
#line 332 "ModelTemplate.cshtml"
                                      Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(")attribute;\n                ");
#line 333 "ModelTemplate.cshtml"
                       }

#line default
#line hidden

            WriteLiteral("            }\n            ");
#line 335 "ModelTemplate.cshtml"
                   
                continue;
            }

#line default
#line hidden

#line 337 "ModelTemplate.cshtml"
             
            
            var deserializerName = $"deserialize{property.Name}";
            var resultName = $"result{property.Name}";


#line default
#line hidden

            WriteLiteral("\n            var ");
#line 343 "ModelTemplate.cshtml"
            Write(deserializerName);

#line default
#line hidden
            WriteLiteral(" = ");
#line 343 "ModelTemplate.cshtml"
                                  Write(XmlSerialization.GenerateDeserializer(Model.CodeModel, property.ModelType, property.ModelTypeName));

#line default
#line hidden
            WriteLiteral(";\n            ");
#line 344 "ModelTemplate.cshtml"
       Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 344 "ModelTemplate.cshtml"
                                Write(resultName);

#line default
#line hidden
            WriteLiteral(";\n            if (");
#line 345 "ModelTemplate.cshtml"
            Write(deserializerName);

#line default
#line hidden
            WriteLiteral("(payload, \"");
#line 345 "ModelTemplate.cshtml"
                                         Write(property.XmlName);

#line default
#line hidden
            WriteLiteral("\", out ");
#line 345 "ModelTemplate.cshtml"
                                                                  Write(resultName);

#line default
#line hidden
            WriteLiteral("))\n            {\n                result.");
#line 347 "ModelTemplate.cshtml"
                   Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 347 "ModelTemplate.cshtml"
                                      Write(resultName);

#line default
#line hidden
            WriteLiteral(";\n            }\n");
#line 349 "ModelTemplate.cshtml"
       
        }

#line default
#line hidden

            WriteLiteral("            return result;\n        } \n    ");
#line 353 "ModelTemplate.cshtml"
           }

#line default
#line hidden

            WriteLiteral("    \n    }\n}");
        }
        #pragma warning restore 1998
    }
}
