// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "MethodGroupTemplateAsync.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "MethodGroupTemplateAsync.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "MethodGroupTemplateAsync.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodGroupTemplateAsync : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.MethodGroupPy>
    {
        #line hidden
        public MethodGroupTemplateAsync()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 7 "MethodGroupTemplateAsync.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 9 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 10 "MethodGroupTemplateAsync.cshtml"
 if (Model.AddTracingDecorators)
{

#line default
#line hidden

            WriteLiteral("from azure.core.tracing.decorator import distributed_trace\nfrom azure.core.tracing.decorator_async import distributed_trace_async\n");
#line 14 "MethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 15 "MethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 18 "MethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 19 "MethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyDefaultExceptions)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 22 "MethodGroupTemplateAsync.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 26 "MethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 27 "MethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

#line 29 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 29 "MethodGroupTemplateAsync.cshtml"
          

#line default
#line hidden

            WriteLiteral("from ... import models\n");
#line 31 "MethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 32 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 33 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 34 "MethodGroupTemplateAsync.cshtml"
  Write((string) Model.TypeName);

#line default
#line hidden
            WriteLiteral(":\n    \"\"\"");
#line 35 "MethodGroupTemplateAsync.cshtml"
   Write((string) Model.TypeName);

#line default
#line hidden
            WriteLiteral(" async operations.\n");
#line 36 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    You should not instantiate directly this class, but create a Client instance that will create it for you and attach it as attribute.\n");
#line 38 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    :param client: Client for service requests.\n    :param config: Configuration of service client.\n    :param serializer: An object model serializer.\n    :param deserializer: An object model deserializer.\n");
#line 43 "MethodGroupTemplateAsync.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("    ");
#line 45 "MethodGroupTemplateAsync.cshtml"
 Write(Model.GetPropertyDocumentationString(property));

#line default
#line hidden
            WriteLiteral("\n");
#line 46 "MethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 48 "MethodGroupTemplateAsync.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

#line 50 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 50 "MethodGroupTemplateAsync.cshtml"
          

#line default
#line hidden

            WriteLiteral("    models = models\n");
#line 52 "MethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 53 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(self, client, config, serializer, deserializer) -> None:\n");
#line 55 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self._client = client\n        self._serialize = serializer\n        self._deserialize = deserializer\n");
#line 59 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self._config = config\n");
#line 61 "MethodGroupTemplateAsync.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 63 "MethodGroupTemplateAsync.cshtml"
     Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 63 "MethodGroupTemplateAsync.cshtml"
                      Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 64 "MethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

#line 65 "MethodGroupTemplateAsync.cshtml"
 foreach (var method in Model.MethodTemplateModels)
{

#line default
#line hidden

#line 67 "MethodGroupTemplateAsync.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 67 "MethodGroupTemplateAsync.cshtml"
          

#line default
#line hidden

#line 68 "MethodGroupTemplateAsync.cshtml"
Write(Include(new MethodTemplate() {AsyncMode = true, Python3Mode = true}, method));

#line default
#line hidden
            WriteLiteral("\n");
#line 69 "MethodGroupTemplateAsync.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
