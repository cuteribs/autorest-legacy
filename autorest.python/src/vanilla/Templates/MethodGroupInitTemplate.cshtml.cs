// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "MethodGroupInitTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
#line 2 "MethodGroupInitTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "MethodGroupInitTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodGroupInitTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public MethodGroupInitTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 7 "MethodGroupInitTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 9 "MethodGroupInitTemplate.cshtml"
  
bool hasClientLevelMethods = Model.MethodTemplateModels.Any( each => each.MethodGroup.IsCodeModelMethodGroup);
string fileSuffix = AsyncMode? "_async" : "";

#line default
#line hidden

#line 13 "MethodGroupInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 14 "MethodGroupInitTemplate.cshtml"
 foreach (var modelGroupType in Model.MethodGroupModels)
    {

#line default
#line hidden

            WriteLiteral("from ._");
#line 16 "MethodGroupInitTemplate.cshtml"
     Write( modelGroupType.TypeName.ToPythonCase());

#line default
#line hidden
#line 16 "MethodGroupInitTemplate.cshtml"
                                               Write(fileSuffix);

#line default
#line hidden
            WriteLiteral(" import ");
#line 16 "MethodGroupInitTemplate.cshtml"
                                                                   Write(modelGroupType.TypeName);

#line default
#line hidden
            WriteLiteral("\n");
#line 17 "MethodGroupInitTemplate.cshtml"
    }

#line default
#line hidden

#line 18 "MethodGroupInitTemplate.cshtml"
 if(hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("from ._");
#line 20 "MethodGroupInitTemplate.cshtml"
     Write(Model.Name.ToPythonCase());

#line default
#line hidden
            WriteLiteral("_operations");
#line 20 "MethodGroupInitTemplate.cshtml"
                                            Write(fileSuffix);

#line default
#line hidden
            WriteLiteral(" import ");
#line 20 "MethodGroupInitTemplate.cshtml"
                                                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin\n");
#line 21 "MethodGroupInitTemplate.cshtml"
}

#line default
#line hidden

#line 22 "MethodGroupInitTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n__all__ = [\n");
#line 24 "MethodGroupInitTemplate.cshtml"
 foreach (var modelGroupType in Model.MethodGroupModels)
    {

#line default
#line hidden

            WriteLiteral("    \'");
#line 26 "MethodGroupInitTemplate.cshtml"
  Write(modelGroupType.TypeName.Value);

#line default
#line hidden
            WriteLiteral("\',\n");
#line 27 "MethodGroupInitTemplate.cshtml"
    }

#line default
#line hidden

#line 28 "MethodGroupInitTemplate.cshtml"
 if(hasClientLevelMethods)
{

#line default
#line hidden

            WriteLiteral("    \'");
#line 30 "MethodGroupInitTemplate.cshtml"
   Write(Model.Name);

#line default
#line hidden
            WriteLiteral("OperationsMixin\',\n");
#line 31 "MethodGroupInitTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("]\n");
        }
        #pragma warning restore 1998
    }
}
