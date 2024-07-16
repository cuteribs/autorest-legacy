// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "ServiceClientBodyTemplate.cshtml"
using System

#line default
#line hidden
    ;
#line 2 "ServiceClientBodyTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "ServiceClientBodyTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "ServiceClientBodyTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class ServiceClientBodyTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.CodeModelCs>
    {
        #line hidden
        public ServiceClientBodyTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("\n/// <summary>\n/// The base URI of the service.\n/// </summary>\n");
#line 11 "ServiceClientBodyTemplate.cshtml"
 if(Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("internal string BaseUri {get; set;}\n");
#line 14 "ServiceClientBodyTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("public System.Uri BaseUri { get; set; }\n");
#line 18 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

#line 19 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Gets or sets json serialization settings.\n/// </summary>\npublic Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; private set; }\n");
#line 25 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Gets or sets json deserialization settings.\n/// </summary>\npublic Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; private set; }\n");
#line 31 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        \n");
#line 33 "ServiceClientBodyTemplate.cshtml"
 foreach (var property in Model.Properties)
{

#line default
#line hidden

            WriteLiteral("/// <summary>\n");
#line 36 "ServiceClientBodyTemplate.cshtml"
Write(WrapComment("/// ", property.Documentation.EscapeXmlComment()));

#line default
#line hidden
            WriteLiteral("\n/// </summary>\npublic ");
#line 38 "ServiceClientBodyTemplate.cshtml"
    Write(property.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 38 "ServiceClientBodyTemplate.cshtml"
                            Write(property.Name);

#line default
#line hidden
            WriteLiteral(" { get; ");
#line 38 "ServiceClientBodyTemplate.cshtml"
                                                   Write(property.IsReadOnly || property.IsConstant ? "private " : "");

#line default
#line hidden
            WriteLiteral("set; }\n");
#line 39 "ServiceClientBodyTemplate.cshtml"

#line default
#line hidden

#line 39 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 39 "ServiceClientBodyTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("        \n");
#line 42 "ServiceClientBodyTemplate.cshtml"
 foreach (var operation in Model.AllOperations) 
{

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Gets the I");
#line 45 "ServiceClientBodyTemplate.cshtml"
            Write(operation.TypeName);

#line default
#line hidden
            WriteLiteral(".\n/// </summary>\npublic virtual I");
#line 47 "ServiceClientBodyTemplate.cshtml"
              Write(operation.TypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 47 "ServiceClientBodyTemplate.cshtml"
                                    Write(operation.NameForProperty);

#line default
#line hidden
            WriteLiteral(" { get; private set; }\n");
#line 48 "ServiceClientBodyTemplate.cshtml"

#line default
#line hidden

#line 48 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 48 "ServiceClientBodyTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("\n/// <summary>\n/// Initializes a new instance of the ");
#line 52 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'httpClient\'>\n/// HttpClient to be used\n/// </param>\n[Microsoft.Extensions.DependencyInjection.ActivatorUtilitiesConstructor]\n");
#line 58 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 58 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Net.Http.HttpClient httpClient) : this(httpClient, true)\n{\n}\n");
#line 61 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");
#line 64 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'httpClient\'>\n/// HttpClient to be used\n/// </param>\n/// <param name=\'disposeHttpClient\'>\n/// True: will dispose the provided httpClient on calling ");
#line 70 "ServiceClientBodyTemplate.cshtml"
                                                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral(".Dispose(). False: will not dispose provided httpClient</param>\n");
#line 71 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 71 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Net.Http.HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)\n{\n    this.Initialize();\n}\n");
#line 75 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");
#line 78 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n");
#line 83 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 83 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(params System.Net.Http.DelegatingHandler[] handlers) : base(handlers)\n{\n    this.Initialize();\n}\n");
#line 87 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");
#line 90 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'rootHandler\'>\n/// Optional. The http client handler used to handle http transport.\n/// </param>\n/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n");
#line 98 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 98 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : base(rootHandler, handlers)\n{\n    this.Initialize();\n}\n");
#line 102 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 104 "ServiceClientBodyTemplate.cshtml"
 if(!Model.IsCustomBaseUri)
{ 

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 107 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(@" class.
/// </summary>
/// <param name='baseUri'>
/// Optional. The base URI of the service.
/// </param>
/// <param name='handlers'>
/// Optional. The delegating handlers to add to the http client pipeline.
/// </param>
/// <exception cref=""System.ArgumentNullException"">
/// Thrown when a required parameter is null
/// </exception>
");
#line 118 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 118 "ServiceClientBodyTemplate.cshtml"
                                                                       Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n\n    this.BaseUri = baseUri;\n}\n");
#line 127 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral(" \n");
#line 128 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 130 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(@" class.
/// </summary>
/// <param name='baseUri'>
/// Optional. The base URI of the service.
/// </param>
/// <param name='rootHandler'>
/// Optional. The http client handler used to handle http transport.
/// </param>
/// <param name='handlers'>
/// Optional. The delegating handlers to add to the http client pipeline.
/// </param>
/// <exception cref=""System.ArgumentNullException"">
/// Thrown when a required parameter is null
/// </exception>
");
#line 144 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 144 "ServiceClientBodyTemplate.cshtml"
                                                                       Write(Model.Name);

#line default
#line hidden
            WriteLiteral(@"(System.Uri baseUri, System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)
{
    if (baseUri == null)
    {
        throw new System.ArgumentNullException(""baseUri"");
    }

    this.BaseUri = baseUri;
}
");
#line 153 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 154 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 156 "ServiceClientBodyTemplate.cshtml"
  var parameters = Model.Properties.Where(p => p.IsRequired && p.IsReadOnly);

#line default
#line hidden

#line 157 "ServiceClientBodyTemplate.cshtml"
 if (parameters.Any())
{

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 160 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 162 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 164 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 165 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 167 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 174 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 174 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 174 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n");
#line 176 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 178 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 180 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 182 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 185 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 185 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 186 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 186 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 192 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 192 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 195 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 196 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 198 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 200 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 202 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 203 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 205 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'httpClient\'>\n/// HttpClient to be used\n/// </param>\n/// <param name=\'disposeHttpClient\'>\n/// True: will dispose the provided httpClient on calling ");
#line 210 "ServiceClientBodyTemplate.cshtml"
                                                        Write(Model.Name);

#line default
#line hidden
            WriteLiteral(".Dispose(). False: will not dispose provided httpClient</param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 214 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 214 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 214 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)\n{\n");
#line 216 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 218 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 220 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 222 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 225 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 225 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 226 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 226 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 232 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 232 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 235 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 236 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 238 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 240 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 242 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 243 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 245 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral(@"/// <param name='rootHandler'>
/// Optional. The http client handler used to handle http transport.
/// </param>
/// <param name='handlers'>
/// Optional. The delegating handlers to add to the http client pipeline.
/// </param>
/// <exception cref=""System.ArgumentNullException"">
/// Thrown when a required parameter is null
/// </exception>
");
#line 255 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 255 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 255 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)\n{\n");
#line 257 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 259 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 261 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 263 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 266 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 266 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 267 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 267 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 273 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 273 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 276 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 277 "ServiceClientBodyTemplate.cshtml"

if(!Model.IsCustomBaseUri)
{ 

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 281 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'baseUri\'>\n/// Optional. The base URI of the service.\n/// </param>\n");
#line 286 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 288 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 289 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 291 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 298 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 298 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, ");
#line 298 "ServiceClientBodyTemplate.cshtml"
                                                               Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n");
#line 304 "ServiceClientBodyTemplate.cshtml"
    foreach (var param in parameters)
    {

#line default
#line hidden

            WriteLiteral("    if (");
#line 306 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 308 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 310 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden

            WriteLiteral("    this.BaseUri = baseUri;\n");
#line 313 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 316 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 316 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 317 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

#line 318 "ServiceClientBodyTemplate.cshtml"
 if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
{

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 324 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

#line 324 "ServiceClientBodyTemplate.cshtml"
 
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 327 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 328 "ServiceClientBodyTemplate.cshtml"
        

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 330 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'baseUri\'>\n/// Optional. The base URI of the service.\n/// </param>\n");
#line 335 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 337 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 338 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 340 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral(@"/// <param name='rootHandler'>
/// Optional. The http client handler used to handle http transport.
/// </param>
/// <param name='handlers'>
/// Optional. The delegating handlers to add to the http client pipeline.
/// </param>
/// <exception cref=""System.ArgumentNullException"">
/// Thrown when a required parameter is null
/// </exception>
");
#line 350 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 350 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, ");
#line 350 "ServiceClientBodyTemplate.cshtml"
                                                               Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n");
#line 356 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 359 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 361 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 363 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden

            WriteLiteral("    this.BaseUri = baseUri;\n");
#line 366 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 369 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 369 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 370 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

#line 371 "ServiceClientBodyTemplate.cshtml"
 if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
{

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 377 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

#line 377 "ServiceClientBodyTemplate.cshtml"
 
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 380 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 381 "ServiceClientBodyTemplate.cshtml"
}
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
