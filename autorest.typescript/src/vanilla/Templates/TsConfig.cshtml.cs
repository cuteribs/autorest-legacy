// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.vanilla.Templates
{
    using System.Threading.Tasks;

    public class TsConfig : AutoRest.Core.Template<AutoRest.TypeScript.Model.CodeModelTS>
    {
        #line hidden
        public TsConfig()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral(@"{
  ""compilerOptions"": {
    ""module"": ""es6"",
    ""moduleResolution"": ""node"",
    ""strict"": true,
    ""target"": ""es5"",
    ""sourceMap"": true,
    ""declarationMap"": true,
    ""esModuleInterop"": true,
    ""allowSyntheticDefaultImports"": true,
    ""forceConsistentCasingInFileNames"": true,
    ""lib"": [""es6"", ""dom""],
    ""declaration"": true,
    ""outDir"": ""./esm"",
    ""importHelpers"": true
  },
  ""include"": [""./src/**/*.ts""],
  ""exclude"": [""node_modules""]
}
");
        }
        #pragma warning restore 1998
    }
}
