// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "MethodBodyTemplateRestCall.cshtml"
using System.Globalization

#line default
#line hidden
    ;
#line 2 "MethodBodyTemplateRestCall.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "MethodBodyTemplateRestCall.cshtml"
using System

#line default
#line hidden
    ;
#line 4 "MethodBodyTemplateRestCall.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 5 "MethodBodyTemplateRestCall.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 6 "MethodBodyTemplateRestCall.cshtml"
using AutoRest.CSharp

#line default
#line hidden
    ;
#line 7 "MethodBodyTemplateRestCall.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
#line 8 "MethodBodyTemplateRestCall.cshtml"
using AutoRest.Extensions

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodBodyTemplateRestCall : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodCs>
    {
        #line hidden
        public MethodBodyTemplateRestCall()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 11 "MethodBodyTemplateRestCall.cshtml"
 foreach (ParameterCs parameter in Model.Parameters.Where(p => !p.IsConstant))
{
    if (parameter.IsRequired && parameter.IsNullable())
    {

#line default
#line hidden

            WriteLiteral("if (");
#line 15 "MethodBodyTemplateRestCall.cshtml"
  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" == null)\n{\n    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, \"");
#line 17 "MethodBodyTemplateRestCall.cshtml"
                                                                                             Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\");\n}\n\n");
#line 20 "MethodBodyTemplateRestCall.cshtml"
    }
    if(parameter.CanBeValidated  && (Model.HttpMethod != HttpMethod.Patch || parameter.Location != ParameterLocation.Body))
    {

#line default
#line hidden

#line 23 "MethodBodyTemplateRestCall.cshtml"
Write(parameter.ModelType.ValidateType(Model, parameter.Name, parameter.IsNullable(), parameter.Constraints));

#line default
#line hidden
            WriteLiteral("\n");
#line 24 "MethodBodyTemplateRestCall.cshtml"
    }
}

#line default
#line hidden

            WriteLiteral("\n");
#line 27 "MethodBodyTemplateRestCall.cshtml"
 foreach (ParameterCs parameter in Model.Parameters.Where(p => p.IsConstant && !p.IsClientProperty))
{

#line default
#line hidden

#line 29 "MethodBodyTemplateRestCall.cshtml"
Write(parameter.ModelTypeName);

#line default
#line hidden
            WriteLiteral(" ");
#line 29 "MethodBodyTemplateRestCall.cshtml"
                         Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 29 "MethodBodyTemplateRestCall.cshtml"
                                             Write(parameter.DefaultValue);

#line default
#line hidden
            WriteLiteral(";\n");
#line 30 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

#line 31 "MethodBodyTemplateRestCall.cshtml"
Write(Model.BuildInputMappings());

#line default
#line hidden
            WriteLiteral("\n\n// Construct URL\n");
#line 34 "MethodBodyTemplateRestCall.cshtml"
 if (Model.IsAbsoluteUrl)
{

#line default
#line hidden

            WriteLiteral("string _url = \"");
#line 36 "MethodBodyTemplateRestCall.cshtml"
             Write(Model.Url);

#line default
#line hidden
            WriteLiteral("\";\n");
#line 37 "MethodBodyTemplateRestCall.cshtml"
}
else
{
if (Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("var _baseUrl = ");
#line 42 "MethodBodyTemplateRestCall.cshtml"
             Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".HttpClient.BaseAddress ?? ");
#line 42 "MethodBodyTemplateRestCall.cshtml"
                                                                Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".BaseUri;\nvar _url = _baseUrl + (_baseUrl.EndsWith(\"/\") ? \"\" : \"/\") + \"");
#line 43 "MethodBodyTemplateRestCall.cshtml"
                                                           Write(Model.Url.TrimStart('/'));

#line default
#line hidden
            WriteLiteral("\";\n");
#line 44 "MethodBodyTemplateRestCall.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("var _baseUrl = ");
#line 47 "MethodBodyTemplateRestCall.cshtml"
             Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".HttpClient.BaseAddress?.AbsoluteUri ?? ");
#line 47 "MethodBodyTemplateRestCall.cshtml"
                                                                             Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".BaseUri.AbsoluteUri;\nvar _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith(\"/\") ? \"\" : \"/\")), \"");
#line 48 "MethodBodyTemplateRestCall.cshtml"
                                                                                         Write(Model.Url.TrimStart('/'));

#line default
#line hidden
            WriteLiteral("\").ToString();\n");
