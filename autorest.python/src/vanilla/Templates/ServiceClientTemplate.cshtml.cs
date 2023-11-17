// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "ServiceClientTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "ServiceClientTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "ServiceClientTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "ServiceClientTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 6 "ServiceClientTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public ServiceClientTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 10 "ServiceClientTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 12 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 13 "ServiceClientTemplate.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 16 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("from azure.core import PipelineClient\nfrom msrest import Serializer, Deserializer\n");
#line 19 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom ._configuration import ");
#line 20 "ServiceClientTemplate.cshtml"
                        Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration\n");
#line 21 "ServiceClientTemplate.cshtml"
  
bool hasClientLevelMethods = Model.MethodTemplateModels.Any( each => each.MethodGroup.IsCodeModelMethodGroup);

#line default
#line hidden

#line 24 "ServiceClientTemplate.cshtml"
 if (hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("from .operations import ");
#line 26 "ServiceClientTemplate.cshtml"
                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin\n");
#line 27 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 28 "ServiceClientTemplate.cshtml"
 if (Model.HasAnyDefaultExceptions)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 31 "ServiceClientTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 35 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 36 "ServiceClientTemplate.cshtml"
 if (Model.MethodGroupModels.Any())
{
  foreach (var modelGroupType in Model.MethodGroupModels)
  {

#line default
#line hidden

            WriteLiteral("from .operations import ");
#line 40 "ServiceClientTemplate.cshtml"
                      Write((string) modelGroupType.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 41 "ServiceClientTemplate.cshtml"
  }
}

#line default
#line hidden

#line 43 "ServiceClientTemplate.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

            WriteLiteral("from . import models\n");
#line 46 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 47 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 48 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 49 "ServiceClientTemplate.cshtml"
 if (hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("class ");
#line 51 "ServiceClientTemplate.cshtml"
    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 51 "ServiceClientTemplate.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin):\n");
#line 52 "ServiceClientTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("class ");
#line 55 "ServiceClientTemplate.cshtml"
    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(object):\n");
#line 56 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"");
#line 57 "ServiceClientTemplate.cshtml"
  Write(Model.ServiceDocument);

#line default
#line hidden
            WriteLiteral("\n");
#line 58 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 59 "ServiceClientTemplate.cshtml"
 if (Model.MethodGroupModels.Any())
{

#line default
#line hidden

#line 61 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 61 "ServiceClientTemplate.cshtml"
          
  foreach (var methodGroup in Model.MethodGroupModels)
  {

#line default
#line hidden

            WriteLiteral("    :ivar ");
#line 64 "ServiceClientTemplate.cshtml"
        Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(": ");
#line 64 "ServiceClientTemplate.cshtml"
                                                       Write((string) methodGroup.Name);

#line default
#line hidden
            WriteLiteral(" operations\n    :vartype ");
#line 65 "ServiceClientTemplate.cshtml"
           Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(": ");
#line 65 "ServiceClientTemplate.cshtml"
                                                          Write(Model.Namespace);

#line default
#line hidden
            WriteLiteral(".operations.");
#line 65 "ServiceClientTemplate.cshtml"
                                                                                        Write((string) methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 66 "ServiceClientTemplate.cshtml"
  }
}

#line default
#line hidden

#line 68 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 69 "ServiceClientTemplate.cshtml"
 foreach (var property in Model.Properties.Where(each => !each.IsConstant))
{

#line default
#line hidden

            WriteLiteral("    ");
#line 71 "ServiceClientTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 72 "ServiceClientTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 73 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 75 "ServiceClientTemplate.cshtml"
 if (!Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("    :param str base_url: Service URL\n");
#line 78 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 80 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(self");
#line 81 "ServiceClientTemplate.cshtml"
                 Write(Model.RequiredConstructorParameters);

#line default
#line hidden
#line 81 "ServiceClientTemplate.cshtml"
                                                       Write(Model.IsCustomBaseUri ? "" : ", base_url=None");

#line default
#line hidden
            WriteLiteral(", **kwargs):\n");
#line 82 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 83 "ServiceClientTemplate.cshtml"
 if (Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("        base_url = \'");
#line 85 "ServiceClientTemplate.cshtml"
                 Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 86 "ServiceClientTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        if not base_url:\n            base_url = \'");
#line 90 "ServiceClientTemplate.cshtml"
                     Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 91 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._config = ");
#line 92 "ServiceClientTemplate.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration(");
#line 92 "ServiceClientTemplate.cshtml"
                                              Write(Model.ConfigConstructorParameters);

#line default
#line hidden
            WriteLiteral("**kwargs)\n        self._client = PipelineClient(base_url=base_url, config=self._config, **kwargs)\n\n");
#line 95 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 96 "ServiceClientTemplate.cshtml"
 if (Model.ModelTemplateModels.Any())
{

#line default
#line hidden

            WriteLiteral("        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}\n");
#line 99 "ServiceClientTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        client_models = {}\n");
#line 103 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 104 "ServiceClientTemplate.cshtml"
 if (Model.ApiVersion != null)
{

#line default
#line hidden

            WriteLiteral("        self.api_version = \'");
#line 106 "ServiceClientTemplate.cshtml"
                          Write(Model.ApiVersion);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 107 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._serialize = Serializer(client_models)\n");
#line 109 "ServiceClientTemplate.cshtml"
 if (! Model.ClientSideValidationEnabled)
{

#line default
#line hidden

            WriteLiteral("        self._serialize.client_side_validation = False\n");
#line 112 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._deserialize = Deserializer(client_models)\n");
#line 114 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 115 "ServiceClientTemplate.cshtml"
 foreach (var methodGroup in Model.MethodGroupModels)
{

#line default
#line hidden

            WriteLiteral("        self.");
#line 117 "ServiceClientTemplate.cshtml"
           Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(" = ");
#line 117 "ServiceClientTemplate.cshtml"
                                                           Write((string) methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral("(\n            self._client, self._config, self._serialize, self._deserialize)\n");
#line 119 "ServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 120 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def close(self):\n        self._client.close()\n\n    def __enter__(self):\n        self._client.__enter__()\n        return self\n\n    def __exit__(self, *exc_details):\n        self._client.__exit__(*exc_details)\n");
        }
        #pragma warning restore 1998
    }
}
