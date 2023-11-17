// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureModelInitTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "AzureModelInitTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "AzureModelInitTemplate.cshtml"
using AutoRest.Extensions.Azure

#line default
#line hidden
    ;
#line 4 "AzureModelInitTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureModelInitTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Azure.Model.CodeModelPya>
    {
        #line hidden
        public AzureModelInitTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 8 "AzureModelInitTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 10 "AzureModelInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\ntry:\n");
#line 12 "AzureModelInitTemplate.cshtml"
 foreach (var modelType in Model.ModelTypes.OrderBy(o => o.ClassName))
  {
    if (modelType.Extensions.ContainsKey(AzureExtensions.ExternalExtension) &&
      (bool)modelType.Extensions[AzureExtensions.ExternalExtension])
    {
      continue;
    }

#line default
#line hidden

            WriteLiteral("    from ._models_py3 import ");
#line 19 "AzureModelInitTemplate.cshtml"
                          Write(modelType.Name);

#line default
#line hidden
#line 19 "AzureModelInitTemplate.cshtml"
                                         Write(Model.GetExceptionNameIfExist(modelType, false));

#line default
#line hidden
            WriteLiteral("\n");
#line 20 "AzureModelInitTemplate.cshtml"
  }

#line default
#line hidden

            WriteLiteral("except (SyntaxError, ImportError):\n");
#line 22 "AzureModelInitTemplate.cshtml"
 foreach (var modelType in Model.ModelTypes.OrderBy(o => o.ClassName))
  {
    if (modelType.Extensions.ContainsKey(AzureExtensions.ExternalExtension) &&
      (bool)modelType.Extensions[AzureExtensions.ExternalExtension])
    {
      continue;
    }

#line default
#line hidden

            WriteLiteral("    from ._models import ");
#line 29 "AzureModelInitTemplate.cshtml"
                      Write(modelType.Name);

#line default
#line hidden
#line 29 "AzureModelInitTemplate.cshtml"
                                     Write(Model.GetExceptionNameIfExist(modelType, false));

#line default
#line hidden
            WriteLiteral("\n");
#line 30 "AzureModelInitTemplate.cshtml"
  }

#line default
#line hidden

#line 31 "AzureModelInitTemplate.cshtml"
 if (Model.EnumTypes.Any())
  {

#line default
#line hidden

            WriteLiteral("from ._");
#line 33 "AzureModelInitTemplate.cshtml"
     Write(Model.Name.ToPythonCase());

#line default
#line hidden
            WriteLiteral("_enums import (\n");
#line 34 "AzureModelInitTemplate.cshtml"
    foreach (var enumType in @Model.EnumTypes)
    {

#line default
#line hidden

            WriteLiteral("    ");
#line 36 "AzureModelInitTemplate.cshtml"
  Write(enumType.Name);

#line default
#line hidden
            WriteLiteral(",\n");
#line 37 "AzureModelInitTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral(")\n");
#line 39 "AzureModelInitTemplate.cshtml"
  }

#line default
#line hidden

#line 40 "AzureModelInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n__all__ = [\n");
#line 42 "AzureModelInitTemplate.cshtml"
 foreach (var modelType in Model.ModelTypes.OrderBy(o => o.ClassName))
  {
    if (modelType.Extensions.ContainsKey(AzureExtensions.ExternalExtension) &&
      (bool)modelType.Extensions[AzureExtensions.ExternalExtension])
    {
      continue;
    }

#line default
#line hidden

            WriteLiteral("    \'");
#line 49 "AzureModelInitTemplate.cshtml"
  Write(modelType.Name);

#line default
#line hidden
            WriteLiteral("\'");
#line 49 "AzureModelInitTemplate.cshtml"
                  Write(Model.GetExceptionNameIfExist(modelType, true));

#line default
#line hidden
            WriteLiteral(",\n");
#line 50 "AzureModelInitTemplate.cshtml"
  }

#line default
#line hidden

#line 51 "AzureModelInitTemplate.cshtml"
 foreach (var enumType in @Model.EnumTypes)
  {

#line default
#line hidden

            WriteLiteral("    \'");
#line 53 "AzureModelInitTemplate.cshtml"
   Write(enumType.Name);

#line default
#line hidden
            WriteLiteral("\',\n");
#line 54 "AzureModelInitTemplate.cshtml"
  }

#line default
#line hidden

            WriteLiteral("]\n");
        }
        #pragma warning restore 1998
    }
}
