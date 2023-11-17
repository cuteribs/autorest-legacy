// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Common
{
#line 1 "ExceptionTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ExceptionTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.CompositeTypeCs>
    {
        #line hidden
        public ExceptionTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 3 "ExceptionTemplate.cshtml"
Write(Header("// "));

#line default
#line hidden
            WriteLiteral("\n");
#line 4 "ExceptionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nnamespace ");
#line 5 "ExceptionTemplate.cshtml"
      Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral(".");
#line 5 "ExceptionTemplate.cshtml"
                            Write(Settings.ModelsName);

#line default
#line hidden
            WriteLiteral("\n{\n");
#line 7 "ExceptionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    /// <summary>\n    ");
#line 9 "ExceptionTemplate.cshtml"
Write(WrapComment("/// ", "Exception thrown for an invalid response with " + Model.Name + " information."));

#line default
#line hidden
            WriteLiteral("\n    /// </summary>\n    ");
#line 11 "ExceptionTemplate.cshtml"
Write(Model.GetObsoleteAttribute());

#line default
#line hidden
            WriteLiteral("\n    public partial class ");
#line 12 "ExceptionTemplate.cshtml"
                    Write(Model.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral(" : Microsoft.Rest.RestException\n    {\n        /// <summary>\n        /// Gets information about the associated HTTP request.\n        /// </summary>\n        public Microsoft.Rest.HttpRequestMessageWrapper Request { get; set; }\n");
#line 18 "ExceptionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        /// Gets information about the associated HTTP response.\n        /// </summary>\n        public Microsoft.Rest.HttpResponseMessageWrapper Response { get; set; }\n");
#line 23 "ExceptionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        /// Gets or sets the body object.\n        /// </summary>\n        public ");
#line 27 "ExceptionTemplate.cshtml"
          Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" Body { get; set; }\n");
#line 28 "ExceptionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        /// Initializes a new instance of the ");
#line 30 "ExceptionTemplate.cshtml"
                                         Write(Model.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral(" class.\n        /// </summary>\n        public ");
#line 32 "ExceptionTemplate.cshtml"
           Write(@Model.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral("()\n        {\n        }\n");
#line 35 "ExceptionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        /// Initializes a new instance of the ");
#line 37 "ExceptionTemplate.cshtml"
                                         Write(Model.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral(" class.\n        /// </summary>\n        /// <param name=\"message\">The exception message.</param>\n        public ");
#line 40 "ExceptionTemplate.cshtml"
           Write(Model.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral("(string message)\n            : this(message, null)\n        {\n        }\n");
#line 44 "ExceptionTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        /// <summary>\n        /// Initializes a new instance of the ");
#line 46 "ExceptionTemplate.cshtml"
                                         Write(Model.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral(" class.\n        /// </summary>\n        /// <param name=\"message\">The exception message.</param>\n        /// <param name=\"innerException\">Inner exception.</param>\n        public ");
#line 50 "ExceptionTemplate.cshtml"
           Write(Model.ExceptionTypeDefinitionName);

#line default
#line hidden
            WriteLiteral("(string message, System.Exception innerException)\n            : base(message, innerException)\n        {\n        }\n    }\n}");
        }
        #pragma warning restore 1998
    }
}
