// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "MethodGroupInterfaceTemplate.cshtml"
using System

#line default
#line hidden
    ;
#line 2 "MethodGroupInterfaceTemplate.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "MethodGroupInterfaceTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 4 "MethodGroupInterfaceTemplate.cshtml"
using AutoRest.CSharp

#line default
#line hidden
    ;
#line 5 "MethodGroupInterfaceTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodGroupInterfaceTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodGroupCs>
    {
        #line hidden
        public MethodGroupInterfaceTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 7 "MethodGroupInterfaceTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 8 "MethodGroupInterfaceTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 9 "MethodGroupInterfaceTemplate.cshtml"
     Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 11 "MethodGroupInterfaceTemplate.cshtml"
 foreach (var usingString in Model.Usings) {

#line default
#line hidden

            WriteLiteral("    using ");
#line 12 "MethodGroupInterfaceTemplate.cshtml"
       Write(usingString);

#line default
#line hidden
            WriteLiteral(";\n");
#line 13 "MethodGroupInterfaceTemplate.cshtml"
}

#line default
#line hidden

#line 14 "MethodGroupInterfaceTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    /// <summary>\n    /// ");
#line 16 "MethodGroupInterfaceTemplate.cshtml"
    Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral(" operations.\n    /// </summary>\n    public partial interface I");
#line 18 "MethodGroupInterfaceTemplate.cshtml"
                          Write(Model.TypeName);

#line default
#line hidden
            WriteLiteral("\n    {\n");
#line 20 "MethodGroupInterfaceTemplate.cshtml"
    

#line default
#line hidden

#line 20 "MethodGroupInterfaceTemplate.cshtml"
     foreach(MethodCs method in Model.Methods)
    {
        if (method.ExcludeFromInterface)
        {
            continue;
        }

        if (!String.IsNullOrEmpty(method.Description) || !String.IsNullOrEmpty(method.Summary))
        {

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 30 "MethodGroupInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", String.IsNullOrEmpty(method.Summary) ? method.Description.EscapeXmlComment() : method.Summary.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n");
#line 31 "MethodGroupInterfaceTemplate.cshtml"
            if (!String.IsNullOrEmpty(method.ExternalDocsUrl))
            {

#line default
#line hidden

            WriteLiteral("        /// <see href=\"");
#line 33 "MethodGroupInterfaceTemplate.cshtml"
                    Write(method.ExternalDocsUrl);

#line default
#line hidden
            WriteLiteral("\" />\n");
#line 34 "MethodGroupInterfaceTemplate.cshtml"
            }

#line default
#line hidden

            WriteLiteral("        /// </summary>\n");
#line 36 "MethodGroupInterfaceTemplate.cshtml"
        }
        if (!String.IsNullOrEmpty(method.Description) && !String.IsNullOrEmpty(method.Summary))
        {

#line default
#line hidden

            WriteLiteral("        /// <remarks>\n        ");
#line 40 "MethodGroupInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", method.Description.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </remarks>\n");
#line 42 "MethodGroupInterfaceTemplate.cshtml"
        }
        foreach (ParameterCs parameter in method.LocalParameters)
        {

#line default
#line hidden

            WriteLiteral("        /// <param name=\'");
#line 45 "MethodGroupInterfaceTemplate.cshtml"
                      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\'>\n        ");
#line 46 "MethodGroupInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", parameter.DocumentationString.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </param>\n");
#line 48 "MethodGroupInterfaceTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("        /// <param name=\'customHeaders\'>\n        /// The headers that will be added to request.\n        /// </param>\n        /// <param name=\'cancellationToken\'>\n        /// The cancellation token.\n        /// </param>\n        /// <exception cref=\"");
#line 55 "MethodGroupInterfaceTemplate.cshtml"
                           Write(method.OperationExceptionTypeString);

#line default
#line hidden
            WriteLiteral("\">\n        /// Thrown when the operation returned an invalid status code\n        /// </exception>\n");
#line 58 "MethodGroupInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 58 "MethodGroupInterfaceTemplate.cshtml"
         if (method.Responses.Where(r => r.Value.Body != null).Any())
        {

#line default
#line hidden

            WriteLiteral("        /// <exception cref=\"Microsoft.Rest.SerializationException\">\n        /// Thrown when unable to deserialize the response\n        /// </exception>\n");
#line 63 "MethodGroupInterfaceTemplate.cshtml"
        }

#line default
#line hidden

#line 63 "MethodGroupInterfaceTemplate.cshtml"
         
        

#line default
#line hidden

#line 64 "MethodGroupInterfaceTemplate.cshtml"
         if (method.Parameters.Any(p => p.IsRequired && p.IsNullable()))
        {

#line default
#line hidden

            WriteLiteral("        /// <exception cref=\"Microsoft.Rest.ValidationException\">\n        /// Thrown when a required parameter is null\n        /// </exception>\n");
#line 69 "MethodGroupInterfaceTemplate.cshtml"
        }

#line default
#line hidden

#line 69 "MethodGroupInterfaceTemplate.cshtml"
         

#line default
#line hidden

            WriteLiteral("        ");
#line 70 "MethodGroupInterfaceTemplate.cshtml"
      Write(method.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n        System.Threading.Tasks.Task<");
#line 71 "MethodGroupInterfaceTemplate.cshtml"
                                 Write(method.OperationResponseReturnTypeString);

#line default
#line hidden
            WriteLiteral("> ");
#line 71 "MethodGroupInterfaceTemplate.cshtml"
                                                                             Write(method.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 71 "MethodGroupInterfaceTemplate.cshtml"
                                                                                                                 Write(method.GetAsyncMethodParameterDeclaration(true));

#line default
#line hidden
            WriteLiteral(");\n");
#line 72 "MethodGroupInterfaceTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("    }\n}");
        }
        #pragma warning restore 1998
    }
}
