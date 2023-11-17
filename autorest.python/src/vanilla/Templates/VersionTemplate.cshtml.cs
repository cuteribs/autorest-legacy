// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "VersionTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "VersionTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "VersionTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class VersionTemplate : AutoRest.Core.Template<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public VersionTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 7 "VersionTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 9 "VersionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nVERSION = \"");
#line 10 "VersionTemplate.cshtml"
      Write(Model.Version);

#line default
#line hidden
            WriteLiteral("\"\n");
#line 11 "VersionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
