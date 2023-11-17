// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureServiceClientTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureServiceClientTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "AzureServiceClientTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "AzureServiceClientTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "AzureServiceClientTemplate.cshtml"
using AutoRest.Extensions.Azure

#line default
#line hidden
    ;
#line 6 "AzureServiceClientTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 7 "AzureServiceClientTemplate.cshtml"
using AutoRest.Python.Azure.Model

#line default
#line hidden
    ;
#line 8 "AzureServiceClientTemplate.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
#line 9 "AzureServiceClientTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureServiceClientTemplate : AutoRest.Python.PythonTemplate<CodeModelPya>
    {
        #line hidden
        public AzureServiceClientTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 13 "AzureServiceClientTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 15 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 16 "AzureServiceClientTemplate.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 19 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("from azure.core import PipelineClient\nfrom msrest import Serializer, Deserializer\n");
#line 22 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom ._configuration import ");
#line 23 "AzureServiceClientTemplate.cshtml"
                        Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration\n");
#line 24 "AzureServiceClientTemplate.cshtml"
  
bool hasClientLevelMethods = Model.MethodTemplateModels.Any( each => each.MethodGroup.IsCodeModelMethodGroup);

#line default
#line hidden

#line 27 "AzureServiceClientTemplate.cshtml"
 if (hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("from .operations import ");
#line 29 "AzureServiceClientTemplate.cshtml"
                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin\n");
#line 30 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 31 "AzureServiceClientTemplate.cshtml"
 if (Model.MethodGroupModels.Any())
{
  foreach (var modelGroupType in Model.MethodGroupModels)
  {

#line default
#line hidden

            WriteLiteral("from .operations import ");
#line 35 "AzureServiceClientTemplate.cshtml"
                      Write((string) modelGroupType.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 36 "AzureServiceClientTemplate.cshtml"
  }
}

#line default
#line hidden

#line 38 "AzureServiceClientTemplate.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

            WriteLiteral("from . import models\n");
#line 41 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 42 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 43 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 44 "AzureServiceClientTemplate.cshtml"
 if (hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("class ");
#line 46 "AzureServiceClientTemplate.cshtml"
    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 46 "AzureServiceClientTemplate.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin):\n");
#line 47 "AzureServiceClientTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("class ");
#line 50 "AzureServiceClientTemplate.cshtml"
    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(object):\n");
#line 51 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"");
#line 52 "AzureServiceClientTemplate.cshtml"
  Write(Model.ServiceDocument);

#line default
#line hidden
            WriteLiteral("\n    ");
#line 53 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 54 "AzureServiceClientTemplate.cshtml"
 if (Model.MethodGroupModels.Any())
{
    

#line default
#line hidden

#line 56 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 56 "AzureServiceClientTemplate.cshtml"
              
    foreach (var methodGroup in Model.MethodGroupModels)
    {

#line default
#line hidden

            WriteLiteral("    :ivar ");
#line 59 "AzureServiceClientTemplate.cshtml"
        Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(": ");
#line 59 "AzureServiceClientTemplate.cshtml"
                                                       Write((string) methodGroup.Name);

#line default
#line hidden
            WriteLiteral(" operations\n    :vartype ");
#line 60 "AzureServiceClientTemplate.cshtml"
           Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(": ");
#line 60 "AzureServiceClientTemplate.cshtml"
                                                          Write(Model.Namespace);

#line default
#line hidden
            WriteLiteral(".operations.");
#line 60 "AzureServiceClientTemplate.cshtml"
                                                                                        Write((string) methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 61 "AzureServiceClientTemplate.cshtml"
    }
}

#line default
#line hidden

#line 63 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 64 "AzureServiceClientTemplate.cshtml"
 foreach (var property in Model.Properties.Where(each => !each.IsConstant))
{

#line default
#line hidden

            WriteLiteral("    ");
#line 66 "AzureServiceClientTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 67 "AzureServiceClientTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 68 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 70 "AzureServiceClientTemplate.cshtml"
 if (!Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("    :param str base_url: Service URL\n");
#line 73 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 75 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(\n            self");
#line 77 "AzureServiceClientTemplate.cshtml"
            Write(Model.RequiredConstructorParameters);

#line default
#line hidden
#line 77 "AzureServiceClientTemplate.cshtml"
                                                  Write(Model.IsCustomBaseUri ? "" : ", base_url=None");

#line default
#line hidden
            WriteLiteral(", **kwargs):\n");
#line 78 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 79 "AzureServiceClientTemplate.cshtml"
 if (Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("        base_url = \'");
#line 81 "AzureServiceClientTemplate.cshtml"
                 Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 82 "AzureServiceClientTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        if not base_url:\n            base_url = \'");
#line 86 "AzureServiceClientTemplate.cshtml"
                     Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 87 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._config = ");
#line 88 "AzureServiceClientTemplate.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration(");
#line 88 "AzureServiceClientTemplate.cshtml"
                                              Write(Model.ConfigConstructorParameters);

#line default
#line hidden
            WriteLiteral("**kwargs)\n        self._client = PipelineClient(base_url=base_url, config=self._config, **kwargs)\n");
#line 90 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 91 "AzureServiceClientTemplate.cshtml"
 if (Model.ModelTemplateModels.Any(each => !each.Extensions.ContainsKey(AzureExtensions.ExternalExtension)))
{

#line default
#line hidden

            WriteLiteral("        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}\n");
#line 94 "AzureServiceClientTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        client_models = {}\n");
#line 98 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 99 "AzureServiceClientTemplate.cshtml"
 if (Model.ApiVersion != null)
{

#line default
#line hidden

            WriteLiteral("        self.api_version = \'");
#line 101 "AzureServiceClientTemplate.cshtml"
                          Write(Model.ApiVersion);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 102 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._serialize = Serializer(client_models)\n        self._deserialize = Deserializer(client_models)\n");
#line 105 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 106 "AzureServiceClientTemplate.cshtml"
 foreach (var methodGroup in Model.MethodGroupModels)
{

#line default
#line hidden

            WriteLiteral("        self.");
#line 108 "AzureServiceClientTemplate.cshtml"
           Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(" = ");
#line 108 "AzureServiceClientTemplate.cshtml"
                                                           Write((string) methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral("(\n            self._client, self._config, self._serialize, self._deserialize)\n");
#line 110 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 111 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def close(self):\n        self._client.close()\n\n    def __enter__(self):\n        self._client.__enter__()\n        return self\n\n    def __exit__(self, *exc_details):\n        self._client.__exit__(*exc_details)");
        }
        #pragma warning restore 1998
    }
}
