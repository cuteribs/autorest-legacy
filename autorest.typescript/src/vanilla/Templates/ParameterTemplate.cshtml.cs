// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "ParameterTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "ParameterTemplate.cshtml"
using System.Text.RegularExpressions

#line default
#line hidden
    ;
#line 3 "ParameterTemplate.cshtml"
using AutoRest.TypeScript.vanilla.Templates

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ParameterTemplate : AutoRest.Core.Template<AutoRest.TypeScript.Model.CodeModelTS>
    {
        #line hidden
        public ParameterTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("/*\n");
#line 6 "ParameterTemplate.cshtml"
Write(Header(" * "));

#line default
#line hidden
            WriteLiteral("\n */\n");
#line 8 "ParameterTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\nimport * as coreHttp from \"@azure/core-http\";\n");
#line 11 "ParameterTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 13 "ParameterTemplate.cshtml"
Write(Model.GenerateParameterMappers());

#line default
#line hidden
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
    }
}