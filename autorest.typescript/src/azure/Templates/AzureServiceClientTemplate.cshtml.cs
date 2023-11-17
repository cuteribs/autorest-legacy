// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureServiceClientTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "AzureServiceClientTemplate.cshtml"
using AutoRest.TypeScript

#line default
#line hidden
    ;
#line 3 "AzureServiceClientTemplate.cshtml"
using AutoRest.TypeScript.Azure.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureServiceClientTemplate : AutoRest.Core.Template<CodeModelTSa>
    {
        #line hidden
        public AzureServiceClientTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("/*\n");
#line 6 "AzureServiceClientTemplate.cshtml"
Write(Header(" * "));

#line default
#line hidden
            WriteLiteral("\n */\n");
#line 8 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 9 "AzureServiceClientTemplate.cshtml"
Write(Model.GenerateAzureServiceClientImports());

#line default
#line hidden
            WriteLiteral("\n");
#line 10 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 11 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 12 "AzureServiceClientTemplate.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" extends ");
#line 12 "AzureServiceClientTemplate.cshtml"
                        Write(Model.ContextName);

#line default
#line hidden
            WriteLiteral(" {\n");
#line 13 "AzureServiceClientTemplate.cshtml"
 if (Model.MethodGroupModels.Any())
{

#line default
#line hidden

            WriteLiteral("  // Operation groups\n");
#line 16 "AzureServiceClientTemplate.cshtml"
foreach (var methodGroup in Model.MethodGroupModels)
{

#line default
#line hidden

            WriteLiteral("  ");
#line 18 "AzureServiceClientTemplate.cshtml"
Write(methodGroup.NameForProperty);

#line default
#line hidden
            WriteLiteral(": operations.");
#line 18 "AzureServiceClientTemplate.cshtml"
                                           Write(methodGroup.TypeName);

#line default
#line hidden
            WriteLiteral(";\n");
#line 19 "AzureServiceClientTemplate.cshtml"
}

#line default
#line hidden

#line 20 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 20 "AzureServiceClientTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("  ");
#line 22 "AzureServiceClientTemplate.cshtml"
Write(Model.GenerateConstructorComment(Model.Name));

#line default
#line hidden
            WriteLiteral("\n  ");
#line 23 "AzureServiceClientTemplate.cshtml"
Write(Model.GenerateClientConstructor());

#line default
#line hidden
            WriteLiteral("\n  ");
#line 24 "AzureServiceClientTemplate.cshtml"
Write(CodeGeneratorTS.GenerateMethods(Model.MethodTemplateModels, EmptyLine));

#line default
#line hidden
            WriteLiteral("\n}\n");
#line 26 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 27 "AzureServiceClientTemplate.cshtml"
Write(Model.GenerateOperationSpecDefinitions(EmptyLine));

#line default
#line hidden
            WriteLiteral("\n");
#line 28 "AzureServiceClientTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 29 "AzureServiceClientTemplate.cshtml"
Write(Model.GenerateServiceClientExports());

#line default
#line hidden
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
    }
}
