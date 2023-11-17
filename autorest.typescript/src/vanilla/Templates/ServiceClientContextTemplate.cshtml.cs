// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "ServiceClientContextTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "ServiceClientContextTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 3 "ServiceClientContextTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientContextTemplate : AutoRest.Core.Template<AutoRest.TypeScript.Model.CodeModelTS>
    {
        #line hidden
        public ServiceClientContextTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("/*\n");
#line 6 "ServiceClientContextTemplate.cshtml"
Write(Header(" * "));

#line default
#line hidden
            WriteLiteral("\n */\n");
#line 8 "ServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nimport * as coreHttp from \"@azure/core-http\";\n");
#line 10 "ServiceClientContextTemplate.cshtml"
  
bool usesCustomOptionsType = Model.OptionalParameterTypeForClientConstructor != "ServiceClientOptions";
if (usesCustomOptionsType)
{

#line default
#line hidden

            WriteLiteral("import * as Models from \"./models\";\n");
#line 15 "ServiceClientContextTemplate.cshtml"
}

#line default
#line hidden

#line 17 "ServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\nconst packageName = \"");
#line 19 "ServiceClientContextTemplate.cshtml"
                Write(Model.Settings.PackageName);

#line default
#line hidden
            WriteLiteral("\";\nconst packageVersion = \"");
#line 20 "ServiceClientContextTemplate.cshtml"
                   Write(Model.Settings.PackageVersion);

#line default
#line hidden
            WriteLiteral("\";\n");
#line 21 "ServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nexport class ");
#line 22 "ServiceClientContextTemplate.cshtml"
         Write(Model.ContextName);

#line default
#line hidden
            WriteLiteral(" extends coreHttp.ServiceClient {\n  ");
#line 23 "ServiceClientContextTemplate.cshtml"
Write(Model.GenerateClassProperties(EmptyLine));

#line default
#line hidden
            WriteLiteral("\n");
#line 24 "ServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n  ");
#line 25 "ServiceClientContextTemplate.cshtml"
Write(Model.GenerateConstructorComment(Model.ContextName));

#line default
#line hidden
            WriteLiteral("\n  ");
#line 26 "ServiceClientContextTemplate.cshtml"
Write(Model.GenerateContextConstructor(@EmptyLine));

#line default
#line hidden
            WriteLiteral("\n}\n");
        }
        #pragma warning restore 1998
    }
}
