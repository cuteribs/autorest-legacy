// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "AliasIndexTemplate.cshtml"
using AutoRest.Core.Utilities;

#line default
#line hidden
    using System.Threading.Tasks;

    public class AliasIndexTemplate : AutoRest.Core.Template<AutoRest.TypeScript.Model.CodeModelTS>
    {
        #line hidden
        public AliasIndexTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("/*\n");
#line 4 "AliasIndexTemplate.cshtml"
Write(Header(" * "));

#line default
#line hidden
            WriteLiteral("\n */\nexport * from \"");
#line 6 "AliasIndexTemplate.cshtml"
           Write(Model.Settings.AliasedNpmPackageName);

#line default
#line hidden
            WriteLiteral("\";\n");
        }
        #pragma warning restore 1998
    }
}
