// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureMethodTemplate.cshtml"
using System;

#line default
#line hidden
#line 2 "AzureMethodTemplate.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "AzureMethodTemplate.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
#line 4 "AzureMethodTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
#line 5 "AzureMethodTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureMethodTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Azure.Model.MethodPya>
    {
        #line hidden
        public AzureMethodTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 7 "AzureMethodTemplate.cshtml"
 if (!Model.IsPagingMethod && !Model.IsLongRunningOperation)
{

#line default
#line hidden

#line 9 "AzureMethodTemplate.cshtml"
Write(Include(new MethodTemplate() {AsyncMode = AsyncMode, Python3Mode = Python3Mode}, (MethodPy)Model));

#line default
#line hidden
            WriteLiteral("\n");
#line 10 "AzureMethodTemplate.cshtml"
}
else if (Model.IsPagingMethod)
{

#line default
#line hidden

#line 13 "AzureMethodTemplate.cshtml"
Write(Include(new AzurePagingMethodTemplate() {AsyncMode = AsyncMode, Python3Mode = Python3Mode}, Model));

#line default
#line hidden
            WriteLiteral("\n");
#line 14 "AzureMethodTemplate.cshtml"
}
else //Long running operations
{

#line default
#line hidden

#line 17 "AzureMethodTemplate.cshtml"
Write(Include(new AzureLongRunningMethodTemplate() {AsyncMode = AsyncMode, Python3Mode = Python3Mode}, Model));

#line default
#line hidden
            WriteLiteral("\n");
#line 18 "AzureMethodTemplate.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
