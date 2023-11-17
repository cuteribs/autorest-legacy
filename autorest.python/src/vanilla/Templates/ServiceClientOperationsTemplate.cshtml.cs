// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "ServiceClientOperationsTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "ServiceClientOperationsTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientOperationsTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "ServiceClientOperationsTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "ServiceClientOperationsTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 6 "ServiceClientOperationsTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientOperationsTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public ServiceClientOperationsTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 10 "ServiceClientOperationsTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 12 "ServiceClientOperationsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 13 "ServiceClientOperationsTemplate.cshtml"
 if (Model.AddTracingDecorators)
{

#line default
#line hidden

            WriteLiteral("from azure.core.tracing.decorator import distributed_trace\n");
#line 16 "ServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 17 "ServiceClientOperationsTemplate.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 20 "ServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 21 "ServiceClientOperationsTemplate.cshtml"
 if (Model.HasAnyDefaultExceptions)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 24 "ServiceClientOperationsTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 28 "ServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 29 "ServiceClientOperationsTemplate.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

            WriteLiteral("from .. import models\n");
#line 32 "ServiceClientOperationsTemplate.cshtml"
}

#line default
#line hidden

#line 33 "ServiceClientOperationsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 34 "ServiceClientOperationsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 35 "ServiceClientOperationsTemplate.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin(object):\n");
#line 36 "ServiceClientOperationsTemplate.cshtml"
 foreach (var method in Model.MethodTemplateModels.Where(each => each.MethodGroup.IsCodeModelMethodGroup))
{

#line default
#line hidden

#line 38 "ServiceClientOperationsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 38 "ServiceClientOperationsTemplate.cshtml"
          

#line default
#line hidden

#line 39 "ServiceClientOperationsTemplate.cshtml"
Write(Include(new MethodTemplate() {AsyncMode = false, Python3Mode = false}, method));

#line default
#line hidden
#line 39 "ServiceClientOperationsTemplate.cshtml"
                                                                                 
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
