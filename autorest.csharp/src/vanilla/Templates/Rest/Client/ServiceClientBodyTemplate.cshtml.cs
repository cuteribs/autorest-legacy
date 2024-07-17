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
            WriteLiteral("(System.Net.Http.HttpClient httpClient) : base(httpClient, true)\n{\n    this.Initialize();\n}\n");
#line 62 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");
#line 65 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'httpClient\'>\n/// HttpClient to be used\n/// </param>\n/// <param name=\'disposeHttpClient\'>\n/// True: will dispose the provided httpClient on calling ");
#line 71 "ServiceClientBodyTemplate.cshtml"
                                                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral(".Dispose(). False: will not dispose provided httpClient</param>\n");
#line 72 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 72 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Net.Http.HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)\n{\n    this.Initialize();\n}\n");
#line 76 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");
#line 79 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n");
#line 84 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 84 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(params System.Net.Http.DelegatingHandler[] handlers) : base(handlers)\n{\n    this.Initialize();\n}\n");
#line 88 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");
#line 91 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'rootHandler\'>\n/// Optional. The http client handler used to handle http transport.\n/// </param>\n/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n");
#line 99 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 99 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : base(rootHandler, handlers)\n{\n    this.Initialize();\n}\n");
#line 103 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 105 "ServiceClientBodyTemplate.cshtml"
 if(!Model.IsCustomBaseUri)
{ 

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 108 "ServiceClientBodyTemplate.cshtml"
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
#line 119 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 119 "ServiceClientBodyTemplate.cshtml"
                                                                       Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n\n    this.BaseUri = baseUri;\n}\n");
#line 128 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral(" \n");
#line 129 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 131 "ServiceClientBodyTemplate.cshtml"
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
#line 145 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 145 "ServiceClientBodyTemplate.cshtml"
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
#line 154 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 155 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 157 "ServiceClientBodyTemplate.cshtml"
  var parameters = Model.Properties.Where(p => p.IsRequired && p.IsReadOnly);

#line default
#line hidden

#line 158 "ServiceClientBodyTemplate.cshtml"
 if (parameters.Any())
{

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 161 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 163 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 165 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 166 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 168 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 175 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 175 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 175 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n");
#line 177 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 179 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 181 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 183 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 186 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 186 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 187 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 187 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 193 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 193 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 196 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 197 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 199 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 201 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 203 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 204 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 206 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'httpClient\'>\n/// HttpClient to be used\n/// </param>\n/// <param name=\'disposeHttpClient\'>\n/// True: will dispose the provided httpClient on calling ");
#line 211 "ServiceClientBodyTemplate.cshtml"
                                                        Write(Model.Name);

#line default
#line hidden
            WriteLiteral(".Dispose(). False: will not dispose provided httpClient</param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 215 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 215 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 215 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)\n{\n");
#line 217 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 219 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 221 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 223 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 226 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 226 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 227 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 227 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 233 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 233 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 236 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 237 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 239 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 241 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 243 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 244 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 246 "ServiceClientBodyTemplate.cshtml"
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
#line 256 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 256 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 256 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)\n{\n");
#line 258 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 260 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 262 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 264 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 267 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 267 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 268 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 268 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 274 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 274 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 277 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 278 "ServiceClientBodyTemplate.cshtml"

if(!Model.IsCustomBaseUri)
{ 

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 282 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'baseUri\'>\n/// Optional. The base URI of the service.\n/// </param>\n");
#line 287 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 289 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 290 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 292 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 299 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 299 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, ");
#line 299 "ServiceClientBodyTemplate.cshtml"
                                                               Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n");
#line 305 "ServiceClientBodyTemplate.cshtml"
    foreach (var param in parameters)
    {

#line default
#line hidden

            WriteLiteral("    if (");
#line 307 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 309 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 311 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden

            WriteLiteral("    this.BaseUri = baseUri;\n");
#line 314 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 317 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 317 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 318 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

#line 319 "ServiceClientBodyTemplate.cshtml"
 if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
{

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 325 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

#line 325 "ServiceClientBodyTemplate.cshtml"
 
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 328 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 329 "ServiceClientBodyTemplate.cshtml"
        

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 331 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'baseUri\'>\n/// Optional. The base URI of the service.\n/// </param>\n");
#line 336 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 338 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 339 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 341 "ServiceClientBodyTemplate.cshtml"
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
#line 351 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 351 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, ");
#line 351 "ServiceClientBodyTemplate.cshtml"
                                                               Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n");
#line 357 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 360 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 362 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 364 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden

            WriteLiteral("    this.BaseUri = baseUri;\n");
#line 367 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 370 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 370 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 371 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

#line 372 "ServiceClientBodyTemplate.cshtml"
 if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
{

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 378 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

#line 378 "ServiceClientBodyTemplate.cshtml"
 
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 381 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 382 "ServiceClientBodyTemplate.cshtml"
}
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
