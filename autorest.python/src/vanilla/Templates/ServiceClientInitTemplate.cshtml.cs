// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "ServiceClientInitTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "ServiceClientInitTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientInitTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientInitTemplate : AutoRest.Core.Template<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public ServiceClientInitTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 7 "ServiceClientInitTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 9 "ServiceClientInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom ._");
#line 10 "ServiceClientInitTemplate.cshtml"
   Write(Model.Name.ToPythonCase());

#line default
#line hidden
            WriteLiteral(" import ");
#line 10 "ServiceClientInitTemplate.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\n__all__ = [\'");
#line 11 "ServiceClientInitTemplate.cshtml"
        Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\']\n");
#line 12 "ServiceClientInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom .version import VERSION\n");
#line 14 "ServiceClientInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n__version__ = VERSION\n");
#line 16 "ServiceClientInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
