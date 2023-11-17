// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "EnumTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "EnumTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class EnumTemplate : AutoRest.Core.Template<System.Collections.Generic.IEnumerable<AutoRest.Core.Model.EnumType>>
    {
        #line hidden
        public EnumTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 6 "EnumTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n");
#line 8 "EnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom enum import Enum\n");
#line 10 "EnumTemplate.cshtml"
  
  foreach (var enumType in @Model)
  {

#line default
#line hidden

#line 13 "EnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 13 "EnumTemplate.cshtml"
          

#line default
#line hidden

#line 14 "EnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 14 "EnumTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("class ");
#line 15 "EnumTemplate.cshtml"
    Write(enumType.Name);

#line default
#line hidden
            WriteLiteral("(str, Enum):\n");
#line 16 "EnumTemplate.cshtml"

#line default
#line hidden

#line 16 "EnumTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 16 "EnumTemplate.cshtml"
          
    for (int i = 0; i < enumType.Values.Count; i++)
    {
      var enum_value = enumType.Values[i];
      string doc = string.IsNullOrEmpty(enum_value.Description) ? "" : "  #: "+enum_value.Description.Replace("\r", " ").Replace("\n", " ");

#line default
#line hidden

            WriteLiteral("    ");
#line 21 "EnumTemplate.cshtml"
  Write(enum_value.MemberName);

#line default
#line hidden
            WriteLiteral(" = \"");
#line 21 "EnumTemplate.cshtml"
                             Write(enum_value.SerializedName);

#line default
#line hidden
            WriteLiteral("\"");
#line 21 "EnumTemplate.cshtml"
                                                        Write(doc);

#line default
#line hidden
            WriteLiteral("\n");
#line 22 "EnumTemplate.cshtml"
    }
  }

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
