// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Common
{
#line 1 "ExtensionMethodTemplate.cshtml"
using System.Text

#line default
#line hidden
    ;
#line 2 "ExtensionMethodTemplate.cshtml"
using System

#line default
#line hidden
    ;
#line 3 "ExtensionMethodTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "ExtensionMethodTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "ExtensionMethodTemplate.cshtml"
using AutoRest.CSharp

#line default
#line hidden
    ;
#line 6 "ExtensionMethodTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ExtensionMethodTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodCs>
    {
        #line hidden
        public ExtensionMethodTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 8 "ExtensionMethodTemplate.cshtml"
  
if (Model.SyncMethods == SyncMethodsGenerationMode.All || Model.SyncMethods == SyncMethodsGenerationMode.Essential)
{
    if (!String.IsNullOrEmpty(Model.Description) || !String.IsNullOrEmpty(Model.Summary))
    {

#line default
#line hidden

            WriteLiteral("/// <summary>\n");
#line 14 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", String.IsNullOrEmpty(Model.Summary) ? Model.Description.EscapeXmlComment() : Model.Summary.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n");
#line 15 "ExtensionMethodTemplate.cshtml"
        if (!String.IsNullOrEmpty(Model.ExternalDocsUrl))
        {

#line default
#line hidden

            WriteLiteral("/// <see href=\"");
#line 17 "ExtensionMethodTemplate.cshtml"
            Write(Model.ExternalDocsUrl);

#line default
#line hidden
            WriteLiteral("\" />\n");
#line 18 "ExtensionMethodTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("/// </summary>\n");
#line 20 "ExtensionMethodTemplate.cshtml"
    }
    if (!String.IsNullOrEmpty(Model.Description) && !String.IsNullOrEmpty(Model.Summary))
    {

#line default
#line hidden

            WriteLiteral("/// <remarks>\n");
#line 24 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", Model.Description.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </remarks>\n");
#line 26 "ExtensionMethodTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("/// <param name=\'operations\'>\n/// The operations group for this extension method.\n/// </param>\n");
#line 30 "ExtensionMethodTemplate.cshtml"
    foreach (ParameterCs parameter in Model.LocalParameters)
    {

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 32 "ExtensionMethodTemplate.cshtml"
              Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\'>\n");
#line 33 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", parameter.DocumentationString.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 35 "ExtensionMethodTemplate.cshtml"
    }

#line default
#line hidden

#line 36 "ExtensionMethodTemplate.cshtml"
Write(Model.GetObsoleteAttribute());

#line default
#line hidden
#line 36 "ExtensionMethodTemplate.cshtml"
                               

#line default
#line hidden

#line 37 "ExtensionMethodTemplate.cshtml"
Write((Model as MethodCs).AccessModifier);

#line default
#line hidden
            WriteLiteral(" static ");
#line 37 "ExtensionMethodTemplate.cshtml"
                                          Write(Model.ReturnTypeString);

#line default
#line hidden
            WriteLiteral(" ");
#line 37 "ExtensionMethodTemplate.cshtml"
                                                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 37 "ExtensionMethodTemplate.cshtml"
                                                                                Write(Model.GetExtensionParameters(Model.GetSyncMethodParameterDeclaration(false)));

#line default
#line hidden
            WriteLiteral(")\n{\n");
#line 39 "ExtensionMethodTemplate.cshtml"
    if (Model.ReturnType.Body != null)
    {

#line default
#line hidden

            WriteLiteral("    return ((I");
#line 41 "ExtensionMethodTemplate.cshtml"
            Write(Model.MethodGroup.TypeName);

#line default
#line hidden
            WriteLiteral(")operations).");
#line 41 "ExtensionMethodTemplate.cshtml"
                                                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Async(");
#line 41 "ExtensionMethodTemplate.cshtml"
                                                                         Write(Model.SyncMethodInvocationArgs);

#line default
#line hidden
            WriteLiteral(").GetAwaiter().GetResult();\n");
#line 42 "ExtensionMethodTemplate.cshtml"
    }
    else if (Model.ReturnType.Headers != null)
    {

#line default
#line hidden

            WriteLiteral("    return ((I");
#line 45 "ExtensionMethodTemplate.cshtml"
            Write(Model.MethodGroup.TypeName);

#line default
#line hidden
            WriteLiteral(")operations).");
#line 45 "ExtensionMethodTemplate.cshtml"
                                                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Async(");
#line 45 "ExtensionMethodTemplate.cshtml"
                                                                         Write(Model.SyncMethodInvocationArgs);

#line default
#line hidden
            WriteLiteral(").GetAwaiter().GetResult();\n");
#line 46 "ExtensionMethodTemplate.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("    ((I");
#line 49 "ExtensionMethodTemplate.cshtml"
     Write(Model.MethodGroup.TypeName);

#line default
#line hidden
            WriteLiteral(")operations).");
#line 49 "ExtensionMethodTemplate.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Async(");
#line 49 "ExtensionMethodTemplate.cshtml"
                                                                  Write(Model.SyncMethodInvocationArgs);

#line default
#line hidden
            WriteLiteral(").GetAwaiter().GetResult();\n");
#line 50 "ExtensionMethodTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("}\n");
#line 52 "ExtensionMethodTemplate.cshtml"

#line default
#line hidden

#line 52 "ExtensionMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 52 "ExtensionMethodTemplate.cshtml"
          
}

if (!String.IsNullOrEmpty(Model.Description) || !String.IsNullOrEmpty(Model.Summary))
{

#line default
#line hidden

            WriteLiteral("/// <summary>\n");
#line 58 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", String.IsNullOrEmpty(Model.Summary) ? Model.Description.EscapeXmlComment() : Model.Summary.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n");
#line 59 "ExtensionMethodTemplate.cshtml"
    if (!String.IsNullOrEmpty(Model.ExternalDocsUrl))
    {

#line default
#line hidden

            WriteLiteral("/// <see href=\"");
#line 61 "ExtensionMethodTemplate.cshtml"
            Write(Model.ExternalDocsUrl);

#line default
#line hidden
            WriteLiteral("\" />\n");
#line 62 "ExtensionMethodTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("/// </summary>\n");
#line 64 "ExtensionMethodTemplate.cshtml"
}
if (!String.IsNullOrEmpty(Model.Description) && !String.IsNullOrEmpty(Model.Summary))
{

#line default
#line hidden

            WriteLiteral("/// <remarks>\n");
#line 68 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", Model.Description.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </remarks>\n");
#line 70 "ExtensionMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'operations\'>\n/// The operations group for this extension method.\n/// </param>\n");
#line 74 "ExtensionMethodTemplate.cshtml"
foreach (ParameterCs parameter in Model.LocalParameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 76 "ExtensionMethodTemplate.cshtml"
              Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\'>\n");
#line 77 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", parameter.DocumentationString.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 79 "ExtensionMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'cancellationToken\'>\n/// The cancellation token.\n/// </param>\n");
#line 83 "ExtensionMethodTemplate.cshtml"

#line default
#line hidden

#line 83 "ExtensionMethodTemplate.cshtml"
Write(Model.GetObsoleteAttribute());

#line default
#line hidden
#line 83 "ExtensionMethodTemplate.cshtml"
                               

#line default
#line hidden

#line 84 "ExtensionMethodTemplate.cshtml"
Write((Model as MethodCs).AccessModifier);

#line default
#line hidden
            WriteLiteral(" static async ");
#line 84 "ExtensionMethodTemplate.cshtml"
                                                Write(Model.TaskExtensionReturnTypeString);

#line default
#line hidden
            WriteLiteral(" ");
#line 84 "ExtensionMethodTemplate.cshtml"
                                                                                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Async(");
#line 84 "ExtensionMethodTemplate.cshtml"
                                                                                                        Write(Model.GetExtensionParameters(Model.GetAsyncMethodParameterDeclaration()));

#line default
#line hidden
            WriteLiteral(")\n{\n");
#line 86 "ExtensionMethodTemplate.cshtml"
    if (Model.ReturnType.Body != null)
    {
        if (Model.ReturnType.Body.IsPrimaryType(KnownPrimaryType.Stream))
        {

#line default
#line hidden

            WriteLiteral("    var _result = await operations.");
#line 90 "ExtensionMethodTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 90 "ExtensionMethodTemplate.cshtml"
                                                                    Write(Model.GetAsyncMethodInvocationArgs("null"));

#line default
#line hidden
            WriteLiteral(").ConfigureAwait(false);\n    _result.Request.Dispose();\n    return _result.Body;\n");
#line 93 "ExtensionMethodTemplate.cshtml"
        }
        else
        {

#line default
#line hidden

            WriteLiteral("    using (var _result = await operations.");
#line 96 "ExtensionMethodTemplate.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 96 "ExtensionMethodTemplate.cshtml"
                                                                           Write(Model.GetAsyncMethodInvocationArgs("null"));

#line default
#line hidden
            WriteLiteral(").ConfigureAwait(false))\n    {\n        return _result.Body;\n    }\n");
#line 100 "ExtensionMethodTemplate.cshtml"
        }
    }
    else if (Model.ReturnType.Headers != null)
    {

#line default
#line hidden

            WriteLiteral("    using (var _result = await operations.");
#line 104 "ExtensionMethodTemplate.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 104 "ExtensionMethodTemplate.cshtml"
                                                                           Write(Model.GetAsyncMethodInvocationArgs("null"));

#line default
#line hidden
            WriteLiteral(").ConfigureAwait(false))\n    {\n        return _result.Headers;\n    }\n");
#line 108 "ExtensionMethodTemplate.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("    (await operations.");
#line 111 "ExtensionMethodTemplate.cshtml"
                    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 111 "ExtensionMethodTemplate.cshtml"
                                                       Write(Model.GetAsyncMethodInvocationArgs("null"));

#line default
#line hidden
            WriteLiteral(").ConfigureAwait(false)).Dispose();\n");
#line 112 "ExtensionMethodTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("}\n");
#line 114 "ExtensionMethodTemplate.cshtml"

    if (Model.SyncMethods == SyncMethodsGenerationMode.All)
    {

#line default
#line hidden

#line 117 "ExtensionMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 117 "ExtensionMethodTemplate.cshtml"
          
    if (!String.IsNullOrEmpty(Model.Description) || !String.IsNullOrEmpty(Model.Summary))
    {

#line default
#line hidden

            WriteLiteral("/// <summary>\n");
#line 121 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", String.IsNullOrEmpty(Model.Summary) ? Model.Description.EscapeXmlComment() : Model.Summary.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n");
#line 122 "ExtensionMethodTemplate.cshtml"
        if (!String.IsNullOrEmpty(Model.ExternalDocsUrl))
        {

#line default
#line hidden

            WriteLiteral("/// <see href=\"");
#line 124 "ExtensionMethodTemplate.cshtml"
            Write(Model.ExternalDocsUrl);

#line default
#line hidden
            WriteLiteral("\" />\n");
#line 125 "ExtensionMethodTemplate.cshtml"
        }

#line default
#line hidden

            WriteLiteral("/// </summary>\n");
#line 127 "ExtensionMethodTemplate.cshtml"
    }
    if (!String.IsNullOrEmpty(Model.Description) && !String.IsNullOrEmpty(Model.Summary))
    {

#line default
#line hidden

            WriteLiteral("/// <remarks>\n");
#line 131 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", Model.Description.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </remarks>\n");
#line 133 "ExtensionMethodTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("/// <param name=\'operations\'>\n/// The operations group for this extension method.\n/// </param>\n");
#line 137 "ExtensionMethodTemplate.cshtml"
    foreach (ParameterCs parameter in Model.LocalParameters)
    {

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 139 "ExtensionMethodTemplate.cshtml"
              Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\'>\n");
#line 140 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", parameter.DocumentationString.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 142 "ExtensionMethodTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral("/// <param name=\'customHeaders\'>\n/// Headers that will be added to request.\n/// </param>\n");
#line 146 "ExtensionMethodTemplate.cshtml"

#line default
#line hidden

#line 146 "ExtensionMethodTemplate.cshtml"
Write(Model.GetObsoleteAttribute());

#line default
#line hidden
#line 146 "ExtensionMethodTemplate.cshtml"
                               

#line default
#line hidden

#line 147 "ExtensionMethodTemplate.cshtml"
Write((Model as MethodCs).AccessModifier);

#line default
#line hidden
            WriteLiteral(" static ");
#line 147 "ExtensionMethodTemplate.cshtml"
                                          Write(Model.OperationResponseReturnTypeString);

#line default
#line hidden
            WriteLiteral(" ");
#line 147 "ExtensionMethodTemplate.cshtml"
                                                                                    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessages(");
#line 147 "ExtensionMethodTemplate.cshtml"
                                                                                                                 Write(Model.GetExtensionParameters(Model.GetSyncMethodParameterDeclaration(true)));

#line default
#line hidden
            WriteLiteral(")\n{\n    return operations.");
#line 149 "ExtensionMethodTemplate.cshtml"
                    Write(Model.Name);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 149 "ExtensionMethodTemplate.cshtml"
                                                       Write(Model.GetAsyncMethodInvocationArgs("customHeaders", "System.Threading.CancellationToken.None"));

#line default
#line hidden
            WriteLiteral(").ConfigureAwait(false).GetAwaiter().GetResult();\n}\n\n");
#line 152 "ExtensionMethodTemplate.cshtml"
    }

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
