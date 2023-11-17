// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.azure.Templates
{
#line 1 "AzureMethodGroupTemplateAsync.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureMethodGroupTemplateAsync.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "AzureMethodGroupTemplateAsync.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 4 "AzureMethodGroupTemplateAsync.cshtml"
using AutoRest.Python.Azure.Model

#line default
#line hidden
    ;
#line 5 "AzureMethodGroupTemplateAsync.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureMethodGroupTemplateAsync : AutoRest.Python.PythonTemplate<AutoRest.Python.Azure.Model.MethodGroupPya>
    {
        #line hidden
        public AzureMethodGroupTemplateAsync()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 9 "AzureMethodGroupTemplateAsync.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 11 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 12 "AzureMethodGroupTemplateAsync.cshtml"
 if (Model.AddTracingDecorators)
{

#line default
#line hidden

            WriteLiteral("from azure.core.tracing.decorator import distributed_trace\nfrom azure.core.tracing.decorator_async import distributed_trace_async\n");
#line 16 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("import uuid\n");
#line 18 "AzureMethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 21 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 22 "AzureMethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyHttpResponseErrors)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 25 "AzureMethodGroupTemplateAsync.cshtml"
}
else if (Model.HasAnyCloudErrors)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\nfrom azure.mgmt.core.exceptions import ARMError\n");
#line 30 "AzureMethodGroupTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 34 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 35 "AzureMethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyPagingOperation)
{

#line default
#line hidden

            WriteLiteral("from azure.core.async_paging import AsyncItemPaged, AsyncList\n");
#line 38 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 39 "AzureMethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyLongRunOperation)
{

#line default
#line hidden

            WriteLiteral("from azure.core.polling import async_poller, AsyncNoPolling\nfrom azure.mgmt.core.polling.async_arm_polling import AsyncARMPolling\n");
#line 43 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 44 "AzureMethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

#line 46 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 46 "AzureMethodGroupTemplateAsync.cshtml"
          

#line default
#line hidden

            WriteLiteral("from ... import models\n");
#line 48 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 49 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 50 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 51 "AzureMethodGroupTemplateAsync.cshtml"
  Write((string) Model.TypeName);

#line default
#line hidden
            WriteLiteral(":\n    \"\"\"");
#line 52 "AzureMethodGroupTemplateAsync.cshtml"
   Write((string) Model.TypeName);

#line default
#line hidden
            WriteLiteral(" async operations.\n");
#line 53 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    You should not instantiate directly this class, but create a Client instance that will create it for you and attach it as attribute.\n");
#line 55 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    :param client: Client for service requests.\n    :param config: Configuration of service client.\n    :param serializer: An object model serializer.\n    :param deserializer: An object model deserializer.\n");
#line 60 "AzureMethodGroupTemplateAsync.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("    ");
#line 62 "AzureMethodGroupTemplateAsync.cshtml"
 Write(Model.GetPropertyDocumentationString(property));

#line default
#line hidden
            WriteLiteral("\n");
#line 63 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 65 "AzureMethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

#line 67 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 67 "AzureMethodGroupTemplateAsync.cshtml"
          

#line default
#line hidden

            WriteLiteral("    models = models\n");
#line 69 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 70 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(self, client, config, serializer, deserializer) -> None:\n");
#line 72 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self._client = client\n        self._serialize = serializer\n        self._deserialize = deserializer\n");
#line 76 "AzureMethodGroupTemplateAsync.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 78 "AzureMethodGroupTemplateAsync.cshtml"
     Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 78 "AzureMethodGroupTemplateAsync.cshtml"
                      Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 79 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 80 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self._config = config\n");
#line 82 "AzureMethodGroupTemplateAsync.cshtml"
 foreach (var method in Model.MethodTemplateModels)
{

#line default
#line hidden

#line 84 "AzureMethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 84 "AzureMethodGroupTemplateAsync.cshtml"
          

#line default
#line hidden

#line 85 "AzureMethodGroupTemplateAsync.cshtml"
Write(Include(new AzureMethodTemplate() {AsyncMode = true, Python3Mode = true}, (MethodPya)method));

#line default
#line hidden
            WriteLiteral("\n");
#line 86 "AzureMethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
