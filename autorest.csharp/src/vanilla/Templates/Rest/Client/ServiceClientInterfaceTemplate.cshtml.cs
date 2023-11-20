// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "ServiceClientInterfaceTemplate.cshtml"
using System

#line default
#line hidden
    ;
#line 2 "ServiceClientInterfaceTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientInterfaceTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 4 "ServiceClientInterfaceTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientInterfaceTemplate : AutoRest.Core.Template<CodeModelCs>
    {
        #line hidden
        public ServiceClientInterfaceTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 6 "ServiceClientInterfaceTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 7 "ServiceClientInterfaceTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 8 "ServiceClientInterfaceTemplate.cshtml"
     Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 10 "ServiceClientInterfaceTemplate.cshtml"
 foreach (var usingString in Model.Usings) {

#line default
#line hidden

            WriteLiteral("    using ");
#line 11 "ServiceClientInterfaceTemplate.cshtml"
       Write(usingString);

#line default
#line hidden
            WriteLiteral(";\n");
#line 12 "ServiceClientInterfaceTemplate.cshtml"
}

#line default
#line hidden

#line 13 "ServiceClientInterfaceTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n/// <summary>\n    ");
#line 15 "ServiceClientInterfaceTemplate.cshtml"
Write(WrapComment("/// ", Model.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n");
#line 17 "ServiceClientInterfaceTemplate.cshtml"
    

#line default
#line hidden

#line 17 "ServiceClientInterfaceTemplate.cshtml"
     if (@Settings.InterfaceFullName != null)
    {

#line default
#line hidden

            WriteLiteral("    public partial interface I");
#line 19 "ServiceClientInterfaceTemplate.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" : ");
#line 19 "ServiceClientInterfaceTemplate.cshtml"
                                           Write(Settings.InterfaceFullName);

#line default
#line hidden
            WriteLiteral(", System.IDisposable\n");
#line 20 "ServiceClientInterfaceTemplate.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("    public partial interface I");
#line 23 "ServiceClientInterfaceTemplate.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" : System.IDisposable\r\n");
#line 24 "ServiceClientInterfaceTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("    {\n        /// <summary>\n        /// The base URI of the service.\n        /// </summary>\n");
#line 29 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 29 "ServiceClientInterfaceTemplate.cshtml"
         if (!Model.IsCustomBaseUri)
        {

#line default
#line hidden

            WriteLiteral("        System.Uri BaseUri { get; set; }\n");
#line 32 "ServiceClientInterfaceTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("        \n        ");
#line 34 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n        /// <summary>\n        /// Gets or sets json serialization settings.\n        /// </summary>\n        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }\n        ");
#line 40 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n        /// <summary>\n        /// Gets or sets json deserialization settings.\n        /// </summary>\n        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }\n        ");
#line 46 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 48 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 48 "ServiceClientInterfaceTemplate.cshtml"
         foreach (var property in Model.Properties)
        {

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 51 "ServiceClientInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", property.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        ");
#line 53 "ServiceClientInterfaceTemplate.cshtml"
     Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 53 "ServiceClientInterfaceTemplate.cshtml"
                             Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get;");
#line 53 "ServiceClientInterfaceTemplate.cshtml"
                                                   Write(property.IsReadOnly || property.IsConstant ? "" : " set;");

#line default
#line hidden
            WriteLiteral(" }\n");
#line 54 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 54 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 54 "ServiceClientInterfaceTemplate.cshtml"
                  
        }

#line default
#line hidden

            WriteLiteral("\n        ");
#line 57 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 58 "ServiceClientInterfaceTemplate.cshtml"
    

#line default
#line hidden

#line 58 "ServiceClientInterfaceTemplate.cshtml"
     foreach(var operation in Model.AllOperations)
    {

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        /// Gets the I");
#line 61 "ServiceClientInterfaceTemplate.cshtml"
                    Write(operation.TypeName);

#line default
#line hidden
            WriteLiteral(".\n        /// </summary>\n        I");
#line 63 "ServiceClientInterfaceTemplate.cshtml"
       Write(operation.TypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 63 "ServiceClientInterfaceTemplate.cshtml"
                             Write(operation.NameForProperty);

#line default
#line hidden
            WriteLiteral(" { get; }\n");
#line 64 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 64 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 64 "ServiceClientInterfaceTemplate.cshtml"
                  

#line default
#line hidden

            WriteLiteral("        \n");
#line 66 "ServiceClientInterfaceTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("     \n");
#line 68 "ServiceClientInterfaceTemplate.cshtml"
    

#line default
#line hidden

#line 68 "ServiceClientInterfaceTemplate.cshtml"
     foreach(MethodCs method in Model.Methods.Where( each => each.Group.IsNullOrEmpty()) )
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
#line 78 "ServiceClientInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", String.IsNullOrEmpty(method.Summary) ? method.Description.EscapeXmlComment() : method.Summary.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 80 "ServiceClientInterfaceTemplate.cshtml"
        }
        if (!String.IsNullOrEmpty(method.Description) && !String.IsNullOrEmpty(method.Summary))
        {

#line default
#line hidden

            WriteLiteral("        /// <remarks>\n        ");
#line 84 "ServiceClientInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", method.Description.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </remarks>\n");
#line 86 "ServiceClientInterfaceTemplate.cshtml"
        }
        foreach (ParameterCs parameter in method.LocalParameters)
        {

#line default
#line hidden

            WriteLiteral("        /// <param name=\'");
#line 89 "ServiceClientInterfaceTemplate.cshtml"
                      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\'>\n        ");
#line 90 "ServiceClientInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", parameter.DocumentationString.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </param>\n");
#line 92 "ServiceClientInterfaceTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("        /// <param name=\'customHeaders\'>\n        /// The headers that will be added to request.\n        /// </param>\n        /// <param name=\'cancellationToken\'>\n        /// The cancellation token.\n        /// </param>\n        System.Threading.Tasks.Task<");
#line 99 "ServiceClientInterfaceTemplate.cshtml"
                                  Write(method.OperationResponseReturnTypeString);

#line default
#line hidden
            WriteLiteral("> ");
#line 99 "ServiceClientInterfaceTemplate.cshtml"
                                                                               Write(method.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 99 "ServiceClientInterfaceTemplate.cshtml"
                                                                                                                   Write(method.GetAsyncMethodParameterDeclaration(true));

#line default
#line hidden
            WriteLiteral(");\n");
#line 100 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 100 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 100 "ServiceClientInterfaceTemplate.cshtml"
                  

#line default
#line hidden

            WriteLiteral("        \n");
#line 102 "ServiceClientInterfaceTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("\n    }\n}");
        }
        #pragma warning restore 1998
    }
}