#line 49 "MethodBodyTemplateRestCall.cshtml"
}    
}

#line default
#line hidden

#line 51 "MethodBodyTemplateRestCall.cshtml"
Write(Model.BuildUrl("_url"));

#line default
#line hidden
            WriteLiteral("\n// Create HTTP transport objects\nvar _httpRequest = new System.Net.Http.HttpRequestMessage();\nSystem.Net.Http.HttpResponseMessage _httpResponse = null;\n\n_httpRequest.Method = new System.Net.Http.HttpMethod(\"");
#line 56 "MethodBodyTemplateRestCall.cshtml"
                                                  Write(Model.HttpMethod.ToString().ToUpper());

#line default
#line hidden
            WriteLiteral("\");\n_httpRequest.RequestUri = new System.Uri(_url);\n// Set Headers\n");
#line 59 "MethodBodyTemplateRestCall.cshtml"
Write(Model.SetDefaultHeaders);

#line default
#line hidden
            WriteLiteral("\n");
#line 60 "MethodBodyTemplateRestCall.cshtml"
 foreach (var parameter in Model.LogicalParameters.OfType<ParameterCs>().Where(p => p.Location == ParameterLocation.Header && !p.IsHeaderCollection && !p.IsContentTypeHeader))
{
    if (!parameter.IsNullable())
    {

#line default
#line hidden

            WriteLiteral("if (_httpRequest.Headers.Contains(\"");
#line 64 "MethodBodyTemplateRestCall.cshtml"
                                 Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\"))\n{\n    _httpRequest.Headers.Remove(\"");
#line 66 "MethodBodyTemplateRestCall.cshtml"
                               Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\");\n}\n_httpRequest.Headers.TryAddWithoutValidation(\"");
#line 68 "MethodBodyTemplateRestCall.cshtml"
                                            Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 68 "MethodBodyTemplateRestCall.cshtml"
                                                                         Write(parameter.ModelType.ToString(Model.ClientReference, parameter.Name));

#line default
#line hidden
            WriteLiteral(");\n");
#line 69 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("if (");
#line 72 "MethodBodyTemplateRestCall.cshtml"
  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n    if (_httpRequest.Headers.Contains(\"");
#line 74 "MethodBodyTemplateRestCall.cshtml"
                                     Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\"))\n    {\n        _httpRequest.Headers.Remove(\"");
#line 76 "MethodBodyTemplateRestCall.cshtml"
                                   Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\");\n    }\n    _httpRequest.Headers.TryAddWithoutValidation(\"");
#line 78 "MethodBodyTemplateRestCall.cshtml"
                                                Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 78 "MethodBodyTemplateRestCall.cshtml"
                                                                             Write(parameter.ModelType.ToString(Model.ClientReference, parameter.Name));

#line default
#line hidden
            WriteLiteral(");\n}\n");
#line 80 "MethodBodyTemplateRestCall.cshtml"
    }
}

#line default
#line hidden

