// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "ConfigurationTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "ConfigurationTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ConfigurationTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "ConfigurationTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "ConfigurationTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 6 "ConfigurationTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ConfigurationTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public ConfigurationTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 10 "ConfigurationTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 12 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom azure.core.configuration import Configuration\nfrom azure.core.pipeline import policies\n");
#line 15 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom .version import VERSION\n");
#line 17 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 18 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 19 "ConfigurationTemplate.cshtml"
  Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration(Configuration):\n    \"\"\"Configuration for ");
#line 20 "ConfigurationTemplate.cshtml"
                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\n    Note that all parameters used to create this instance are saved as instance\n    attributes.\n");
#line 23 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 24 "ConfigurationTemplate.cshtml"
 foreach(var property in Model.Properties.Where( each => !each.IsConstant))
{

#line default
#line hidden

            WriteLiteral("    ");
#line 26 "ConfigurationTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 27 "ConfigurationTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 28 "ConfigurationTemplate.cshtml"
}

#line default
#line hidden

#line 29 "ConfigurationTemplate.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("    ");
#line 31 "ConfigurationTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, CodeModelPy.GetPropertyDocumentationString(property)));

#line default
#line hidden
            WriteLiteral("\n    ");
#line 32 "ConfigurationTemplate.cshtml"
 Write(ParameterWrapComment(string.Empty, ":type " + property.Name + ": " + Model.GetPropertyDocumentationType(property.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 33 "ConfigurationTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 35 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(self");
#line 36 "ConfigurationTemplate.cshtml"
                 Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", **kwargs):\n");
#line 37 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        ");
#line 38 "ConfigurationTemplate.cshtml"
   Write(Model.ValidateRequiredParameters);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 40 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        super(");
#line 41 "ConfigurationTemplate.cshtml"
          Write(Model.Name);

#line default
#line hidden
            WriteLiteral("Configuration, self).__init__(**kwargs)\n        self._configure(**kwargs)\n");
#line 43 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self.user_agent_policy.add_user_agent(\'azsdk-python-");
#line 44 "ConfigurationTemplate.cshtml"
                                                        Write(Model.UserAgent);

#line default
#line hidden
            WriteLiteral("/{}\'.format(VERSION))\n        self.generate_client_request_id = True\n");
#line 46 "ConfigurationTemplate.cshtml"
 if (Model.Properties.Any() || Model.ConstantProperties.Any())
{
    

#line default
#line hidden

#line 48 "ConfigurationTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 48 "ConfigurationTemplate.cshtml"
              
    foreach (var property in Model.Properties.Where( each => !each.IsConstant))
    {

#line default
#line hidden

            WriteLiteral("        self.");
#line 51 "ConfigurationTemplate.cshtml"
           Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 51 "ConfigurationTemplate.cshtml"
                              Write(property.Name);

#line default
#line hidden
            WriteLiteral("\n");
#line 52 "ConfigurationTemplate.cshtml"
    }
    foreach (var property in Model.ConstantProperties)
    {

#line default
#line hidden

            WriteLiteral("        self.");
#line 55 "ConfigurationTemplate.cshtml"
           Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 55 "ConfigurationTemplate.cshtml"
                              Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 56 "ConfigurationTemplate.cshtml"
    }
}

#line default
#line hidden

#line 58 "ConfigurationTemplate.cshtml"
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
