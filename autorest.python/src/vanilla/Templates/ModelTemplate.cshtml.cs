// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "ModelTemplate.cshtml"
using System;

#line default
#line hidden
#line 2 "ModelTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ModelTemplate.cshtml"
using System.Collections.Generic

#line default
#line hidden
    ;
#line 4 "ModelTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 5 "ModelTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 6 "ModelTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ModelTemplate : AutoRest.Python.PythonTemplate<System.Collections.Generic.List<AutoRest.Python.Model.CompositeTypePy>>
    {
        #line hidden
        public ModelTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 10 "ModelTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 12 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom msrest.serialization import Model\n");
#line 14 "ModelTemplate.cshtml"
 foreach(var currModel in Model) {

#line default
#line hidden

            WriteLiteral("\n");
#line 16 "ModelTemplate.cshtml"
 if (currModel.IsException)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError\n");
#line 19 "ModelTemplate.cshtml"
break;
}

#line default
#line hidden

#line 21 "ModelTemplate.cshtml"
       
}

#line default
#line hidden

#line 23 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 24 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 25 "ModelTemplate.cshtml"
  bool first_model = true; 

#line default
#line hidden

#line 26 "ModelTemplate.cshtml"
 foreach(var currModel in Model){

#line default
#line hidden

            WriteLiteral("\n");
#line 28 "ModelTemplate.cshtml"
 if (!first_model) {

#line default
#line hidden

#line 29 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 29 "ModelTemplate.cshtml"
          

#line default
#line hidden

#line 30 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 30 "ModelTemplate.cshtml"
          
}

#line default
#line hidden

#line 32 "ModelTemplate.cshtml"
  first_model = false;

#line default
#line hidden

#line 33 "ModelTemplate.cshtml"
 if (currModel.BaseModelType != null)
{

#line default
#line hidden

            WriteLiteral("class ");
#line 35 "ModelTemplate.cshtml"
    Write(currModel.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 35 "ModelTemplate.cshtml"
                     Write(currModel.BaseModelType.Name);

#line default
#line hidden
            WriteLiteral("):\n");
#line 36 "ModelTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("class ");
#line 39 "ModelTemplate.cshtml"
    Write(currModel.Name);

#line default
#line hidden
            WriteLiteral("(Model):\n");
#line 40 "ModelTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"");
#line 41 "ModelTemplate.cshtml"
   Write(WrapComment(string.Empty, currModel.BuildSummaryAndDescriptionString()));

#line default
#line hidden
            WriteLiteral("\n");
#line 42 "ModelTemplate.cshtml"
 if (currModel.SubModelTypes.Any())
{

#line default
#line hidden

#line 44 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 44 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    ");
#line 45 "ModelTemplate.cshtml"
 Write(WrapComment(string.Empty, "You probably want to use the sub-classes and not this class directly. Known sub-classes are: " + currModel.SubModelTypeAsString));

#line default
#line hidden
            WriteLiteral("\n");
#line 46 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 47 "ModelTemplate.cshtml"
 if (currModel.ReadOnlyAttributes.Any())
{

#line default
#line hidden

#line 49 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 49 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    ");
#line 50 "ModelTemplate.cshtml"
 Write(WrapComment(string.Empty, "Variables are only populated by the server, and will be ignored when sending a request."));

#line default
#line hidden
            WriteLiteral("\n");
#line 51 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 52 "ModelTemplate.cshtml"
 if (currModel.RequiredFieldsList.Any())
{

#line default
#line hidden

#line 54 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 54 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    ");
#line 55 "ModelTemplate.cshtml"
 Write(WrapComment(string.Empty, "All required parameters must be populated in order to send to Azure."));

#line default
#line hidden
            WriteLiteral("\n");
#line 56 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 57 "ModelTemplate.cshtml"
 if (currModel.ComposedProperties.Any())
{

#line default
#line hidden

#line 59 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 59 "ModelTemplate.cshtml"
          
    foreach (var property in currModel.ComposedProperties)
    {

#line default
#line hidden

            WriteLiteral("    ");
#line 62 "ModelTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, CompositeTypePy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n");
#line 63 "ModelTemplate.cshtml"
        if (property.IsConstant || property.IsReadOnly)
        {

#line default
#line hidden

            WriteLiteral("    ");
#line 65 "ModelTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, ":vartype " + property.Name + ": " + currModel.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 66 "ModelTemplate.cshtml"
    }
        else
        {

#line default
#line hidden

            WriteLiteral("    ");
#line 69 "ModelTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + currModel.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 70 "ModelTemplate.cshtml"
        }
    }
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 74 "ModelTemplate.cshtml"
 if (currModel.Validators.Any() || currModel.RequiredFieldsList.Any())
{

#line default
#line hidden

            WriteLiteral("\n    ");
#line 77 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    _validation = {\n");
#line 79 "ModelTemplate.cshtml"
    

#line default
#line hidden

#line 79 "ModelTemplate.cshtml"
     foreach (var validator in currModel.Validators)
    {

#line default
#line hidden

            WriteLiteral("        ");
#line 81 "ModelTemplate.cshtml"
      Write(validator);

#line default
#line hidden
            WriteLiteral("\n");
#line 82 "ModelTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("    }\n");
#line 84 "ModelTemplate.cshtml"
       
}

#line default
#line hidden

#line 86 "ModelTemplate.cshtml"
  
    var mapAttrList = new List<Property>(currModel.ComposedProperties);

#line default
#line hidden

#line 88 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 88 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    _attribute_map = {\n");
#line 90 "ModelTemplate.cshtml"
    if (mapAttrList.Count > 0)
    {
      for (int i = 0; i < mapAttrList.Count; i++)
      {

#line default
#line hidden

            WriteLiteral("        ");
#line 94 "ModelTemplate.cshtml"
      Write(currModel.InitializeProperty(mapAttrList[i]));

#line default
#line hidden
            WriteLiteral("\n");
#line 95 "ModelTemplate.cshtml"
      }
    }

#line default
#line hidden

            WriteLiteral("    }\n");
#line 98 "ModelTemplate.cshtml"

#line default
#line hidden

#line 99 "ModelTemplate.cshtml"
 if(currModel.CodeModel.ShouldGenerateXmlSerialization)
{

#line default
#line hidden

            WriteLiteral("    _xml_map = {\n        ");
#line 102 "ModelTemplate.cshtml"
      Write(currModel.InitializeXmlProperty());

#line default
#line hidden
            WriteLiteral("\n    }\n");
#line 104 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 105 "ModelTemplate.cshtml"
 if (currModel.SubModelTypes.Any())
{

#line default
#line hidden

            WriteLiteral("\n");
#line 108 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    _subtype_map = {\n        \'");
#line 110 "ModelTemplate.cshtml"
    Write(currModel.PolymorphicDiscriminatorProperty.Name);

#line default
#line hidden
            WriteLiteral("\': {");
#line 110 "ModelTemplate.cshtml"
                                                        Write(currModel.SubModelTypeList);

#line default
#line hidden
            WriteLiteral("}\n    }\n");
#line 112 "ModelTemplate.cshtml"
       
}

#line default
#line hidden

#line 114 "ModelTemplate.cshtml"
 foreach(var property in currModel.Properties)
{
    if (property.IsConstant)
    {

#line default
#line hidden

#line 118 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 118 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    ");
#line 119 "ModelTemplate.cshtml"
  Write(currModel.InitializeProperty(String.Empty, property, false));

#line default
#line hidden
            WriteLiteral("\n");
#line 120 "ModelTemplate.cshtml"
    }
}

#line default
#line hidden

#line 122 "ModelTemplate.cshtml"
 if (currModel.NeedsConstructor)
{

#line default
#line hidden

#line 124 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 124 "ModelTemplate.cshtml"
          

#line default
#line hidden

#line 125 "ModelTemplate.cshtml"
 if (Python3Mode)
{

#line default
#line hidden

            WriteLiteral("    def __init__(self");
#line 127 "ModelTemplate.cshtml"
                   Write(currModel.ModelParameterDeclaration());

#line default
#line hidden
            WriteLiteral(") -> None:\n");
#line 128 "ModelTemplate.cshtml"
    if (currModel.HasParent)
    {

#line default
#line hidden

            WriteLiteral("        super(");
#line 130 "ModelTemplate.cshtml"
            Write(currModel.Name);

#line default
#line hidden
            WriteLiteral(", self).__init__(");
#line 130 "ModelTemplate.cshtml"
                                              Write(currModel.SuperParameterDeclaration());

#line default
#line hidden
            WriteLiteral(")\n");
#line 131 "ModelTemplate.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("        super(");
#line 134 "ModelTemplate.cshtml"
            Write(currModel.Name);

#line default
#line hidden
            WriteLiteral(", self).__init__(**kwargs)\n");
#line 135 "ModelTemplate.cshtml"
    }
}
else
{

#line default
#line hidden

            WriteLiteral("    def __init__(self, **kwargs):\n        super(");
#line 140 "ModelTemplate.cshtml"
            Write(currModel.Name);

#line default
#line hidden
            WriteLiteral(", self).__init__(**kwargs)\n");
#line 141 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 141 "ModelTemplate.cshtml"
 
    var propertyList = new List<Property>(currModel.Properties);
    if (propertyList.Count > 0)
    {
        for (int i = 0; i < propertyList.Count; i++)
        {
            if (!propertyList[i].IsConstant)
            {

#line default
#line hidden

            WriteLiteral("        ");
#line 149 "ModelTemplate.cshtml"
      Write(currModel.InitializeProperty("self", propertyList[i], !Python3Mode));

#line default
#line hidden
            WriteLiteral("\n");
#line 150 "ModelTemplate.cshtml"
            }
	    }
	}
    if (currModel.NeedsPolymorphicConverter)
    {

#line default
#line hidden

            WriteLiteral("        self.");
#line 155 "ModelTemplate.cshtml"
          Write(currModel.PolymorphicDiscriminatorProperty.Name);

#line default
#line hidden
            WriteLiteral(" = \'");
#line 155 "ModelTemplate.cshtml"
                                                              Write(currModel.SerializedName);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 156 "ModelTemplate.cshtml"
    }
}

#line default
#line hidden

#line 158 "ModelTemplate.cshtml"
 if (currModel.IsException)
{

#line default
#line hidden

#line 160 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 160 "ModelTemplate.cshtml"
          

#line default
#line hidden

#line 161 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 161 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("class ");
#line 162 "ModelTemplate.cshtml"
    Write(currModel.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral("(HttpResponseError):\n    \"\"\"Server responsed with exception of type: \'");
#line 163 "ModelTemplate.cshtml"
                                               Write(currModel.Name);

#line default
#line hidden
            WriteLiteral("\'.\n");
#line 164 "ModelTemplate.cshtml"

#line default
#line hidden

#line 164 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 164 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    :param deserialize: A deserializer\n    :param response: Server response to be deserialized.\n    \"\"\"\n");
#line 168 "ModelTemplate.cshtml"

#line default
#line hidden

#line 168 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 168 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    def __init__(self, response, deserialize, *args):\n");
#line 170 "ModelTemplate.cshtml"

#line default
#line hidden

#line 170 "ModelTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 170 "ModelTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("      model_name = \'");
#line 171 "ModelTemplate.cshtml"
                  Write(currModel.Name);

#line default
#line hidden
            WriteLiteral("\'\n      self.error = deserialize(model_name, response)\n      if self.error is None:\n          self.error = deserialize.dependencies[model_name]()\n      super(");
#line 175 "ModelTemplate.cshtml"
          Write(currModel.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral(", self).__init__(response=response)\n");
#line 176 "ModelTemplate.cshtml"
}

#line default
#line hidden

#line 177 "ModelTemplate.cshtml"
       
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
