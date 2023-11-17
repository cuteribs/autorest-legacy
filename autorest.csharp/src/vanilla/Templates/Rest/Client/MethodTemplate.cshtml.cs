// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "MethodTemplate.cshtml"
using System.Globalization

#line default
#line hidden
    ;
#line 2 "MethodTemplate.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "MethodTemplate.cshtml"
using System

#line default
#line hidden
    ;
#line 4 "MethodTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 5 "MethodTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 6 "MethodTemplate.cshtml"
using AutoRest.CSharp

#line default
#line hidden
    ;
#line 7 "MethodTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
#line 8 "MethodTemplate.cshtml"
using AutoRest.Extensions

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodCs>
    {
        #line hidden
        public MethodTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 11 "MethodTemplate.cshtml"
 if (!string.IsNullOrWhiteSpace(Model.Description) || !string.IsNullOrEmpty(Model.Summary))
{

#line default
#line hidden

            WriteLiteral("/// <summary>\n");
#line 14 "MethodTemplate.cshtml"
Write(WrapComment("/// ", String.IsNullOrEmpty(Model.Summary) ? Model.Description.EscapeXmlComment() : Model.Summary.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n");
#line 15 "MethodTemplate.cshtml"
    if (!string.IsNullOrEmpty(Model.ExternalDocsUrl))
    {

#line default
#line hidden

            WriteLiteral("/// <see href=\"");
#line 17 "MethodTemplate.cshtml"
            Write(Model.ExternalDocsUrl);

#line default
#line hidden
            WriteLiteral("\" />\n");
#line 18 "MethodTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("/// </summary>\n");
#line 20 "MethodTemplate.cshtml"
}

#line default
#line hidden

#line 21 "MethodTemplate.cshtml"
 if (!String.IsNullOrEmpty(Model.Description) && !String.IsNullOrEmpty(Model.Summary))
{

#line default
#line hidden

            WriteLiteral("/// <remarks>\n");
#line 24 "MethodTemplate.cshtml"
Write(WrapComment("/// ", Model.Description.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </remarks>\n");
#line 26 "MethodTemplate.cshtml"
}

#line default
#line hidden

#line 27 "MethodTemplate.cshtml"
 foreach (ParameterCs parameter in Model.LocalParameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 29 "MethodTemplate.cshtml"
              Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\'>\n");
#line 30 "MethodTemplate.cshtml"

#line default
#line hidden

#line 30 "MethodTemplate.cshtml"
Write(WrapComment("/// ", parameter.DocumentationString.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 32 "MethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'customHeaders\'>\n/// Headers that will be added to request.\n/// </param>\n/// <param name=\'cancellationToken\'>\n/// The cancellation token.\n/// </param>\n/// <exception cref=\"");
#line 39 "MethodTemplate.cshtml"
                 Write(Model.OperationExceptionTypeString);

#line default
#line hidden
            WriteLiteral("\">\n/// Thrown when the operation returned an invalid status code\n/// </exception>\n");
#line 42 "MethodTemplate.cshtml"
 if (Model.Responses.Where(r => r.Value.Body != null).Any())
{

#line default
#line hidden

            WriteLiteral("/// <exception cref=\"Microsoft.Rest.SerializationException\">\n/// Thrown when unable to deserialize the response\n/// </exception>\n");
#line 47 "MethodTemplate.cshtml"
}

#line default
#line hidden

#line 48 "MethodTemplate.cshtml"
 if (Model.Parameters.Cast<ParameterCs>().Any(p => !p.IsConstant && p.IsRequired &&p.IsNullable()))
{

#line default
#line hidden

            WriteLiteral("/// <exception cref=\"Microsoft.Rest.ValidationException\">\n/// Thrown when a required parameter is null\n/// </exception>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 56 "MethodTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("/// <return>\n/// A response object containing the response body and response headers.\n/// </return>\n");
#line 60 "MethodTemplate.cshtml"
Write(Model.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n");
#line 61 "MethodTemplate.cshtml"
Write(Model.AccessModifier);

#line default
#line hidden
            WriteLiteral(" async System.Threading.Tasks.Task<");
#line 61 "MethodTemplate.cshtml"
                                                      Write(Model.OperationResponseReturnTypeString);

#line default
#line hidden
            WriteLiteral("> ");
#line 61 "MethodTemplate.cshtml"
                                                                                                  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 61 "MethodTemplate.cshtml"
                                                                                                                                     Write(Model.GetAsyncMethodParameterDeclaration(true));

#line default
#line hidden
            WriteLiteral(")\n{\n");
#line 63 "MethodTemplate.cshtml"
    

#line default
#line hidden

#line 63 "MethodTemplate.cshtml"
     switch (Model.Flavor)
    {
        case MethodFlavor.RestCall:

#line default
#line hidden

            WriteLiteral("    ");
#line 66 "MethodTemplate.cshtml"
  Write(Include(new MethodBodyTemplateRestCall(), Model));

#line default
#line hidden
            WriteLiteral("\n");
#line 67 "MethodTemplate.cshtml"
            break;
        case MethodFlavor.ForwardTo:

#line default
#line hidden

            WriteLiteral("    ");
#line 69 "MethodTemplate.cshtml"
  Write(Include(new MethodBodyTemplateForwardTo(), Model));

#line default
#line hidden
            WriteLiteral("\n");
#line 70 "MethodTemplate.cshtml"
            break;
        case MethodFlavor.Implementation:

#line default
#line hidden

            WriteLiteral("    ");
#line 72 "MethodTemplate.cshtml"
  Write(Model.GetImplementation("csharp") ?? "throw new System.NotImplementedException();");

#line default
#line hidden
            WriteLiteral("\n");
#line 73 "MethodTemplate.cshtml"
            break;
        default:
            throw new System.NotImplementedException();
    }

#line default
#line hidden

            WriteLiteral("}\n");
        }
        #pragma warning restore 1998
    }
}