#line 82 "MethodBodyTemplateRestCall.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 83 "MethodBodyTemplateRestCall.cshtml"
 foreach (var parameter in Model.LogicalParameters.OfType<ParameterCs>().Where(p => p.Location == ParameterLocation.Header && p.IsHeaderCollection))
{

#line default
#line hidden

            WriteLiteral("if (");
#line 85 "MethodBodyTemplateRestCall.cshtml"
  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n    foreach (var _header in ");
#line 87 "MethodBodyTemplateRestCall.cshtml"
                          Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(")\n    {\n        var key = \"");
#line 89 "MethodBodyTemplateRestCall.cshtml"
                 Write(parameter.HeaderCollectionPrefix);

#line default
#line hidden
            WriteLiteral("\" + _header.Key;\n        if (_httpRequest.Headers.Contains(key))\n        {\n            _httpRequest.Headers.Remove(key);\n        }\n        _httpRequest.Headers.TryAddWithoutValidation(key, _header.Value);\n    }\n}\n");
#line 97 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

#line 98 "MethodBodyTemplateRestCall.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral(@"
if (customHeaders != null)
{
    foreach(var _header in customHeaders)
    {
        if (_httpRequest.Headers.Contains(_header.Key))
        {
            _httpRequest.Headers.Remove(_header.Key);
        }
        _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
    }
}
");
#line 110 "MethodBodyTemplateRestCall.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n// Serialize Request\nstring _requestContent = null;\n");
#line 114 "MethodBodyTemplateRestCall.cshtml"
 if (Model.RequestBody != null)
{
    if (Model.RequestBody.ModelType.IsPrimaryType(KnownPrimaryType.Stream))
    {
        if (Model.RequestBody.IsRequired)
        {

#line default
#line hidden

            WriteLiteral("if(");
#line 120 "MethodBodyTemplateRestCall.cshtml"
 Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" == null)\n{\n  throw new System.ArgumentNullException(\"");
#line 122 "MethodBodyTemplateRestCall.cshtml"
                                        Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral("\");\n}\n");
#line 124 "MethodBodyTemplateRestCall.cshtml"
        }

#line default
#line hidden

            WriteLiteral("\nif (");
#line 126 "MethodBodyTemplateRestCall.cshtml"
Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" != null && ");
#line 126 "MethodBodyTemplateRestCall.cshtml"
                                     Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" != System.IO.Stream.Null)\n{\n    _httpRequest.Content = new System.Net.Http.StreamContent(");
#line 128 "MethodBodyTemplateRestCall.cshtml"
                                                         Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(");\n    _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(");
#line 129 "MethodBodyTemplateRestCall.cshtml"
                                                                                             Write(((Func<Parameter, string>)(p => p != null ? (p.Name.Value + ((p.ModelType as EnumType)?.ModelAsString == false ? ".ToSerializedValue()" : "")) : $"\"{Model.RequestContentType}\"" ))(Model.LocalParameters.FirstOrDefault(p => p.IsContentTypeHeader)));

#line default
#line hidden
            WriteLiteral(");\n}\n    ");
#line 131 "MethodBodyTemplateRestCall.cshtml"
           
    }
    else
    {
        if (Model.RequestContentType.StartsWith("application/xml"))
        {
            if (!Model.RequestBody.IsNullable()) {
                if (Model.RequestBody.ModelType is SequenceType && (Model.RequestBody.ModelType as SequenceType).ElementType is CompositeType)
                { // for primitive sequences for now

#line default
#line hidden

            WriteLiteral("_requestContent = new System.Xml.Linq.XElement(\"");
#line 140 "MethodBodyTemplateRestCall.cshtml"
                                             Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\", System.Linq.Enumerable.Select(");
#line 140 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                   Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", x => x.XmlSerialize(new System.Xml.Linq.XElement(\"");
#line 140 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                                Write((Model.RequestBody.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\")))).ToString();\n");
#line 141 "MethodBodyTemplateRestCall.cshtml"
                }
                else if (Model.RequestBody.ModelType is SequenceType)
                { // for primitive sequences for now

#line default
#line hidden

            WriteLiteral("_requestContent = new System.Xml.Linq.XElement(\"");
#line 144 "MethodBodyTemplateRestCall.cshtml"
                                             Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\", System.Linq.Enumerable.Select(");
#line 144 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                   Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", x => new System.Xml.Linq.XElement(\"");
#line 144 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                 Write((Model.RequestBody.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\", x))).ToString();\n");
#line 145 "MethodBodyTemplateRestCall.cshtml"
                }
                else
                {

#line default
#line hidden

            WriteLiteral("_requestContent = ");
#line 148 "MethodBodyTemplateRestCall.cshtml"
                Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(".XmlSerialize( new System.Xml.Linq.XElement(\"");
#line 148 "MethodBodyTemplateRestCall.cshtml"
                                                                                     Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\") ).ToString(); \n_requestContent = $\"<?xml version=\\\"1.0\\\" encoding=\\\"utf-8\\\" ?>\\n{_requestContent}\";\n");
#line 150 "MethodBodyTemplateRestCall.cshtml"
                }

#line default
#line hidden

            WriteLiteral("_httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);\n_httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(\"");
#line 152 "MethodBodyTemplateRestCall.cshtml"
                                                                                            Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\");\n");
