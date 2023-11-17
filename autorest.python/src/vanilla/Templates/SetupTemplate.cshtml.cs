// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "SetupTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "SetupTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class SetupTemplate : AutoRest.Core.Template<AutoRest.Python.Model.CodeModelPy>
    {
        #line hidden
        public SetupTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("# coding=utf-8\n# --------------------------------------------------------------------------\n");
#line 6 "SetupTemplate.cshtml"
Write(Header("# ").TrimMultilineHeader());

#line default
#line hidden
            WriteLiteral("\n# --------------------------------------------------------------------------\n# coding: utf-8\n");
#line 9 "SetupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nfrom setuptools import setup, find_packages\n");
#line 11 "SetupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nNAME = \"");
#line 12 "SetupTemplate.cshtml"
   Write(Model.PackageName);

#line default
#line hidden
            WriteLiteral("\"\nVERSION = \"");
#line 13 "SetupTemplate.cshtml"
      Write(Model.Version);

#line default
#line hidden
            WriteLiteral("\"\n");
#line 14 "SetupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n# To install the library, run the following\n#\n# python setup.py install\n#\n# prerequisite: setuptools\n# http://pypi.python.org/pypi/setuptools\n");
#line 21 "SetupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nREQUIRES = [");
#line 22 "SetupTemplate.cshtml"
       Write(Model.SetupRequires);

#line default
#line hidden
            WriteLiteral("]\n");
#line 23 "SetupTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nsetup(\n    name=NAME,\n    version=VERSION,\n    description=\"");
#line 27 "SetupTemplate.cshtml"
             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\",\n    author_email=\"\",\n    url=\"\",\n    keywords=[\"Swagger\", \"");
#line 30 "SetupTemplate.cshtml"
                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\"],\n    install_requires=REQUIRES,\n    packages=find_packages(),\n    include_package_data=True,\n    long_description=\"\"\"\\\n    ");
#line 35 "SetupTemplate.cshtml"
Write(Model.Documentation);

#line default
#line hidden
            WriteLiteral("\n    \"\"\"\n)\n");
        }
        #pragma warning restore 1998
    }
}
