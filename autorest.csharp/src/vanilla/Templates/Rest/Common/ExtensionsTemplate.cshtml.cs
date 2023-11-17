// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Common
{
#line 1 "ExtensionsTemplate.cshtml"
using System.Text

#line default
#line hidden
    ;
#line 2 "ExtensionsTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ExtensionsTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodGroupCs>
    {
        #line hidden
        public ExtensionsTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 4 "ExtensionsTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 5 "ExtensionsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 6 "ExtensionsTemplate.cshtml"
     Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 8 "ExtensionsTemplate.cshtml"
 foreach (var usingString in Model.Usings) {

#line default
#line hidden

            WriteLiteral("    using ");
#line 9 "ExtensionsTemplate.cshtml"
       Write(usingString);

#line default
#line hidden
            WriteLiteral(";\n");
#line 10 "ExtensionsTemplate.cshtml"
}

#line default
#line hidden

#line 11 "ExtensionsTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    /// <summary>\n    /// Extension methods for ");
#line 13 "ExtensionsTemplate.cshtml"
                          Write(Model.ExtensionTypeName);

#line default
#line hidden
            WriteLiteral(".\n    /// </summary>\n    public static partial class ");
#line 15 "ExtensionsTemplate.cshtml"
                            Write(Model.ExtensionTypeName);

#line default
#line hidden
            WriteLiteral("Extensions\n    {\n");
#line 17 "ExtensionsTemplate.cshtml"
        

#line default
#line hidden

#line 17 "ExtensionsTemplate.cshtml"
         foreach (MethodCs method in Model.Methods)
        {
            if (method.ExcludeFromInterface)
            {
                continue;
            }


#line default
#line hidden

            WriteLiteral("            ");
#line 24 "ExtensionsTemplate.cshtml"
          Write(Include(new ExtensionMethodTemplate(), method));

#line default
#line hidden
            WriteLiteral("\n");
#line 25 "ExtensionsTemplate.cshtml"
            

#line default
#line hidden

#line 25 "ExtensionsTemplate.cshtml"
       Write(EmptyLine);

#line default
#line hidden
#line 25 "ExtensionsTemplate.cshtml"
                       
        }

#line default
#line hidden

            WriteLiteral("    }\n}");
        }
        #pragma warning restore 1998
    }
}