#line 153 "MethodBodyTemplateRestCall.cshtml"
            }
            else {

#line default
#line hidden

            WriteLiteral("if(");
#line 155 "MethodBodyTemplateRestCall.cshtml"
 Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n");
#line 157 "MethodBodyTemplateRestCall.cshtml"
                if (Model.RequestBody.ModelType is SequenceType && (Model.RequestBody.ModelType as SequenceType).ElementType is CompositeType)
                { // for primitive sequences for now

#line default
#line hidden

            WriteLiteral("    _requestContent = new System.Xml.Linq.XElement(\"");
#line 159 "MethodBodyTemplateRestCall.cshtml"
                                                 Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\", System.Linq.Enumerable.Select(");
#line 159 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                       Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", x => x.XmlSerialize(new System.Xml.Linq.XElement(\"");
#line 159 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                                    Write((Model.RequestBody.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\")))).ToString();\n");
#line 160 "MethodBodyTemplateRestCall.cshtml"
                }
                else if (Model.RequestBody.ModelType is SequenceType)
                { // for primitive sequences for now

#line default
#line hidden

            WriteLiteral("    _requestContent = new System.Xml.Linq.XElement(\"");
#line 163 "MethodBodyTemplateRestCall.cshtml"
                                                 Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\", System.Linq.Enumerable.Select(");
#line 163 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                       Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", x => new System.Xml.Linq.XElement(\"");
#line 163 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                     Write((Model.RequestBody.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\", x))).ToString();\n");
#line 164 "MethodBodyTemplateRestCall.cshtml"
                }
                else
                {

#line default
#line hidden

            WriteLiteral("    _requestContent = ");
#line 167 "MethodBodyTemplateRestCall.cshtml"
                    Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(".XmlSerialize( new System.Xml.Linq.XElement(\"");
#line 167 "MethodBodyTemplateRestCall.cshtml"
                                                                                         Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\") ).ToString(); \n    _requestContent = $\"<?xml version=\\\"1.0\\\" encoding=\\\"utf-8\\\" ?>\\n{_requestContent}\";\n");
#line 169 "MethodBodyTemplateRestCall.cshtml"
                }

#line default
#line hidden

            WriteLiteral("    _httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);\n    _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(\"");
#line 171 "MethodBodyTemplateRestCall.cshtml"
                                                                                                Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\");\n}\n");
#line 173 "MethodBodyTemplateRestCall.cshtml"
            }
        }
        else
        {
            if (!Model.RequestBody.IsNullable()) {

#line default
#line hidden

            WriteLiteral("\n_requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(");
#line 178 "MethodBodyTemplateRestCall.cshtml"
                                                                           Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", ");
#line 178 "MethodBodyTemplateRestCall.cshtml"
                                                                                                      Write(Model.GetSerializationSettingsReference(Model.RequestBody.ModelType));

#line default
#line hidden
            WriteLiteral(");\n_httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);\n_httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(\"");
#line 180 "MethodBodyTemplateRestCall.cshtml"
                                                                                          Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\");");
#line 180 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                   
            }
            else {

#line default
#line hidden

            WriteLiteral("\nif(");
#line 183 "MethodBodyTemplateRestCall.cshtml"
Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n    _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(");
#line 185 "MethodBodyTemplateRestCall.cshtml"
                                                                               Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", ");
#line 185 "MethodBodyTemplateRestCall.cshtml"
                                                                                                          Write(Model.GetSerializationSettingsReference(Model.RequestBody.ModelType));

#line default
#line hidden
            WriteLiteral(");\n    _httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);\n    _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(\"");
#line 187 "MethodBodyTemplateRestCall.cshtml"
                                                                                              Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\");\n}");
