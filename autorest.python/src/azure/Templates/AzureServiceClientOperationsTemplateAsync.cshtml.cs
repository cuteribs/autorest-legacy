// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureServiceClientOperationsTemplateAsync.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "AzureServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "AzureServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "AzureServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Extensions.Azure

#line default
#line hidden
    ;
#line 6 "AzureServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 7 "AzureServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Python.Azure.Model

#line default
#line hidden
    ;
#line 8 "AzureServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
#line 9 "AzureServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureServiceClientOperationsTemplateAsync : AutoRest.Python.PythonTemplate<CodeModelPya>
    {
        #line hidden
        public AzureServiceClientOperationsTemplateAsync()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 13 "AzureServiceClientOperationsTemplateAsync.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 15 "AzureServiceClientOperationsTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 16 "AzureServiceClientOperationsTemplateAsync.cshtml"
 if (Model.AddTracingDecorators)
{

#line default
#line hidden

            WriteLiteral("from azure.core.tracing.decorator import distributed_trace\nfrom azure.core.tracing.decorator_async import distributed_trace_async\n");
#line 20 "AzureServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 21 "AzureServiceClientOperationsTemplateAsync.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 24 "AzureServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 25 "AzureServiceClientOperationsTemplateAsync.cshtml"
 if(Model.HasAnyHttpResponseErrors)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 28 "AzureServiceClientOperationsTemplateAsync.cshtml"
}
else if (Model.HasAnyCloudErrors)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\nfrom azure.mgmt.core.exceptions import ARMError\n");
#line 33 "AzureServiceClientOperationsTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 37 "AzureServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 38 "AzureServiceClientOperationsTemplateAsync.cshtml"
 if (Model.HasAnyPagingOperation)
{

#line default
#line hidden

            WriteLiteral("from azure.core.async_paging import AsyncItemPaged, AsyncList\n");
#line 41 "AzureServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 42 "AzureServiceClientOperationsTemplateAsync.cshtml"
 if (Model.HasAnyLongRunOperation)
{

#line default
#line hidden

            WriteLiteral("from azure.core.polling import async_poller, AsyncNoPolling\nfrom azure.mgmt.polling.async_arm_polling import AsyncARMPolling\n");
#line 46 "AzureServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 47 "AzureServiceClientOperationsTemplateAsync.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

            WriteLiteral("from ... import models\n");
#line 50 "AzureServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("import uuid\n");
#line 52 "AzureServiceClientOperationsTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 53 "AzureServiceClientOperationsTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 54 "AzureServiceClientOperationsTemplateAsync.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin:\n\n");
#line 56 "AzureServiceClientOperationsTemplateAsync.cshtml"
 foreach (var method in Model.MethodTemplateModels.Where(each => each.MethodGroup.IsCodeModelMethodGroup))
{

#line default
#line hidden

#line 58 "AzureServiceClientOperationsTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 58 "AzureServiceClientOperationsTemplateAsync.cshtml"
          

#line default
#line hidden

#line 59 "AzureServiceClientOperationsTemplateAsync.cshtml"
Write(Include(new AzureMethodTemplate() {AsyncMode = true, Python3Mode = true}, (MethodPya)method));

#line default
#line hidden
#line 59 "AzureServiceClientOperationsTemplateAsync.cshtml"
                                                                                               
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
