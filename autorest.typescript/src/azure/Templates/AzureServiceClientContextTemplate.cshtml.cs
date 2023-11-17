// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureServiceClientContextTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 2 "AzureServiceClientContextTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 3 "AzureServiceClientContextTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 4 "AzureServiceClientContextTemplate.cshtml"
using AutoRest.TypeScript.Azure.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureServiceClientContextTemplate : AutoRest.Core.Template<CodeModelTSa>
    {
        #line hidden
        public AzureServiceClientContextTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("/*\n");
#line 7 "AzureServiceClientContextTemplate.cshtml"
Write(Header(" * "));

#line default
#line hidden
            WriteLiteral("\n */\n");
#line 9 "AzureServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 10 "AzureServiceClientContextTemplate.cshtml"
  
bool usesCustomOptionsType = Model.OptionalParameterTypeForClientConstructor != "AzureServiceClientOptions";
if (usesCustomOptionsType)
{

#line default
#line hidden

            WriteLiteral("import * as Models from \"./models\";\n");
#line 15 "AzureServiceClientContextTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("import * as coreHttp from \"@azure/core-http\";\nimport * as coreArm from \"@azure/core-arm\";\n");
#line 19 "AzureServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nconst packageName = \"");
#line 20 "AzureServiceClientContextTemplate.cshtml"
                Write(Model.Settings.PackageName);

#line default
#line hidden
            WriteLiteral("\";\nconst packageVersion = \"");
#line 21 "AzureServiceClientContextTemplate.cshtml"
                   Write(Model.Settings.PackageVersion);

#line default
#line hidden
            WriteLiteral("\";\n");
#line 22 "AzureServiceClientContextTemplate.cshtml"
  var requiredParameters = Model.Properties.Where(p => p.IsRequired && !p.IsConstant && string.IsNullOrEmpty(p.DefaultValue));

#line default
#line hidden

#line 23 "AzureServiceClientContextTemplate.cshtml"
  var optionalParameters = Model.Properties.Where(p => (!p.IsRequired || p.IsRequired && !string.IsNullOrEmpty(p.DefaultValue)) && !p.IsConstant && !p.Name.EqualsIgnoreCase("apiVersion"));

#line default
#line hidden

#line 24 "AzureServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\nexport class ");
#line 25 "AzureServiceClientContextTemplate.cshtml"
         Write(Model.ContextName);

#line default
#line hidden
            WriteLiteral(" extends coreArm.AzureServiceClient {\n  ");
#line 26 "AzureServiceClientContextTemplate.cshtml"
Write(Model.GenerateClassProperties(EmptyLine));

#line default
#line hidden
            WriteLiteral("\n  ");
#line 27 "AzureServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n  ");
#line 28 "AzureServiceClientContextTemplate.cshtml"
Write(Model.GenerateConstructorComment(Model.Name));

#line default
#line hidden
            WriteLiteral("\n");
#line 29 "AzureServiceClientContextTemplate.cshtml"
   var clientOptionType = Model.OptionalParameterTypeForClientConstructor == "AzureServiceClientOptions" ? "coreArm.AzureServiceClientOptions" : Model.OptionalParameterTypeForClientConstructor;

#line default
#line hidden

            WriteLiteral("  constructor(");
#line 30 "AzureServiceClientContextTemplate.cshtml"
          Write(!string.IsNullOrEmpty(Model.RequiredConstructorParametersTS) ? Model.RequiredConstructorParametersTS + ", " : "");

#line default
#line hidden
            WriteLiteral("options?: ");
#line 30 "AzureServiceClientContextTemplate.cshtml"
                                                                                                                                      Write(clientOptionType);

#line default
#line hidden
            WriteLiteral(") {\n");
#line 31 "AzureServiceClientContextTemplate.cshtml"
 foreach (var param in requiredParameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 33 "AzureServiceClientContextTemplate.cshtml"
      Write(param.Name);

#line default
#line hidden
            WriteLiteral(" == undefined) {\n      throw new Error(\'\\\'");
#line 34 "AzureServiceClientContextTemplate.cshtml"
                       Write(param.Name);

#line default
#line hidden
            WriteLiteral("\\\' cannot be null.\');\n    }\n");
#line 36 "AzureServiceClientContextTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    ");
#line 37 "AzureServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    if (!options) {\n      options = {};\n    }\n\n    if(!options.userAgent) {\n      const defaultUserAgent = coreArm.getDefaultUserAgentValue();\n      options.userAgent = `${packageName}/${packageVersion} ${defaultUserAgent}`;\n    }\n    ");
#line 46 "AzureServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    super(");
#line 47 "AzureServiceClientContextTemplate.cshtml"
      Write(requiredParameters.Any(p => p.ModelType.IsPrimaryType(KnownPrimaryType.Credentials)) ? "credentials" : "undefined");

#line default
#line hidden
            WriteLiteral(", options);\n    ");
#line 48 "AzureServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 49 "AzureServiceClientContextTemplate.cshtml"
 foreach (var property in Model.Properties.Where(p => p.DefaultValue != null && p.Name != "generateClientRequestId"))
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 51 "AzureServiceClientContextTemplate.cshtml"
       Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 51 "AzureServiceClientContextTemplate.cshtml"
                          Write(property.DefaultValue);

#line default
#line hidden
            WriteLiteral(";\n");
#line 52 "AzureServiceClientContextTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n    ");
#line 54 "AzureServiceClientContextTemplate.cshtml"
Write(Model.GenerateBaseUri());

#line default
#line hidden
            WriteLiteral("\n");
#line 55 "AzureServiceClientContextTemplate.cshtml"
 if (!string.IsNullOrEmpty(Model.RequestContentType))
{

#line default
#line hidden

            WriteLiteral("\n    this.requestContentType = \"");
#line 58 "AzureServiceClientContextTemplate.cshtml"
                           Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\";\n");
#line 59 "AzureServiceClientContextTemplate.cshtml"
       
}

#line default
#line hidden

            WriteLiteral("\n");
#line 62 "AzureServiceClientContextTemplate.cshtml"
 foreach (var param in requiredParameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 64 "AzureServiceClientContextTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 64 "AzureServiceClientContextTemplate.cshtml"
                       Write(param.Name);

#line default
#line hidden
            WriteLiteral(";\n");
#line 65 "AzureServiceClientContextTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("  ");
#line 66 "AzureServiceClientContextTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 67 "AzureServiceClientContextTemplate.cshtml"
  

#line default
#line hidden

#line 67 "AzureServiceClientContextTemplate.cshtml"
   foreach (var property in optionalParameters.Where(p => p.Name != "generateClientRequestId"))
  {

#line default
#line hidden

            WriteLiteral("    if(options.");
#line 69 "AzureServiceClientContextTemplate.cshtml"
             Write(property.Name);

#line default
#line hidden
            WriteLiteral(" !== null && options.");
#line 69 "AzureServiceClientContextTemplate.cshtml"
                                                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" !== undefined) {\n      this.");
#line 70 "AzureServiceClientContextTemplate.cshtml"
         Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = options.");
#line 70 "AzureServiceClientContextTemplate.cshtml"
                                    Write(property.Name);

#line default
#line hidden
            WriteLiteral(";\n    }\n");
#line 72 "AzureServiceClientContextTemplate.cshtml"
  }

#line default
#line hidden

            WriteLiteral("  }\n}\n");
        }
        #pragma warning restore 1998
    }
}
