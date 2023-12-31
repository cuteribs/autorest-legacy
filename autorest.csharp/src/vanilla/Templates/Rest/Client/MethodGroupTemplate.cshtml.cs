// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "MethodGroupTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodGroupTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodGroupCs>
    {
        #line hidden
        public MethodGroupTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 3 "MethodGroupTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 4 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nusing System.Linq;\nusing System.IO;\nusing Microsoft.Rest;\nusing ");
#line 8 "MethodGroupTemplate.cshtml"
  Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral(".");
#line 8 "MethodGroupTemplate.cshtml"
                        Write(Settings.InterfaceFolder);

#line default
#line hidden
            WriteLiteral(";\n");
#line 9 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 10 "MethodGroupTemplate.cshtml"
     Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 12 "MethodGroupTemplate.cshtml"
 foreach (var usingString in Model.Usings)
{

#line default
#line hidden

            WriteLiteral("    using ");
#line 14 "MethodGroupTemplate.cshtml"
       Write(usingString);

#line default
#line hidden
            WriteLiteral(";\n");
#line 15 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 16 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    /// <summary>\n    /// ");
#line 18 "MethodGroupTemplate.cshtml"
    Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral(" operations.\n    /// </summary>\n    public partial class ");
#line 20 "MethodGroupTemplate.cshtml"
                     Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral(" : Microsoft.Rest.IServiceOperations<");
#line 20 "MethodGroupTemplate.cshtml"
                                                                          Write(Model.CodeModel.Name);

#line default
#line hidden
            WriteLiteral(">, I");
#line 20 "MethodGroupTemplate.cshtml"
                                                                                                    Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral("\n    {\n        /// <summary>\n        /// Initializes a new instance of the ");
#line 23 "MethodGroupTemplate.cshtml"
                                          Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral(@" class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref=""System.ArgumentNullException"">
        /// Thrown when a required parameter is null
        /// </exception>
        public ");
#line 31 "MethodGroupTemplate.cshtml"
           Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral("(");
#line 31 "MethodGroupTemplate.cshtml"
                            Write(Model.CodeModel.Name);

#line default
#line hidden
            WriteLiteral(" client)\n        {\n            if (client == null) \n            {\n                throw new System.ArgumentNullException(\"client\");\n            }\n            this.Client = client;\n        }\n        ");
#line 39 "MethodGroupTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        /// Gets a reference to the ");
#line 41 "MethodGroupTemplate.cshtml"
                               Write(Model.CodeModel.Name);

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        public ");
#line 43 "MethodGroupTemplate.cshtml"
          Write(Model.CodeModel.Name);

#line default
#line hidden
            WriteLiteral(" Client { get; private set; }\n        ");
#line 44 "MethodGroupTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 45 "MethodGroupTemplate.cshtml"
        

#line default
#line hidden

#line 45 "MethodGroupTemplate.cshtml"
         foreach (MethodCs method in Model.Methods)
        {

#line default
#line hidden

            WriteLiteral("        ");
#line 47 "MethodGroupTemplate.cshtml"
      Write(Include(new MethodTemplate(), method));

#line default
#line hidden
            WriteLiteral("\n");
#line 48 "MethodGroupTemplate.cshtml"
        

#line default
#line hidden

#line 48 "MethodGroupTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 48 "MethodGroupTemplate.cshtml"
                  
        }

#line default
#line hidden

            WriteLiteral("    }\n}");
        }
        #pragma warning restore 1998
    }
}
