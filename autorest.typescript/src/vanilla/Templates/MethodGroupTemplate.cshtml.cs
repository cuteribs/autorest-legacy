// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "MethodGroupTemplate.cshtml"
using AutoRest.TypeScript

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodGroupTemplate : AutoRest.Core.Template<AutoRest.TypeScript.Model.MethodGroupTS>
    {
        #line hidden
        public MethodGroupTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 3 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 4 "MethodGroupTemplate.cshtml"
Write(Model.GenerateMethodGroupImports());

#line default
#line hidden
            WriteLiteral("\n");
#line 5 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n/** Class representing a ");
#line 6 "MethodGroupTemplate.cshtml"
                     Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral(". */\nexport class ");
#line 7 "MethodGroupTemplate.cshtml"
         Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral(" {\n  private readonly client: ");
#line 8 "MethodGroupTemplate.cshtml"
                       Write(Model.CodeModelTS.ContextName);

#line default
#line hidden
            WriteLiteral(";\n");
#line 9 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n  /**\n   * Create a ");
#line 11 "MethodGroupTemplate.cshtml"
         Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral(".\n   * @param {");
#line 12 "MethodGroupTemplate.cshtml"
         Write(Model.CodeModelTS.ContextName);

#line default
#line hidden
            WriteLiteral("} client Reference to the service client.\n   */\n  constructor(client: ");
#line 14 "MethodGroupTemplate.cshtml"
                  Write(Model.CodeModelTS.ContextName);

#line default
#line hidden
            WriteLiteral(") {\n    this.client = client;\n  }\n  ");
#line 17 "MethodGroupTemplate.cshtml"
Write(CodeGeneratorTS.GenerateMethods(Model.MethodTemplateModels, EmptyLine));

#line default
#line hidden
            WriteLiteral("\n}\n");
#line 19 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 20 "MethodGroupTemplate.cshtml"
Write(Model.GenerateOperationSpecDefinitions(EmptyLine));

#line default
#line hidden
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
    }
}
