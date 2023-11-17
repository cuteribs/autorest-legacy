// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "ModelInitTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "ModelInitTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ModelInitTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ModelInitTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public ModelInitTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 7 "ModelInitTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 9 "ModelInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\ntry:\n");
#line 11 "ModelInitTemplate.cshtml"
 foreach (var modelType in Model.ModelTypes.OrderBy(o => o.ClassName))
  {

#line default
#line hidden

            WriteLiteral("    from ._models_py3 import ");
#line 13 "ModelInitTemplate.cshtml"
                          Write(modelType.Name);

#line default
#line hidden
#line 13 "ModelInitTemplate.cshtml"
                                         Write(Model.GetExceptionNameIfExist(modelType, false));

#line default
#line hidden
            WriteLiteral("\n");
#line 14 "ModelInitTemplate.cshtml"
  }

#line default
#line hidden

            WriteLiteral("except (SyntaxError, ImportError):\n");
#line 16 "ModelInitTemplate.cshtml"
 foreach (var modelType in Model.ModelTypes.OrderBy(o => o.ClassName))
  {

#line default
#line hidden

            WriteLiteral("    from ._models import ");
#line 18 "ModelInitTemplate.cshtml"
                      Write(modelType.Name);

#line default
#line hidden
#line 18 "ModelInitTemplate.cshtml"
                                     Write(Model.GetExceptionNameIfExist(modelType, false));

#line default
#line hidden
            WriteLiteral("\n");
#line 19 "ModelInitTemplate.cshtml"
  }

#line default
#line hidden

#line 20 "ModelInitTemplate.cshtml"
 if (Model.EnumTypes.Any())
  {

#line default
#line hidden

            WriteLiteral("from ._");
#line 22 "ModelInitTemplate.cshtml"
     Write(Model.Name.ToPythonCase());

#line default
#line hidden
            WriteLiteral("_enums import (\n");
#line 23 "ModelInitTemplate.cshtml"
  foreach (var enumType in @Model.EnumTypes.OrderBy(o => o.ClassName))
    {

#line default
#line hidden

            WriteLiteral("    ");
#line 25 "ModelInitTemplate.cshtml"
  Write(enumType.Name);

#line default
#line hidden
            WriteLiteral(",\n");
#line 26 "ModelInitTemplate.cshtml"
    }

#line default
#line hidden

            WriteLiteral(")\n");
#line 28 "ModelInitTemplate.cshtml"
  }

#line default
#line hidden

#line 29 "ModelInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n__all__ = [\n");
#line 31 "ModelInitTemplate.cshtml"
 foreach (var modelType in Model.ModelTypes.OrderBy(o => o.ClassName))
  {

#line default
#line hidden

            WriteLiteral("    \'");
#line 33 "ModelInitTemplate.cshtml"
  Write(modelType.Name);

#line default
#line hidden
            WriteLiteral("\'");
#line 33 "ModelInitTemplate.cshtml"
                  Write(Model.GetExceptionNameIfExist(modelType, true));

#line default
#line hidden
            WriteLiteral(",\n");
#line 34 "ModelInitTemplate.cshtml"
  }

#line default
#line hidden

#line 35 "ModelInitTemplate.cshtml"
 foreach (var enumType in @Model.EnumTypes)
  {

#line default
#line hidden

            WriteLiteral("    \'");
#line 37 "ModelInitTemplate.cshtml"
   Write(enumType.Name);

#line default
#line hidden
            WriteLiteral("\',\n");
#line 38 "ModelInitTemplate.cshtml"
  }

#line default
#line hidden

            WriteLiteral("]\n");
        }
        #pragma warning restore 1998
    }
}
