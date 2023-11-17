// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "MethodGroupTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "MethodGroupTemplate.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "MethodGroupTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodGroupTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.MethodGroupPy>
    {
        #line hidden
        public MethodGroupTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 7 "MethodGroupTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 9 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 10 "MethodGroupTemplate.cshtml"
 if (Model.AddTracingDecorators)
{

#line default
#line hidden

            WriteLiteral("from azure.core.tracing.decorator import distributed_trace\n");
#line 13 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 14 "MethodGroupTemplate.cshtml"
 if (Model.HasAnyDeprecated)
{

#line default
#line hidden

            WriteLiteral("import warnings\n");
#line 17 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 18 "MethodGroupTemplate.cshtml"
 if (Model.HasAnyDefaultExceptions)
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import HttpResponseError, map_error\n");
#line 21 "MethodGroupTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("from azure.core.exceptions import map_error\n");
#line 25 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 26 "MethodGroupTemplate.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

#line 28 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 28 "MethodGroupTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("from .. import models\n");
#line 30 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 31 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 32 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nclass ");
#line 33 "MethodGroupTemplate.cshtml"
  Write((string) Model.TypeName);

#line default
#line hidden
            WriteLiteral("(object):\n    \"\"\"");
#line 34 "MethodGroupTemplate.cshtml"
   Write((string) Model.TypeName);

#line default
#line hidden
            WriteLiteral(" operations.\n");
#line 35 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    You should not instantiate directly this class, but create a Client instance that will create it for you and attach it as attribute.\n");
#line 37 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    :param client: Client for service requests.\n    :param config: Configuration of service client.\n    :param serializer: An object model serializer.\n    :param deserializer: An object model deserializer.\n");
#line 42 "MethodGroupTemplate.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("    ");
#line 44 "MethodGroupTemplate.cshtml"
 Write(Model.GetPropertyDocumentationString(property));

#line default
#line hidden
            WriteLiteral("\n");
#line 45 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    \"\"\"\n");
#line 47 "MethodGroupTemplate.cshtml"
 if (Model.HasAnyModel)
{

#line default
#line hidden

#line 49 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 49 "MethodGroupTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("    models = models\n");
#line 51 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 52 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    def __init__(self, client, config, serializer, deserializer):\n");
#line 54 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self._client = client\n        self._serialize = serializer\n        self._deserialize = deserializer\n");
#line 58 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        self._config = config\n");
#line 60 "MethodGroupTemplate.cshtml"
 foreach(var property in Model.ConstantProperties)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 62 "MethodGroupTemplate.cshtml"
     Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 62 "MethodGroupTemplate.cshtml"
                      Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 63 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

#line 64 "MethodGroupTemplate.cshtml"
 foreach (var method in Model.MethodTemplateModels)
{

#line default
#line hidden

#line 66 "MethodGroupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 66 "MethodGroupTemplate.cshtml"
          

#line default
#line hidden

#line 67 "MethodGroupTemplate.cshtml"
Write(Include(new MethodTemplate() {AsyncMode = AsyncMode, Python3Mode = Python3Mode}, method));

#line default
#line hidden
            WriteLiteral("\n");
#line 68 "MethodGroupTemplate.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