#line 188 "MethodBodyTemplateRestCall.cshtml"
        
            }
        }
    }
}
else if (Model.LogicalParameters.Any(p => p.Location == ParameterLocation.FormData))
{
    if (!Model.RequestContentType.StartsWith("application/x-www-form-urlencoded"))
    {

#line default
#line hidden

            WriteLiteral("System.Net.Http.MultipartFormDataContent _multiPartContent = new System.Net.Http.MultipartFormDataContent();\n");
#line 198 "MethodBodyTemplateRestCall.cshtml"
    foreach (ParameterCs parameter in Model.LogicalParameters.Where(p => p.Location == ParameterLocation.FormData))
    {

#line default
#line hidden

            WriteLiteral("if (");
#line 200 "MethodBodyTemplateRestCall.cshtml"
  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n");
#line 202 "MethodBodyTemplateRestCall.cshtml"
    

#line default
#line hidden

#line 202 "MethodBodyTemplateRestCall.cshtml"
       string localParam = "_"+ @parameter.Name.Value.Replace("this.", ""); 

#line default
#line hidden

#line 202 "MethodBodyTemplateRestCall.cshtml"
                                                                             
    if (parameter.ModelType.IsPrimaryType(KnownPrimaryType.Stream))
    {

#line default
#line hidden

            WriteLiteral("        \n    System.Net.Http.StreamContent _");
#line 206 "MethodBodyTemplateRestCall.cshtml"
                              Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" = new System.Net.Http.StreamContent(");
#line 206 "MethodBodyTemplateRestCall.cshtml"
                                                                                  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(");\n    ");
#line 207 "MethodBodyTemplateRestCall.cshtml"
Write(localParam);

#line default
#line hidden
            WriteLiteral(@".Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(""application/octet-stream"");
    System.Net.Http.Headers.ContentDispositionHeaderValue _contentDispositionHeaderValue = new System.Net.Http.Headers.ContentDispositionHeaderValue(""form-data"");
    _contentDispositionHeaderValue.Name = """);
#line 209 "MethodBodyTemplateRestCall.cshtml"
                                       Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\";\n\n    // get filename from stream if it\'s a file otherwise, just use  \'unknown\'\n    var _fileStream = ");
#line 212 "MethodBodyTemplateRestCall.cshtml"
                 Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(@" as System.IO.FileStream;
    var _fileName = (_fileStream != null ? _fileStream.Name : null) ?? ""unknown"";

    if(System.Linq.Enumerable.Any(_fileName, c => c > 127) )
    {
        // non ASCII chars detected, need UTF encoding:
        _contentDispositionHeaderValue.FileNameStar = _fileName;
    }
    else
    {
        // ASCII only
        _contentDispositionHeaderValue.FileName = _fileName;
    } 

    ");
#line 226 "MethodBodyTemplateRestCall.cshtml"
Write(localParam);

#line default
#line hidden
            WriteLiteral(".Headers.ContentDisposition = _contentDispositionHeaderValue;        \n\n");
#line 228 "MethodBodyTemplateRestCall.cshtml"
       
        }
        else
        {

#line default
#line hidden

            WriteLiteral("    System.Net.Http.StringContent ");
#line 232 "MethodBodyTemplateRestCall.cshtml"
                                Write(localParam);

#line default
#line hidden
            WriteLiteral(" = new System.Net.Http.StringContent(");
#line 232 "MethodBodyTemplateRestCall.cshtml"
                                                                                  Write(parameter.ModelType.ToString(Model.ClientReference, parameter.Name));

#line default
#line hidden
            WriteLiteral(", System.Text.Encoding.UTF8);\n");
#line 233 "MethodBodyTemplateRestCall.cshtml"
        }

#line default
#line hidden

            WriteLiteral("    _multiPartContent.Add(");
#line 234 "MethodBodyTemplateRestCall.cshtml"
                        Write(localParam);

#line default
#line hidden
            WriteLiteral(", \"");
#line 234 "MethodBodyTemplateRestCall.cshtml"
                                        Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\");\n}\n");
#line 236 "MethodBodyTemplateRestCall.cshtml"
    }

#line default
#line hidden

            WriteLiteral("_httpRequest.Content = _multiPartContent;\n");
#line 238 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("var values = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>();\n");
#line 242 "MethodBodyTemplateRestCall.cshtml"
    foreach (ParameterCs parameter in Model.LogicalParameters.Where(p => p.Location == ParameterLocation.FormData))
    {

#line default
#line hidden

            WriteLiteral("if(");
#line 244 "MethodBodyTemplateRestCall.cshtml"
 Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n    values.Add(new System.Collections.Generic.KeyValuePair<string,string>(\"");
#line 246 "MethodBodyTemplateRestCall.cshtml"
                                                                         Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 246 "MethodBodyTemplateRestCall.cshtml"
                                                                                                      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("));\n}\n");
#line 248 "MethodBodyTemplateRestCall.cshtml"
    }

#line default
#line hidden

            WriteLiteral("var _formContent = new System.Net.Http.FormUrlEncodedContent(values);\n_httpRequest.Content = _formContent;\n");
#line 251 "MethodBodyTemplateRestCall.cshtml"
    }
}

#line default
#line hidden

            WriteLiteral("\n");
#line 254 "MethodBodyTemplateRestCall.cshtml"
 if (Settings.AddCredentials)
{

#line default
#line hidden

            WriteLiteral("\n// Set Credentials\nif (");
#line 258 "MethodBodyTemplateRestCall.cshtml"
Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".Credentials != null)\n{\n    cancellationToken.ThrowIfCancellationRequested();\n    await ");
#line 261 "MethodBodyTemplateRestCall.cshtml"
      Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);\n}\n    ");
#line 263 "MethodBodyTemplateRestCall.cshtml"
           
}

#line default
#line hidden

            WriteLiteral("\n// Send Request\ncancellationToken.ThrowIfCancellationRequested();\n");
#line 268 "MethodBodyTemplateRestCall.cshtml"
 if (Model.ReturnType.Body.IsPrimaryType(KnownPrimaryType.Stream) || Model.HttpMethod == HttpMethod.Head)
{

#line default
#line hidden

            WriteLiteral("_httpResponse = await ");
#line 270 "MethodBodyTemplateRestCall.cshtml"
                    Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".HttpClient.SendAsync(_httpRequest, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);\n");
#line 271 "MethodBodyTemplateRestCall.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("_httpResponse = await ");
#line 274 "MethodBodyTemplateRestCall.cshtml"
                    Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);\n");
#line 275 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

            WriteLiteral("\nSystem.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;\ncancellationToken.ThrowIfCancellationRequested();\nstring _responseContent = null;\n\nif (");
#line 281 "MethodBodyTemplateRestCall.cshtml"
Write(Model.FailureStatusCodePredicate);

#line default
#line hidden
            WriteLiteral(")\n{\n    var ex = new ");
#line 283 "MethodBodyTemplateRestCall.cshtml"
             Write(Model.OperationExceptionTypeString);

#line default
#line hidden
            WriteLiteral("(string.Format(\"Operation returned an invalid status code \'{0}\'\", _statusCode));\n");
#line 284 "MethodBodyTemplateRestCall.cshtml"
 if (Model.DefaultResponse.Body != null)
{

#line default
#line hidden

            WriteLiteral("    try\n    {\n");
#line 288 "MethodBodyTemplateRestCall.cshtml"
        if (Model.DefaultResponse.Body.IsPrimaryType(KnownPrimaryType.Stream))
        {

#line default
#line hidden

            WriteLiteral("        ");
#line 290 "MethodBodyTemplateRestCall.cshtml"
      Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(" _errorBody = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);\n");
#line 291 "MethodBodyTemplateRestCall.cshtml"
        }
        else
        {

#line default
#line hidden

            WriteLiteral("        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);\n        ");
#line 295 "MethodBodyTemplateRestCall.cshtml"
      Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(" _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 295 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                  Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(">(_responseContent, ");
#line 295 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                                    Write(Model.GetDeserializationSettingsReference(Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral(");\n");
#line 296 "MethodBodyTemplateRestCall.cshtml"
        }

#line default
#line hidden

            WriteLiteral("        if (_errorBody != null)\n        {\n            ");
#line 299 "MethodBodyTemplateRestCall.cshtml"
          Write(Model.InitializeExceptionWithMessage);

#line default
#line hidden
            WriteLiteral("\n            ex.Body = _errorBody;\n        }\n    }\n    catch (Newtonsoft.Json.JsonException)\n    {\n        // Ignore the exception\n    }\n");
#line 307 "MethodBodyTemplateRestCall.cshtml"
}
else
{
    //If not defined by default model, read content as string

#line default
#line hidden

            WriteLiteral("    if (_httpResponse.Content != null) {\n        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);\n    }\n    else {\n        _responseContent = string.Empty;\n    }\n");
#line 317 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n    ex.Request = new Microsoft.Rest.HttpRequestMessageWrapper(_httpRequest, _requestContent);\n    ex.Response = new Microsoft.Rest.HttpResponseMessageWrapper(_httpResponse, _responseContent);\n    ");
#line 321 "MethodBodyTemplateRestCall.cshtml"
Write(Model.InitializeException);

#line default
#line hidden
            WriteLiteral("\n\n    _httpRequest.Dispose();\n    if (_httpResponse != null)\n    {\n        _httpResponse.Dispose();\n    }\n    throw ex;\n}\n\n// Create Result\nvar _result = new ");
#line 332 "MethodBodyTemplateRestCall.cshtml"
              Write(Model.OperationResponseReturnTypeString);

#line default
#line hidden
            WriteLiteral("();\n_result.Request = _httpRequest;\n_result.Response = _httpResponse;\n");
#line 335 "MethodBodyTemplateRestCall.cshtml"
Write(Model.InitializeResponseBody);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 337 "MethodBodyTemplateRestCall.cshtml"
 foreach (var responsePair in Model.Responses.Where(r => r.Value.Body != null))
{

#line default
#line hidden

            WriteLiteral("\n// Deserialize Response\nif ((int)_statusCode == ");
#line 341 "MethodBodyTemplateRestCall.cshtml"
                   Write(MethodCs.GetStatusCodeReference(responsePair.Key));

#line default
#line hidden
            WriteLiteral(")\n{\n");
#line 343 "MethodBodyTemplateRestCall.cshtml"
    

#line default
#line hidden

#line 343 "MethodBodyTemplateRestCall.cshtml"
     if (responsePair.Value.Body.IsPrimaryType(KnownPrimaryType.Stream))
    {

#line default
#line hidden

            WriteLiteral("    _result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);\n");
#line 346 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("\n    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);\n    try\n    {\n");
#line 352 "MethodBodyTemplateRestCall.cshtml"
        

#line default
#line hidden

#line 352 "MethodBodyTemplateRestCall.cshtml"
         if (Model.CodeModel.ShouldGenerateXmlSerialization)
        {

#line default
#line hidden

            WriteLiteral("\n        ");
#line 354 "MethodBodyTemplateRestCall.cshtml"
   Write(responsePair.Value.Body.AsNullableType(Model.IsXNullableReturnType));

#line default
#line hidden
            WriteLiteral(" _tmp_ = null;\n        if (_httpResponse.Content.Headers.ContentType.MediaType == \"application/xml\" &&\n            ");
#line 356 "MethodBodyTemplateRestCall.cshtml"
        Write(XmlSerialization.XmlDeserializationClass);

#line default
#line hidden
            WriteLiteral(".Root(");
#line 356 "MethodBodyTemplateRestCall.cshtml"
                                                         Write(XmlSerialization.GenerateDeserializer(Model.CodeModel, responsePair.Value.Body));

#line default
#line hidden
            WriteLiteral(")(System.Xml.Linq.XElement.Parse(_responseContent), out _tmp_))\n        {\n            _result.Body = _tmp_;\n        }\n        else\n        {\n            _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 362 "MethodBodyTemplateRestCall.cshtml"
                                                                                      Write(responsePair.Value.Body.AsNullableType(Model.IsXNullableReturnType));

#line default
#line hidden
            WriteLiteral(">(_responseContent, ");
#line 362 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                Write(Model.GetDeserializationSettingsReference(responsePair.Value.Body));

#line default
#line hidden
            WriteLiteral(");\n        }\n");
#line 364 "MethodBodyTemplateRestCall.cshtml"
       
        }
        else
        {

#line default
#line hidden

            WriteLiteral("\n        _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 368 "MethodBodyTemplateRestCall.cshtml"
                                                                                  Write(responsePair.Value.Body.AsNullableType(Model.IsXNullableReturnType));

#line default
#line hidden
            WriteLiteral(">(_responseContent, ");
#line 368 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                            Write(Model.GetDeserializationSettingsReference(responsePair.Value.Body));

#line default
#line hidden
            WriteLiteral(");\n");
#line 369 "MethodBodyTemplateRestCall.cshtml"
       
        }

#line default
#line hidden

            WriteLiteral(@"    }
    catch (Newtonsoft.Json.JsonException ex)
    {
        _httpRequest.Dispose();
        if (_httpResponse != null)
        {
            _httpResponse.Dispose();
        }
        throw new Microsoft.Rest.SerializationException(""Unable to deserialize the response."", _responseContent, ex);
    }
");
#line 381 "MethodBodyTemplateRestCall.cshtml"
       
    }

#line default
#line hidden

            WriteLiteral("}\n");
#line 384 "MethodBodyTemplateRestCall.cshtml"
       
}

#line default
#line hidden

            WriteLiteral("\n");
#line 387 "MethodBodyTemplateRestCall.cshtml"
 if (Model.ReturnType.Body != null && Model.DefaultResponse.Body != null && !Model.Responses.Any())
{
    if (Model.DefaultResponse.Body.IsPrimaryType(KnownPrimaryType.Stream))
    {

#line default
#line hidden

            WriteLiteral("_result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);\n");
#line 392 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("string _defaultResponseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);\ntry\n{\n");
#line 398 "MethodBodyTemplateRestCall.cshtml"
    if (Model.CodeModel.ShouldGenerateXmlSerialization)
    {

#line default
#line hidden

            WriteLiteral("     ");
#line 400 "MethodBodyTemplateRestCall.cshtml"
  Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(" _tmp_ = null;\n     if (_httpResponse.Content.Headers.ContentType.MediaType == \"application/xml\" &&\n         ");
#line 402 "MethodBodyTemplateRestCall.cshtml"
       Write(XmlSerialization.XmlDeserializationClass);

#line default
#line hidden
            WriteLiteral(".Root(");
#line 402 "MethodBodyTemplateRestCall.cshtml"
                                                        Write(XmlSerialization.GenerateDeserializer(Model.CodeModel, Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral(")(System.Xml.Linq.XElement.Parse(_defaultResponseContent), out _tmp_))\n    {\n       _result.Body = _tmp_;\n    } else \n    {\n        _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 407 "MethodBodyTemplateRestCall.cshtml"
                                                                                    Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(">(_defaultResponseContent, ");
#line 407 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                             Write(Model.GetDeserializationSettingsReference(Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral(");\n    }\n");
#line 409 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 412 "MethodBodyTemplateRestCall.cshtml"
                                                                                Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(">(_defaultResponseContent, ");
#line 412 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                         Write(Model.GetDeserializationSettingsReference(Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral(");\n");
#line 413 "MethodBodyTemplateRestCall.cshtml"
    }

#line default
#line hidden

            WriteLiteral(@"}
catch (Newtonsoft.Json.JsonException ex)
{
    _httpRequest.Dispose();
    if (_httpResponse != null)
    {
        _httpResponse.Dispose();
    }
    throw new Microsoft.Rest.SerializationException(""Unable to deserialize the response."", _defaultResponseContent, ex);
}
");
#line 424 "MethodBodyTemplateRestCall.cshtml"
    }
}

#line default
#line hidden

            WriteLiteral("\n");
#line 427 "MethodBodyTemplateRestCall.cshtml"
 if (Model.ReturnType.Headers != null)
{


#line default
#line hidden

            WriteLiteral("try\n{\n    _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<");
#line 432 "MethodBodyTemplateRestCall.cshtml"
                                                              Write(Model.ReturnType.Headers.Name);

#line default
#line hidden
            WriteLiteral(">(Newtonsoft.Json.JsonSerializer.Create(");
#line 432 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                      Write(Model.GetDeserializationSettingsReference(Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral("));\n");
#line 433 "MethodBodyTemplateRestCall.cshtml"
    foreach (var property in (Model.ReturnType.Headers as CompositeType).Properties.OfType<PropertyCs>().Where(p => p.IsHeaderCollection))
    {

#line default
#line hidden

            WriteLiteral("    _result.Headers.");
#line 435 "MethodBodyTemplateRestCall.cshtml"
                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = new ");
#line 435 "MethodBodyTemplateRestCall.cshtml"
                                         Write(property.ModelTypeName.Replace("IDictionary", "Dictionary"));

#line default
#line hidden
            WriteLiteral("();\n    foreach (var header in _httpResponse.Headers)\n    {\n        if (header.Key.StartsWith(\"");
#line 438 "MethodBodyTemplateRestCall.cshtml"
                                 Write(property.HeaderCollectionPrefix);

#line default
#line hidden
            WriteLiteral("\"))\n        {\n            _result.Headers.");
#line 440 "MethodBodyTemplateRestCall.cshtml"
                          Write(property.Name);

#line default
#line hidden
            WriteLiteral("[header.Key.Replace(\"");
#line 440 "MethodBodyTemplateRestCall.cshtml"
                                                               Write(property.HeaderCollectionPrefix);

#line default
#line hidden
            WriteLiteral("\", \"\")] = header.Value.FirstOrDefault() as ");
#line 440 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                            Write((property.ModelType as DictionaryType).ValueType.Name);

#line default
#line hidden
            WriteLiteral(";\n        }\n    }\n");
#line 443 "MethodBodyTemplateRestCall.cshtml"
    }

#line default
#line hidden

            WriteLiteral(@"}
catch (Newtonsoft.Json.JsonException ex)
{
    _httpRequest.Dispose();
    if (_httpResponse != null)
    {
        _httpResponse.Dispose();
    }
    throw new Microsoft.Rest.SerializationException(""Unable to deserialize the headers."", _httpResponse.GetHeadersAsJson().ToString(), ex);
}
");
#line 454 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

            WriteLiteral("\nreturn _result;\n\n");
        }
        #pragma warning restore 1998
    }
}
