// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "ServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "ServiceClientOperationsTemplateAsync.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "ServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "ServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 6 "ServiceClientOperationsTemplateAsync.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientOperationsTemplateAsync : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public ServiceClientOperationsTemplateAsync()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 10 "ServiceClientOperationsTemplateAsync.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 12 "ServiceClientOperationsTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 13 "ServiceClientOperationsTemplateAsync.cshtml"
 if (Model.AddTracingDecorators)
{

#line default
#line hidden

            WriteLiteral("from azure.core.tracing.decorator import distributed_trace\nfrom azure.core.tracing.decorator_async import distributed_trace_async\n");
#line 17 "ServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 18 "ServiceClientOperationsTemplateAsync.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 21 "ServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 22 "ServiceClientOperationsTemplateAsync.cshtml"
 if (Model.HasAnyDefaultExceptions)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 25 "ServiceClientOperationsTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 29 "ServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 30 "ServiceClientOperationsTemplateAsync.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

            WriteLiteral("from ... import models\n");
#line 33 "ServiceClientOperationsTemplateAsync.cshtml"
}

#line default
#line hidden

#line 34 "ServiceClientOperationsTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 35 "ServiceClientOperationsTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 36 "ServiceClientOperationsTemplateAsync.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin:\n");
#line 37 "ServiceClientOperationsTemplateAsync.cshtml"
 foreach (var method in Model.MethodTemplateModels.Where(each => each.MethodGroup.IsCodeModelMethodGroup))
{

#line default
#line hidden

#line 39 "ServiceClientOperationsTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 39 "ServiceClientOperationsTemplateAsync.cshtml"
          

#line default
#line hidden

#line 40 "ServiceClientOperationsTemplateAsync.cshtml"
Write(Include(new MethodTemplate() {AsyncMode = true, Python3Mode = true}, method));

#line default
#line hidden
#line 40 "ServiceClientOperationsTemplateAsync.cshtml"
                                                                               
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
