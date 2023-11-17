// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "MethodBodyTemplateForwardTo.cshtml"
using System.Linq;

#line default
#line hidden
#line 2 "MethodBodyTemplateForwardTo.cshtml"
using System.Collections.Generic

#line default
#line hidden
    ;
#line 3 "MethodBodyTemplateForwardTo.cshtml"
using System

#line default
#line hidden
    ;
#line 4 "MethodBodyTemplateForwardTo.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 5 "MethodBodyTemplateForwardTo.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 6 "MethodBodyTemplateForwardTo.cshtml"
using AutoRest.CSharp

#line default
#line hidden
    ;
#line 7 "MethodBodyTemplateForwardTo.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
#line 8 "MethodBodyTemplateForwardTo.cshtml"
using AutoRest.Extensions

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodBodyTemplateForwardTo : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodCs>
    {
        #line hidden
        public MethodBodyTemplateForwardTo()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 11 "MethodBodyTemplateForwardTo.cshtml"
 if(true)
{
    var target = Model.ForwardTo as MethodCs;
    var varsSource = new Dictionary<string, string>();
    var varsTarget = new Dictionary<string, string>();
    foreach (var p in Model.LocalParameters)
        varsSource[p.SerializedName] = p.Name;
    foreach (var p in target.LocalParameters)
        varsTarget[p.SerializedName] = p.Name;
    var vars = target.LocalParameters.Select(p => p.SerializedName).ToList();
    Action<string> addAdditionalParameter = paramName => {
        vars.Add(paramName);
        varsSource.Add(paramName, paramName);
        varsTarget.Add(paramName, paramName);
    };
    addAdditionalParameter("customHeaders");
    addAdditionalParameter("cancellationToken");
    var indent = "\n    ";
    var ps = string.Join("," + indent, vars.Select(v => $"{varsTarget[v]}: {(varsSource.ContainsKey(v) ? varsSource[v] : target.LocalParameters.First(p => p.SerializedName == v).ActualDefaultValue)}"));
    if (ps != "") ps = indent + ps;


#line default
#line hidden

            WriteLiteral("return await ");
#line 32 "MethodBodyTemplateForwardTo.cshtml"
           Write(target.MethodReference);

#line default
#line hidden
            WriteLiteral("WithHttpMessagesAsync(");
#line 32 "MethodBodyTemplateForwardTo.cshtml"
                                                         Write(ps);

#line default
#line hidden
            WriteLiteral(");\n");
#line 33 "MethodBodyTemplateForwardTo.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
