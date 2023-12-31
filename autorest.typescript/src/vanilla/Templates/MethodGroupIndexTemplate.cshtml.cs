// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "MethodGroupIndexTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "MethodGroupIndexTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 3 "MethodGroupIndexTemplate.cshtml"
using AutoRest.TypeScript.Utilities

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodGroupIndexTemplate : AutoRest.Core.Template<AutoRest.TypeScript.Model.CodeModelTS>
    {
        #line hidden
        public MethodGroupIndexTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 5 "MethodGroupIndexTemplate.cshtml"
Write(LicenseHeader.GenerateLicenseHeader(AutoRest.Core.Settings.DefaultMaximumCommentColumns));

#line default
#line hidden
            WriteLiteral("\r\n");
#line 6 "MethodGroupIndexTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\r\n");
#line 7 "MethodGroupIndexTemplate.cshtml"
 foreach (var methodGroup in Model.MethodGroupModels)
{

#line default
#line hidden

            WriteLiteral("export * from \"./");
#line 9 "MethodGroupIndexTemplate.cshtml"
               Write(methodGroup.TypeName.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\";\r\n");
#line 10 "MethodGroupIndexTemplate.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
