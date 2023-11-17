// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "ServiceClientTemplateAsync.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "ServiceClientTemplateAsync.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientTemplateAsync.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "ServiceClientTemplateAsync.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "ServiceClientTemplateAsync.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 6 "ServiceClientTemplateAsync.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientTemplateAsync : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public ServiceClientTemplateAsync()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 10 "ServiceClientTemplateAsync.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 12 "ServiceClientTemplateAsync.cshtml"
  
string clientName = Model.Name;

#line default
#line hidden

            WriteLiteral("\n");
#line 16 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 17 "ServiceClientTemplateAsync.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 20 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("from azure.core import AsyncPipelineClient\nfrom msrest import Serializer, Deserializer\n");
#line 23 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom ._configuration_async import ");
#line 24 "ServiceClientTemplateAsync.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration\n");
#line 25 "ServiceClientTemplateAsync.cshtml"
  
bool hasClientLevelMethods = Model.MethodTemplateModels.Any( each => each.MethodGroup.IsCodeModelMethodGroup);

#line default
#line hidden

#line 28 "ServiceClientTemplateAsync.cshtml"
 if (hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("from .operations_async import ");
#line 30 "ServiceClientTemplateAsync.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin\n");
#line 31 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 32 "ServiceClientTemplateAsync.cshtml"
 if (Model.HasAnyDefaultExceptions)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 35 "ServiceClientTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 39 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 40 "ServiceClientTemplateAsync.cshtml"
 if (Model.MethodGroupModels.Any())
{
  foreach (var modelGroupType in Model.MethodGroupModels)
  {

#line default
#line hidden

            WriteLiteral("from .operations_async import ");
#line 44 "ServiceClientTemplateAsync.cshtml"
                            Write((string) modelGroupType.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 45 "ServiceClientTemplateAsync.cshtml"
  }
}

#line default
#line hidden

#line 47 "ServiceClientTemplateAsync.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

            WriteLiteral("from .. import models\n");
#line 50 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 51 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 52 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 53 "ServiceClientTemplateAsync.cshtml"
 if (hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("class ");
#line 55 "ServiceClientTemplateAsync.cshtml"
    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 55 "ServiceClientTemplateAsync.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin):\n");
#line 56 "ServiceClientTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("class ");
#line 59 "ServiceClientTemplateAsync.cshtml"
    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(object):\n");
#line 60 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"");
#line 61 "ServiceClientTemplateAsync.cshtml"
  Write(Model.ServiceDocument);

#line default
#line hidden
            WriteLiteral("\n");
#line 62 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 63 "ServiceClientTemplateAsync.cshtml"
 if (Model.MethodGroupModels.Any())
{

#line default
#line hidden

#line 65 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 65 "ServiceClientTemplateAsync.cshtml"
          
  foreach (var methodGroup in Model.MethodGroupModels)
  {

#line default
#line hidden

            WriteLiteral("    :ivar ");
#line 68 "ServiceClientTemplateAsync.cshtml"
        Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(": ");
#line 68 "ServiceClientTemplateAsync.cshtml"
                                                       Write((string) methodGroup.Name);

#line default
#line hidden
            WriteLiteral(" operations\n    :vartype ");
#line 69 "ServiceClientTemplateAsync.cshtml"
           Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(": ");
#line 69 "ServiceClientTemplateAsync.cshtml"
                                                          Write(Model.Namespace);

#line default
#line hidden
            WriteLiteral(".aio.operations_async.");
#line 69 "ServiceClientTemplateAsync.cshtml"
                                                                                                  Write((string) methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 70 "ServiceClientTemplateAsync.cshtml"
  }
}

#line default
#line hidden

#line 72 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 73 "ServiceClientTemplateAsync.cshtml"
 foreach (var property in Model.Properties.Where(each => !each.IsConstant))
{

#line default
#line hidden

            WriteLiteral("    ");
#line 75 "ServiceClientTemplateAsync.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 76 "ServiceClientTemplateAsync.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 77 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 79 "ServiceClientTemplateAsync.cshtml"
 if (!Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("    :param str base_url: Service URL\n");
#line 82 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 84 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(\n            self");
#line 86 "ServiceClientTemplateAsync.cshtml"
            Write(Model.RequiredConstructorParameters);

#line default
#line hidden
#line 86 "ServiceClientTemplateAsync.cshtml"
                                                  Write(Model.IsCustomBaseUri ? "" : ", base_url=None");

#line default
#line hidden
            WriteLiteral(", **kwargs):\n");
#line 87 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 88 "ServiceClientTemplateAsync.cshtml"
 if (Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("        base_url = \'");
#line 90 "ServiceClientTemplateAsync.cshtml"
                 Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 91 "ServiceClientTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        if not base_url:\n            base_url = \'");
#line 95 "ServiceClientTemplateAsync.cshtml"
                     Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 96 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._config = ");
#line 97 "ServiceClientTemplateAsync.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration(");
#line 97 "ServiceClientTemplateAsync.cshtml"
                                              Write(Model.ConfigConstructorParameters);

#line default
#line hidden
            WriteLiteral("**kwargs)\n        self._client = AsyncPipelineClient(base_url=base_url, config=self._config, **kwargs)\n");
#line 99 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 100 "ServiceClientTemplateAsync.cshtml"
 if (Model.ModelTemplateModels.Any())
{

#line default
#line hidden

            WriteLiteral("        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}\n");
#line 103 "ServiceClientTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        client_models = {}\n");
#line 107 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 108 "ServiceClientTemplateAsync.cshtml"
 if (Model.ApiVersion != null)
{

#line default
#line hidden

            WriteLiteral("        self.api_version = \'");
#line 110 "ServiceClientTemplateAsync.cshtml"
                          Write(Model.ApiVersion);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 111 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._serialize = Serializer(client_models)\n");
#line 113 "ServiceClientTemplateAsync.cshtml"
 if (! Model.ClientSideValidationEnabled)
{

#line default
#line hidden

            WriteLiteral("        self._serialize.client_side_validation = False\n");
#line 116 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._deserialize = Deserializer(client_models)\n");
#line 118 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 119 "ServiceClientTemplateAsync.cshtml"
 foreach (var methodGroup in Model.MethodGroupModels)
{

#line default
#line hidden

            WriteLiteral("        self.");
#line 121 "ServiceClientTemplateAsync.cshtml"
           Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(" = ");
#line 121 "ServiceClientTemplateAsync.cshtml"
                                                           Write((string) methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral("(\n            self._client, self._config, self._serialize, self._deserialize)\n");
#line 123 "ServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 124 "ServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    async def close(self):\n        await self._client.close()\n  \n    async def __aenter__(self):\n        await self._client.__aenter__()\n        return self\n\n    async def __aexit__(self, *exc_details):\n        await self._client.__aexit__(*exc_details)\n");
        }
        #pragma warning restore 1998
    }
}
