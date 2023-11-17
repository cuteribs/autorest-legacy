// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
#line 1 "LicenseTemplate.cshtml"
using System

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class LicenseTemplate : AutoRest.Core.Template<AutoRest.TypeScript.Model.CodeModelTS>
    {
        #line hidden
        public LicenseTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("The MIT License (MIT)\n");
#line 4 "LicenseTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nCopyright (c) ");
#line 5 "LicenseTemplate.cshtml"
          Write(DateTime.UtcNow.Year);

#line default
#line hidden
            WriteLiteral(" Microsoft\n");
#line 6 "LicenseTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral(@"
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
");
#line 13 "LicenseTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nThe above copyright notice and this permission notice shall be included in all\ncopies or substantial portions of the Software.\n");
#line 16 "LicenseTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral(@"
THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.");
        }
        #pragma warning restore 1998
    }
}
