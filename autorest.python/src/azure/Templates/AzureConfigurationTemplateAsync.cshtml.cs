// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureConfigurationTemplateAsync.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureConfigurationTemplateAsync.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "AzureConfigurationTemplateAsync.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "AzureConfigurationTemplateAsync.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "AzureConfigurationTemplateAsync.cshtml"
using AutoRest.Extensions.Azure

#line default
#line hidden
    ;
#line 6 "AzureConfigurationTemplateAsync.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 7 "AzureConfigurationTemplateAsync.cshtml"
using AutoRest.Python.Azure.Model

#line default
#line hidden
    ;
#line 8 "AzureConfigurationTemplateAsync.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
#line 9 "AzureConfigurationTemplateAsync.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureConfigurationTemplateAsync : AutoRest.Python.PythonTemplate<CodeModelPya>
    {
        #line hidden
        public AzureConfigurationTemplateAsync()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 13 "AzureConfigurationTemplateAsync.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\nfrom azure.core.configuration import Configuration\nfrom azure.core.pipeline import policies\n");
#line 17 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom ..version import VERSION\n");
#line 19 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 20 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 21 "AzureConfigurationTemplateAsync.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration(Configuration):\n    \"\"\"Configuration for ");
#line 22 "AzureConfigurationTemplateAsync.cshtml"
                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\n    Note that all parameters used to create this instance are saved as instance\n    attributes.\n");
#line 25 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 26 "AzureConfigurationTemplateAsync.cshtml"
 foreach(var property in Model.Properties.Where(each => !each.IsConstant))
{

#line default
#line hidden

            WriteLiteral("    ");
#line 28 "AzureConfigurationTemplateAsync.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 29 "AzureConfigurationTemplateAsync.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 30 "AzureConfigurationTemplateAsync.cshtml"
}

#line default
#line hidden

#line 31 "AzureConfigurationTemplateAsync.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("    ");
#line 33 "AzureConfigurationTemplateAsync.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 34 "AzureConfigurationTemplateAsync.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 35 "AzureConfigurationTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 37 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(self");
#line 38 "AzureConfigurationTemplateAsync.cshtml"
                 Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", **kwargs):\n");
#line 39 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        ");
#line 40 "AzureConfigurationTemplateAsync.cshtml"
   Write(Model.ValidateRequiredParameters);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 42 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        super(");
#line 43 "AzureConfigurationTemplateAsync.cshtml"
          Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration, self).__init__(**kwargs)\n        self._configure(**kwargs)\n");
#line 45 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self.user_agent_policy.add_user_agent(\'azsdk-python-");
#line 46 "AzureConfigurationTemplateAsync.cshtml"
                                                        Write(Model.UserAgent);

#line default
#line hidden
            WriteLiteral("/{}\'.format(VERSION))\n        self.generate_client_request_id = True\n");
#line 48 "AzureConfigurationTemplateAsync.cshtml"
 if (Model.Properties.Any())
{

#line default
#line hidden

#line 50 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 50 "AzureConfigurationTemplateAsync.cshtml"
          
  foreach (var property in Model.Properties.Where(each => !each.IsConstant))
  {

#line default
#line hidden

            WriteLiteral("        self.");
#line 53 "AzureConfigurationTemplateAsync.cshtml"
           Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 53 "AzureConfigurationTemplateAsync.cshtml"
                              Write(property.Name);

#line default
#line hidden
            WriteLiteral("\n");
#line 54 "AzureConfigurationTemplateAsync.cshtml"
  }
  foreach (var property in Model.ConstantProperties)
  {

#line default
#line hidden

            WriteLiteral("        self.");
#line 57 "AzureConfigurationTemplateAsync.cshtml"
           Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 57 "AzureConfigurationTemplateAsync.cshtml"
                              Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 58 "AzureConfigurationTemplateAsync.cshtml"
  }
}

#line default
#line hidden

#line 60 "AzureConfigurationTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral(@"
    def _configure(self, **kwargs):
        self.user_agent_policy = kwargs.get('user_agent_policy') or policies.UserAgentPolicy(**kwargs)
        self.headers_policy = kwargs.get('headers_policy') or policies.HeadersPolicy(**kwargs)
        self.proxy_policy = kwargs.get('proxy_policy') or policies.ProxyPolicy(**kwargs)
        self.logging_policy = kwargs.get('logging_policy') or policies.NetworkTraceLoggingPolicy(**kwargs)
        self.retry_policy = kwargs.get('retry_policy') or policies.AsyncRetryPolicy(**kwargs)
        self.custom_hook_policy = kwargs.get('custom_hook_policy') or policies.CustomHookPolicy(**kwargs)
        self.redirect_policy = kwargs.get('redirect_policy') or policies.AsyncRedirectPolicy(**kwargs)
");
        }
        #pragma warning restore 1998
    }
}
