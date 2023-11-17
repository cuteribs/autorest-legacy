// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureConfigurationTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureConfigurationTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "AzureConfigurationTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "AzureConfigurationTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "AzureConfigurationTemplate.cshtml"
using AutoRest.Extensions.Azure

#line default
#line hidden
    ;
#line 6 "AzureConfigurationTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 7 "AzureConfigurationTemplate.cshtml"
using AutoRest.Python.Azure.Model

#line default
#line hidden
    ;
#line 8 "AzureConfigurationTemplate.cshtml"
using AutoRest.Python.azure.Templates

#line default
#line hidden
    ;
#line 9 "AzureConfigurationTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureConfigurationTemplate : AutoRest.Python.PythonTemplate<CodeModelPya>
    {
        #line hidden
        public AzureConfigurationTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 13 "AzureConfigurationTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\nfrom azure.core.configuration import Configuration\nfrom azure.core.pipeline import policies\n");
#line 17 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom .version import VERSION\n");
#line 19 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 20 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 21 "AzureConfigurationTemplate.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration(Configuration):\n    \"\"\"Configuration for ");
#line 22 "AzureConfigurationTemplate.cshtml"
                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\n    Note that all parameters used to create this instance are saved as instance\n    attributes.\n");
#line 25 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 26 "AzureConfigurationTemplate.cshtml"
 foreach(var property in Model.Properties.Where(each => !each.IsConstant))
{

#line default
#line hidden

            WriteLiteral("    ");
#line 28 "AzureConfigurationTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 29 "AzureConfigurationTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 30 "AzureConfigurationTemplate.cshtml"
}

#line default
#line hidden

#line 31 "AzureConfigurationTemplate.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("    ");
#line 33 "AzureConfigurationTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 34 "AzureConfigurationTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 35 "AzureConfigurationTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 37 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(self");
#line 38 "AzureConfigurationTemplate.cshtml"
                 Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", **kwargs):\n");
#line 39 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        ");
#line 40 "AzureConfigurationTemplate.cshtml"
   Write(Model.ValidateRequiredParameters);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 42 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        super(");
#line 43 "AzureConfigurationTemplate.cshtml"
          Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration, self).__init__(**kwargs)\n        self._configure(**kwargs)\n");
#line 45 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self.user_agent_policy.add_user_agent(\'azsdk-python-");
#line 46 "AzureConfigurationTemplate.cshtml"
                                                        Write(Model.UserAgent);

#line default
#line hidden
            WriteLiteral("/{}\'.format(VERSION))\n        self.generate_client_request_id = True\n");
#line 48 "AzureConfigurationTemplate.cshtml"
 if (Model.Properties.Any())
{

#line default
#line hidden

#line 50 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 50 "AzureConfigurationTemplate.cshtml"
          
  foreach (var property in Model.Properties.Where(each => !each.IsConstant))
  {

#line default
#line hidden

            WriteLiteral("        self.");
#line 53 "AzureConfigurationTemplate.cshtml"
           Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 53 "AzureConfigurationTemplate.cshtml"
                              Write(property.Name);

#line default
#line hidden
            WriteLiteral("\n");
#line 54 "AzureConfigurationTemplate.cshtml"
  }
  foreach (var property in Model.ConstantProperties)
  {

#line default
#line hidden

            WriteLiteral("        self.");
#line 57 "AzureConfigurationTemplate.cshtml"
           Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 57 "AzureConfigurationTemplate.cshtml"
                              Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 58 "AzureConfigurationTemplate.cshtml"
  }
}

#line default
#line hidden

#line 60 "AzureConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral(@"
    def _configure(self, **kwargs):
        self.user_agent_policy = kwargs.get('user_agent_policy') or policies.UserAgentPolicy(**kwargs)
        self.headers_policy = kwargs.get('headers_policy') or policies.HeadersPolicy(**kwargs)
        self.proxy_policy = kwargs.get('proxy_policy') or policies.ProxyPolicy(**kwargs)
        self.logging_policy = kwargs.get('logging_policy') or policies.NetworkTraceLoggingPolicy(**kwargs)
        self.retry_policy = kwargs.get('retry_policy') or policies.RetryPolicy(**kwargs)
        self.custom_hook_policy = kwargs.get('custom_hook_policy') or policies.CustomHookPolicy(**kwargs)
        self.redirect_policy = kwargs.get('redirect_policy') or policies.RedirectPolicy(**kwargs)
");
        }
        #pragma warning restore 1998
    }
}
