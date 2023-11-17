// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.azure.Templates
{
#line 1 "AzureServiceClientTemplateAsync.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureServiceClientTemplateAsync.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "AzureServiceClientTemplateAsync.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "AzureServiceClientTemplateAsync.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "AzureServiceClientTemplateAsync.cshtml"
using AutoRest.Extensions.Azure

#line default
#line hidden
    ;
#line 6 "AzureServiceClientTemplateAsync.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 7 "AzureServiceClientTemplateAsync.cshtml"
using AutoRest.Python.Azure.Model

#line default
#line hidden
    ;
#line 8 "AzureServiceClientTemplateAsync.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
#line 9 "AzureServiceClientTemplateAsync.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureServiceClientTemplateAsync : AutoRest.Python.PythonTemplate<CodeModelPya>
    {
        #line hidden
        public AzureServiceClientTemplateAsync()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 13 "AzureServiceClientTemplateAsync.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 15 "AzureServiceClientTemplateAsync.cshtml"
  
string clientName = Model.Name;

#line default
#line hidden

#line 18 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 19 "AzureServiceClientTemplateAsync.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 22 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("from azure.core import AsyncPipelineClient\nfrom msrest import Serializer, Deserializer\n");
#line 25 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom ._configuration_async import ");
#line 26 "AzureServiceClientTemplateAsync.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration\n");
#line 27 "AzureServiceClientTemplateAsync.cshtml"
  
bool hasClientLevelMethods = Model.MethodTemplateModels.Any( each => each.MethodGroup.IsCodeModelMethodGroup);

#line default
#line hidden

#line 30 "AzureServiceClientTemplateAsync.cshtml"
 if (hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("from .operations_async import ");
#line 32 "AzureServiceClientTemplateAsync.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin\n");
#line 33 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 34 "AzureServiceClientTemplateAsync.cshtml"
 if (Model.MethodGroupModels.Any())
{
  foreach (var modelGroupType in Model.MethodGroupModels)
  {

#line default
#line hidden

            WriteLiteral("from .operations_async import ");
#line 38 "AzureServiceClientTemplateAsync.cshtml"
                            Write((string) modelGroupType.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 39 "AzureServiceClientTemplateAsync.cshtml"
  }
}

#line default
#line hidden

#line 41 "AzureServiceClientTemplateAsync.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

            WriteLiteral("from .. import models\n");
#line 44 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 45 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 46 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 47 "AzureServiceClientTemplateAsync.cshtml"
 if (hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("class ");
#line 49 "AzureServiceClientTemplateAsync.cshtml"
    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 49 "AzureServiceClientTemplateAsync.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin):\n");
#line 50 "AzureServiceClientTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("class ");
#line 53 "AzureServiceClientTemplateAsync.cshtml"
    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(object):\n");
#line 54 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"");
#line 55 "AzureServiceClientTemplateAsync.cshtml"
  Write(Model.ServiceDocument);

#line default
#line hidden
            WriteLiteral("\n    ");
#line 56 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 57 "AzureServiceClientTemplateAsync.cshtml"
 if (Model.MethodGroupModels.Any())
{
    

#line default
#line hidden

#line 59 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 59 "AzureServiceClientTemplateAsync.cshtml"
              
    foreach (var methodGroup in Model.MethodGroupModels)
    {

#line default
#line hidden

            WriteLiteral("    :ivar ");
#line 62 "AzureServiceClientTemplateAsync.cshtml"
        Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(": ");
#line 62 "AzureServiceClientTemplateAsync.cshtml"
                                                       Write((string) methodGroup.Name);

#line default
#line hidden
            WriteLiteral(" operations\n    :vartype ");
#line 63 "AzureServiceClientTemplateAsync.cshtml"
           Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(": ");
#line 63 "AzureServiceClientTemplateAsync.cshtml"
                                                          Write(Model.Namespace);

#line default
#line hidden
            WriteLiteral(".operations.");
#line 63 "AzureServiceClientTemplateAsync.cshtml"
                                                                                        Write((string) methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 64 "AzureServiceClientTemplateAsync.cshtml"
    }
}

#line default
#line hidden

#line 66 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 67 "AzureServiceClientTemplateAsync.cshtml"
 foreach (var property in Model.Properties.Where(each => !each.IsConstant))
{

#line default
#line hidden

            WriteLiteral("    ");
#line 69 "AzureServiceClientTemplateAsync.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 70 "AzureServiceClientTemplateAsync.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 71 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 73 "AzureServiceClientTemplateAsync.cshtml"
 if (!Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("    :param str base_url: Service URL\n");
#line 76 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 78 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(\n            self");
#line 80 "AzureServiceClientTemplateAsync.cshtml"
            Write(Model.RequiredConstructorParameters);

#line default
#line hidden
#line 80 "AzureServiceClientTemplateAsync.cshtml"
                                                  Write(Model.IsCustomBaseUri ? "" : ", base_url=None");

#line default
#line hidden
            WriteLiteral(", **kwargs):\n");
#line 81 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 82 "AzureServiceClientTemplateAsync.cshtml"
 if (Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("        base_url = \'");
#line 84 "AzureServiceClientTemplateAsync.cshtml"
                 Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 85 "AzureServiceClientTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        if not base_url:\n            base_url = \'");
#line 89 "AzureServiceClientTemplateAsync.cshtml"
                     Write(Model.BaseUrl);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 90 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._config = ");
#line 91 "AzureServiceClientTemplateAsync.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration(");
#line 91 "AzureServiceClientTemplateAsync.cshtml"
                                              Write(Model.ConfigConstructorParameters);

#line default
#line hidden
            WriteLiteral("**kwargs)\n        self._client = AsyncPipelineClient(base_url=base_url, config=self._config, **kwargs)\n");
#line 93 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 94 "AzureServiceClientTemplateAsync.cshtml"
 if (Model.ModelTemplateModels.Any(each => !each.Extensions.ContainsKey(AzureExtensions.ExternalExtension)))
{

#line default
#line hidden

            WriteLiteral("        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}\n");
#line 97 "AzureServiceClientTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        client_models = {}\n");
#line 101 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 102 "AzureServiceClientTemplateAsync.cshtml"
 if (Model.ApiVersion != null)
{

#line default
#line hidden

            WriteLiteral("        self.api_version = \'");
#line 104 "AzureServiceClientTemplateAsync.cshtml"
                          Write(Model.ApiVersion);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 105 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("        self._serialize = Serializer(client_models)\n        self._deserialize = Deserializer(client_models)\n");
#line 108 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 109 "AzureServiceClientTemplateAsync.cshtml"
 foreach (var methodGroup in Model.MethodGroupModels)
{

#line default
#line hidden

            WriteLiteral("        self.");
#line 111 "AzureServiceClientTemplateAsync.cshtml"
           Write(((string) methodGroup.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(" = ");
#line 111 "AzureServiceClientTemplateAsync.cshtml"
                                                           Write((string) methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral("(\n            self._client, self._config, self._serialize, self._deserialize)\n");
#line 113 "AzureServiceClientTemplateAsync.cshtml"
}

#line default
#line hidden

#line 114 "AzureServiceClientTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    async def close(self):\n        await self._client.close()\n\n    async def __aenter__(self):\n        await self._client.__aenter__()\n        return self\n\n    async def __aexit__(self, *exc_details):\n        await self._client.__aexit__(*exc_details)");
        }
        #pragma warning restore 1998
    }
}
