// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "ServiceClientTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "ServiceClientTemplate.cshtml"
using AutoRest.TypeScript

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientTemplate : AutoRest.Core.Template<AutoRest.TypeScript.Model.CodeModelTS>
    {
        #line hidden
        public ServiceClientTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("/*\n");
#line 5 "ServiceClientTemplate.cshtml"
Write(Header(" * "));

#line default
#line hidden
            WriteLiteral("\n */\n");
#line 7 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 8 "ServiceClientTemplate.cshtml"
Write(Model.GenerateServiceClientImports());

#line default
#line hidden
            WriteLiteral("\n");
#line 9 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 10 "ServiceClientTemplate.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" extends ");
#line 10 "ServiceClientTemplate.cshtml"
                        Write(Model.ContextName);

#line default
#line hidden
            WriteLiteral(" {\n");
#line 11 "ServiceClientTemplate.cshtml"
 if (Model.MethodGroupModels.Any())
{

#line default
#line hidden

            WriteLiteral("\n  // Operation groups\n");
#line 15 "ServiceClientTemplate.cshtml"
 foreach (var methodGroup in Model.MethodGroupModels)
{

#line default
#line hidden

            WriteLiteral("\n  ");
#line 18 "ServiceClientTemplate.cshtml"
Write(methodGroup.NameForProperty);

#line default
#line hidden
            WriteLiteral(": operations.");
#line 18 "ServiceClientTemplate.cshtml"
                                         Write(methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral(";\n");
#line 19 "ServiceClientTemplate.cshtml"
       
}

#line default
#line hidden

#line 21 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 22 "ServiceClientTemplate.cshtml"
       
}

#line default
#line hidden

            WriteLiteral("  ");
#line 24 "ServiceClientTemplate.cshtml"
Write(Model.GenerateConstructorComment(Model.Name));

#line default
#line hidden
            WriteLiteral("\n  ");
#line 25 "ServiceClientTemplate.cshtml"
Write(Model.GenerateClientConstructor());

#line default
#line hidden
            WriteLiteral("\n  ");
#line 26 "ServiceClientTemplate.cshtml"
Write(CodeGeneratorTS.GenerateMethods(Model.MethodTemplateModels, EmptyLine));

#line default
#line hidden
            WriteLiteral("\n}\n");
#line 28 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 29 "ServiceClientTemplate.cshtml"
Write(Model.GenerateOperationSpecDefinitions(EmptyLine));

#line default
#line hidden
            WriteLiteral("\n");
#line 30 "ServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 31 "ServiceClientTemplate.cshtml"
Write(Model.GenerateServiceClientExports());

#line default
#line hidden
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
    }
}
