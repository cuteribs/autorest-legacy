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
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'httpClient\'>\n/// HttpClient to be used\n/// </param>\n/// <param name=\'disposeHttpClient\'>\n/// True: will dispose the provided httpClient on calling ");
#line 58 "ServiceClientBodyTemplate.cshtml"
                                                      Write(Model.Name);

#line default
#line hidden
            WriteLiteral(".Dispose(). False: will not dispose provided httpClient</param>\n");
#line 59 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 59 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Net.Http.HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)\n{\n    this.Initialize();\n}\n");
#line 63 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");
#line 66 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n");
#line 71 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 71 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(params System.Net.Http.DelegatingHandler[] handlers) : base(handlers)\n{\n    this.Initialize();\n}\n");
#line 75 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n/// <summary>\n/// Initializes a new instance of the ");
#line 78 "ServiceClientBodyTemplate.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'rootHandler\'>\n/// Optional. The http client handler used to handle http transport.\n/// </param>\n/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n");
#line 86 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 86 "ServiceClientBodyTemplate.cshtml"
                                                                     Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : base(rootHandler, handlers)\n{\n    this.Initialize();\n}\n");
#line 90 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 92 "ServiceClientBodyTemplate.cshtml"
 if(!Model.IsCustomBaseUri)
{ 

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 95 "ServiceClientBodyTemplate.cshtml"
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
#line 106 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 106 "ServiceClientBodyTemplate.cshtml"
                                                                       Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n\n    this.BaseUri = baseUri;\n}\n");
