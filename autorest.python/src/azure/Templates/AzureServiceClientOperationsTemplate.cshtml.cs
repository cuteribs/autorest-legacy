// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureServiceClientOperationsTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureServiceClientOperationsTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "AzureServiceClientOperationsTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "AzureServiceClientOperationsTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "AzureServiceClientOperationsTemplate.cshtml"
using AutoRest.Extensions.Azure

#line default
#line hidden
    ;
#line 6 "AzureServiceClientOperationsTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 7 "AzureServiceClientOperationsTemplate.cshtml"
using AutoRest.Python.Azure.Model

#line default
#line hidden
    ;
#line 8 "AzureServiceClientOperationsTemplate.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
#line 9 "AzureServiceClientOperationsTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureServiceClientOperationsTemplate : AutoRest.Python.PythonTemplate<CodeModelPya>
    {
        #line hidden
        public AzureServiceClientOperationsTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 13 "AzureServiceClientOperationsTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 15 "AzureServiceClientOperationsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 16 "AzureServiceClientOperationsTemplate.cshtml"
 if (Model.AddTracingDecorators)
{

#line default
#line hidden

            WriteLiteral("from azure.core.tracing.decorator import distributed_trace\n");
#line 19 "AzureServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 20 "AzureServiceClientOperationsTemplate.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 23 "AzureServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 24 "AzureServiceClientOperationsTemplate.cshtml"
 if(Model.HasAnyHttpResponseErrors)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 27 "AzureServiceClientOperationsTemplate.cshtml"
}
else if (Model.HasAnyCloudErrors)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\nfrom azure.mgmt.core.exceptions import ARMError\n");
#line 32 "AzureServiceClientOperationsTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 36 "AzureServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 37 "AzureServiceClientOperationsTemplate.cshtml"
 if (Model.HasAnyPagingOperation)
{

#line default
#line hidden

            WriteLiteral("from azure.core.paging import ItemPaged\n");
#line 40 "AzureServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 41 "AzureServiceClientOperationsTemplate.cshtml"
 if (Model.HasAnyLongRunOperation)
{

#line default
#line hidden

            WriteLiteral("from azure.core.polling import LROPoller, NoPolling\nfrom azure.mgmt.polling.arm_polling import ARMPolling\n");
#line 45 "AzureServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 46 "AzureServiceClientOperationsTemplate.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

            WriteLiteral("from .. import models\n");
#line 49 "AzureServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("import uuid\n");
#line 51 "AzureServiceClientOperationsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 52 "AzureServiceClientOperationsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 53 "AzureServiceClientOperationsTemplate.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin(object):\n\n");
#line 55 "AzureServiceClientOperationsTemplate.cshtml"
 foreach (var method in Model.MethodTemplateModels.Where(each => each.MethodGroup.IsCodeModelMethodGroup))
{

#line default
#line hidden

#line 57 "AzureServiceClientOperationsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 57 "AzureServiceClientOperationsTemplate.cshtml"
          

#line default
#line hidden

#line 58 "AzureServiceClientOperationsTemplate.cshtml"
Write(Include(new AzureMethodTemplate() {AsyncMode = false, Python3Mode = false}, (MethodPya)method));

#line default
#line hidden
#line 58 "AzureServiceClientOperationsTemplate.cshtml"
                                                                                                 
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
