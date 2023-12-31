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
            WriteLiteral(".");
#line 8 "ServiceClientInterfaceTemplate.cshtml"
                            Write(Settings.InterfaceFolder);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 10 "ServiceClientInterfaceTemplate.cshtml"
 foreach (var usingString in Model.Usings)
{

#line default
#line hidden

            WriteLiteral("    using ");
#line 12 "ServiceClientInterfaceTemplate.cshtml"
       Write(usingString);

#line default
#line hidden
            WriteLiteral(";\n");
#line 13 "ServiceClientInterfaceTemplate.cshtml"
}

#line default
#line hidden

#line 14 "ServiceClientInterfaceTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    /// <summary>\n    ");
#line 16 "ServiceClientInterfaceTemplate.cshtml"
Write(WrapComment("/// ", Model.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n");
#line 18 "ServiceClientInterfaceTemplate.cshtml"
    

#line default
#line hidden

#line 18 "ServiceClientInterfaceTemplate.cshtml"
     if (@Settings.CustomInterface != null)
    {

#line default
#line hidden

            WriteLiteral("    public partial interface I");
#line 20 "ServiceClientInterfaceTemplate.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" : ");
#line 20 "ServiceClientInterfaceTemplate.cshtml"
                                           Write(Settings.CustomInterface);

#line default
#line hidden
            WriteLiteral(", System.IDisposable\n");
#line 21 "ServiceClientInterfaceTemplate.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("    public partial interface I");
#line 24 "ServiceClientInterfaceTemplate.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" : System.IDisposable\r\n");
#line 25 "ServiceClientInterfaceTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("    {\n        /// <summary>\n        /// The base URI of the service.\n        /// </summary>\n");
#line 30 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 30 "ServiceClientInterfaceTemplate.cshtml"
         if (!Model.IsCustomBaseUri)
        {

#line default
#line hidden

            WriteLiteral("        System.Uri BaseUri { get; set; }\n");
#line 33 "ServiceClientInterfaceTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("        \n        ");
#line 35 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n        /// <summary>\n        /// Gets or sets json serialization settings.\n        /// </summary>\n        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }\n        ");
#line 41 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n        /// <summary>\n        /// Gets or sets json deserialization settings.\n        /// </summary>\n        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }\n        ");
#line 47 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 49 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 49 "ServiceClientInterfaceTemplate.cshtml"
         foreach (var property in Model.Properties)
        {

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        ");
#line 52 "ServiceClientInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", property.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n        ");
#line 54 "ServiceClientInterfaceTemplate.cshtml"
     Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 54 "ServiceClientInterfaceTemplate.cshtml"
                             Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get;");
#line 54 "ServiceClientInterfaceTemplate.cshtml"
                                                   Write(property.IsReadOnly || property.IsConstant ? "" : " set;");

#line default
#line hidden
            WriteLiteral(" }\n");
#line 55 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 55 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 55 "ServiceClientInterfaceTemplate.cshtml"
                  
        }

#line default
#line hidden

            WriteLiteral("\n        ");
#line 58 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 59 "ServiceClientInterfaceTemplate.cshtml"
    

#line default
#line hidden

#line 59 "ServiceClientInterfaceTemplate.cshtml"
     foreach(var operation in Model.AllOperations)
    {

#line default
#line hidden

            WriteLiteral("        /// <summary>\n        /// Gets the I");
#line 62 "ServiceClientInterfaceTemplate.cshtml"
                    Write(operation.TypeName);

#line default
#line hidden
            WriteLiteral(".\n        /// </summary>\n        I");
#line 64 "ServiceClientInterfaceTemplate.cshtml"
       Write(operation.TypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 64 "ServiceClientInterfaceTemplate.cshtml"
                             Write(operation.NameForProperty);

#line default
#line hidden
            WriteLiteral(" { get; }\n");
#line 65 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 65 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 65 "ServiceClientInterfaceTemplate.cshtml"
                  

#line default
#line hidden

            WriteLiteral("        \n");
#line 67 "ServiceClientInterfaceTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("     \n");
#line 69 "ServiceClientInterfaceTemplate.cshtml"
    

#line default
#line hidden

#line 69 "ServiceClientInterfaceTemplate.cshtml"
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
#line 79 "ServiceClientInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", String.IsNullOrEmpty(method.Summary) ? method.Description.EscapeXmlComment() : method.Summary.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </summary>\n");
#line 81 "ServiceClientInterfaceTemplate.cshtml"
        }
        if (!String.IsNullOrEmpty(method.Description) && !String.IsNullOrEmpty(method.Summary))
        {

#line default
#line hidden

            WriteLiteral("        /// <remarks>\n        ");
#line 85 "ServiceClientInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", method.Description.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </remarks>\n");
#line 87 "ServiceClientInterfaceTemplate.cshtml"
        }
        foreach (ParameterCs parameter in method.LocalParameters)
        {

#line default
#line hidden

            WriteLiteral("        /// <param name=\'");
#line 90 "ServiceClientInterfaceTemplate.cshtml"
                      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\'>\n        ");
#line 91 "ServiceClientInterfaceTemplate.cshtml"
     Write(WrapComment("/// ", parameter.DocumentationString.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n        /// </param>\n");
#line 93 "ServiceClientInterfaceTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("        /// <param name=\'customHeaders\'>\n        /// The headers that will be added to request.\n        /// </param>\n        /// <param name=\'cancellationToken\'>\n        /// The cancellation token.\n        /// </param>\n        System.Threading.Tasks.Task<");
#line 100 "ServiceClientInterfaceTemplate.cshtml"
                                  Write(method.OperationResponseReturnTypeString);

#line default
#line hidden
            WriteLiteral("> ");
#line 100 "ServiceClientInterfaceTemplate.cshtml"
                                                                               Write(method.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 100 "ServiceClientInterfaceTemplate.cshtml"
                                                                                                                   Write(method.GetAsyncMethodParameterDeclaration(true));

#line default
#line hidden
            WriteLiteral(");\n");
#line 101 "ServiceClientInterfaceTemplate.cshtml"
        

#line default
#line hidden

#line 101 "ServiceClientInterfaceTemplate.cshtml"
   Write(EmptyLine);

#line default
#line hidden
#line 101 "ServiceClientInterfaceTemplate.cshtml"
                  

#line default
#line hidden

            WriteLiteral("        \n");
#line 103 "ServiceClientInterfaceTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("\n    }\n}");
        }
        #pragma warning restore 1998
    }
}