#line 115 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral(" \n");
#line 116 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 118 "ServiceClientBodyTemplate.cshtml"
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
#line 132 "ServiceClientBodyTemplate.cshtml"
Write(Model.ContainsCredentials ? "protected" : Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 132 "ServiceClientBodyTemplate.cshtml"
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
#line 141 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 142 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 144 "ServiceClientBodyTemplate.cshtml"
  var parameters = Model.Properties.Where(p => p.IsRequired && p.IsReadOnly);

#line default
#line hidden

#line 145 "ServiceClientBodyTemplate.cshtml"
 if (parameters.Any())
{

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 148 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 150 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 152 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 153 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 155 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 162 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 162 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 162 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n");
#line 164 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 166 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 168 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 170 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 173 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 173 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 174 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 174 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 180 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 180 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 183 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 184 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 186 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 188 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 190 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 191 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 193 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'httpClient\'>\n/// HttpClient to be used\n/// </param>\n/// <param name=\'disposeHttpClient\'>\n/// True: will dispose the provided httpClient on calling ");
#line 198 "ServiceClientBodyTemplate.cshtml"
                                                        Write(Model.Name);

#line default
#line hidden
            WriteLiteral(".Dispose(). False: will not dispose provided httpClient</param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 202 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 202 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 202 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)\n{\n");
#line 204 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 206 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 208 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 210 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 213 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 213 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 214 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 214 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 220 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 220 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 223 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 224 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 226 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n");
#line 228 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 230 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 231 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 233 "ServiceClientBodyTemplate.cshtml"
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
#line 243 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 243 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(");
#line 243 "ServiceClientBodyTemplate.cshtml"
                                           Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)\n{\n");
#line 245 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 247 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 249 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 251 "ServiceClientBodyTemplate.cshtml"
}
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 254 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 254 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 255 "ServiceClientBodyTemplate.cshtml"
    

#line default
#line hidden

#line 255 "ServiceClientBodyTemplate.cshtml"
     if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
    {

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 261 "ServiceClientBodyTemplate.cshtml"
    }

#line default
#line hidden

#line 261 "ServiceClientBodyTemplate.cshtml"
     
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 264 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 265 "ServiceClientBodyTemplate.cshtml"

if(!Model.IsCustomBaseUri)
{ 

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 269 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'baseUri\'>\n/// Optional. The base URI of the service.\n/// </param>\n");
#line 274 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 276 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 277 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 279 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("/// <param name=\'handlers\'>\n/// Optional. The delegating handlers to add to the http client pipeline.\n/// </param>\n/// <exception cref=\"System.ArgumentNullException\">\n/// Thrown when a required parameter is null\n/// </exception>\n");
#line 286 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 286 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, ");
#line 286 "ServiceClientBodyTemplate.cshtml"
                                                               Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n");
#line 292 "ServiceClientBodyTemplate.cshtml"
    foreach (var param in parameters)
    {

#line default
#line hidden

            WriteLiteral("    if (");
#line 294 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 296 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 298 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden

            WriteLiteral("    this.BaseUri = baseUri;\n");
#line 301 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 304 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 304 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 305 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

#line 306 "ServiceClientBodyTemplate.cshtml"
 if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
{

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 312 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

#line 312 "ServiceClientBodyTemplate.cshtml"
 
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 315 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 316 "ServiceClientBodyTemplate.cshtml"
        

#line default
#line hidden

            WriteLiteral("/// <summary>\n/// Initializes a new instance of the ");
#line 318 "ServiceClientBodyTemplate.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            WriteLiteral(" class.\n/// </summary>\n/// <param name=\'baseUri\'>\n/// Optional. The base URI of the service.\n/// </param>\n");
#line 323 "ServiceClientBodyTemplate.cshtml"
foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("/// <param name=\'");
#line 325 "ServiceClientBodyTemplate.cshtml"
               Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\'>\n/// Required. ");
#line 326 "ServiceClientBodyTemplate.cshtml"
            Write(param.Documentation);

#line default
#line hidden
            WriteLiteral("\n/// </param>\n");
#line 328 "ServiceClientBodyTemplate.cshtml"
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
#line 338 "ServiceClientBodyTemplate.cshtml"
Write(Model.ConstructorVisibility);

#line default
#line hidden
            WriteLiteral(" ");
#line 338 "ServiceClientBodyTemplate.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            WriteLiteral("(System.Uri baseUri, ");
#line 338 "ServiceClientBodyTemplate.cshtml"
                                                               Write(Model.RequiredConstructorParameters);

#line default
#line hidden
            WriteLiteral(", System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)\n{\n    if (baseUri == null)\n    {\n        throw new System.ArgumentNullException(\"baseUri\");\n    }\n");
#line 344 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    if (");
#line 347 "ServiceClientBodyTemplate.cshtml"
      Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(" == null)\n    {\n        throw new System.ArgumentNullException(\"");
#line 349 "ServiceClientBodyTemplate.cshtml"
                                              Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral("\");\n    }\n");
#line 351 "ServiceClientBodyTemplate.cshtml"
}


#line default
#line hidden

            WriteLiteral("    this.BaseUri = baseUri;\n");
#line 354 "ServiceClientBodyTemplate.cshtml"

foreach (var param in parameters)
{

#line default
#line hidden

            WriteLiteral("    this.");
#line 357 "ServiceClientBodyTemplate.cshtml"
       Write(param.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 357 "ServiceClientBodyTemplate.cshtml"
                       Write(param.Name.ToCamelCase());

#line default
#line hidden
            WriteLiteral(";\n");
#line 358 "ServiceClientBodyTemplate.cshtml"


#line default
#line hidden

#line 359 "ServiceClientBodyTemplate.cshtml"
 if (param.ModelType.IsPrimaryType(KnownPrimaryType.Credentials))
{

#line default
#line hidden

            WriteLiteral("    if (this.Credentials != null)\n    {\n        this.Credentials.InitializeServiceClient(this);\n    }\n");
#line 365 "ServiceClientBodyTemplate.cshtml"
}

#line default
#line hidden

#line 365 "ServiceClientBodyTemplate.cshtml"
 
}

#line default
#line hidden

            WriteLiteral("}\n");
#line 368 "ServiceClientBodyTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 369 "ServiceClientBodyTemplate.cshtml"
}
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
