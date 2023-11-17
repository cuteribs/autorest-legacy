// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureMethodGroupTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureMethodGroupTemplate.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "AzureMethodGroupTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 4 "AzureMethodGroupTemplate.cshtml"
using AutoRest.Python.Azure.Model

#line default
#line hidden
    ;
#line 5 "AzureMethodGroupTemplate.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureMethodGroupTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Azure.Model.MethodGroupPya>
    {
        #line hidden
        public AzureMethodGroupTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 9 "AzureMethodGroupTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 11 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 12 "AzureMethodGroupTemplate.cshtml"
 if (Model.AddTracingDecorators)
{

#line default
#line hidden

            WriteLiteral("from azure.core.tracing.decorator import distributed_trace\n");
#line 15 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("import uuid\n");
#line 17 "AzureMethodGroupTemplate.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 20 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 21 "AzureMethodGroupTemplate.cshtml"
 if (Model.HasAnyHttpResponseErrors)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 24 "AzureMethodGroupTemplate.cshtml"
}
else if (Model.HasAnyCloudErrors)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\nfrom azure.mgmt.core.exceptions import ARMError\n");
#line 29 "AzureMethodGroupTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 33 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 34 "AzureMethodGroupTemplate.cshtml"
 if (Model.HasAnyPagingOperation)
{

#line default
#line hidden

            WriteLiteral("from azure.core.paging import ItemPaged\n");
#line 37 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 38 "AzureMethodGroupTemplate.cshtml"
 if (Model.HasAnyLongRunOperation)
{

#line default
#line hidden

            WriteLiteral("from azure.core.polling import LROPoller, NoPolling\nfrom azure.mgmt.core.polling.arm_polling import ARMPolling\n");
#line 42 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 43 "AzureMethodGroupTemplate.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

#line 45 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 45 "AzureMethodGroupTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("from .. import models\n");
#line 47 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 48 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 49 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 50 "AzureMethodGroupTemplate.cshtml"
  Write((string) Model.TypeName);

#line default
#line hidden
            WriteLiteral("(object):\n    \"\"\"");
#line 51 "AzureMethodGroupTemplate.cshtml"
   Write((string) Model.TypeName);

#line default
#line hidden
            WriteLiteral(" operations.\n");
#line 52 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    You should not instantiate directly this class, but create a Client instance that will create it for you and attach it as attribute.\n");
#line 54 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    :param client: Client for service requests.\n    :param config: Configuration of service client.\n    :param serializer: An object model serializer.\n    :param deserializer: An object model deserializer.\n");
#line 59 "AzureMethodGroupTemplate.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("    ");
#line 61 "AzureMethodGroupTemplate.cshtml"
 Write(Model.GetPropertyDocumentationString(property));

#line default
#line hidden
            WriteLiteral("\n");
#line 62 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 64 "AzureMethodGroupTemplate.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

#line 66 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 66 "AzureMethodGroupTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    models = models\n");
#line 68 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 69 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(self, client, config, serializer, deserializer):\n");
#line 71 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self._client = client\n        self._serialize = serializer\n        self._deserialize = deserializer\n");
#line 75 "AzureMethodGroupTemplate.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 77 "AzureMethodGroupTemplate.cshtml"
     Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 77 "AzureMethodGroupTemplate.cshtml"
                      Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 78 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 79 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self._config = config\n");
#line 81 "AzureMethodGroupTemplate.cshtml"
 foreach (var method in Model.MethodTemplateModels)
{

#line default
#line hidden

#line 83 "AzureMethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 83 "AzureMethodGroupTemplate.cshtml"
          

#line default
#line hidden

#line 84 "AzureMethodGroupTemplate.cshtml"
Write(Include(new AzureMethodTemplate() {AsyncMode = AsyncMode, Python3Mode = Python3Mode}, (MethodPya)method));

#line default
#line hidden
            WriteLiteral("\n");
#line 85 "AzureMethodGroupTemplate.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
