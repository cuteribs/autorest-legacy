// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "ServiceClientInitTemplateAsync.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "ServiceClientInitTemplateAsync.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientInitTemplateAsync.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientInitTemplateAsync : AutoRest.Core.Template<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public ServiceClientInitTemplateAsync()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 7 "ServiceClientInitTemplateAsync.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 9 "ServiceClientInitTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom ._");
#line 10 "ServiceClientInitTemplateAsync.cshtml"
   Write(Model.Name.ToPythonCase());

#line default
#line hidden
            WriteLiteral("_async import ");
#line 10 "ServiceClientInitTemplateAsync.cshtml"
                                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\n__all__ = [\'");
#line 11 "ServiceClientInitTemplateAsync.cshtml"
        Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\']\n");
        }
        #pragma warning restore 1998
    }
}
