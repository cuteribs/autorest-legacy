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
            WriteLiteral(@"
// Tracing
bool _shouldTrace = Microsoft.Rest.ServiceClientTracing.IsEnabled;
string _invocationId = null;
if (_shouldTrace)
{
    _invocationId = Microsoft.Rest.ServiceClientTracing.NextInvocationId.ToString();
    System.Collections.Generic.Dictionary<string, object> tracingParameters = new System.Collections.Generic.Dictionary<string, object>();
");
#line 39 "MethodBodyTemplateRestCall.cshtml"
 foreach (var parameter in Model.LogicalParameters.Where(p => !p.IsClientProperty))
{

#line default
#line hidden

            WriteLiteral("    tracingParameters.Add(\"");
#line 41 "MethodBodyTemplateRestCall.cshtml"
                         Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("\", ");
#line 41 "MethodBodyTemplateRestCall.cshtml"
                                             Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(");\n");
#line 42 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

            WriteLiteral("    tracingParameters.Add(\"cancellationToken\", cancellationToken);\n    Microsoft.Rest.ServiceClientTracing.Enter(_invocationId, this, \"");
#line 44 "MethodBodyTemplateRestCall.cshtml"
                                                                Write(Model.Name);

#line default
#line hidden
            WriteLiteral("\", tracingParameters);\n}\n\n// Construct URL\n");
#line 48 "MethodBodyTemplateRestCall.cshtml"
 if (Model.IsAbsoluteUrl)
{

#line default
#line hidden

            WriteLiteral("string _url = \"");
#line 50 "MethodBodyTemplateRestCall.cshtml"
             Write(Model.Url);

#line default
#line hidden
            WriteLiteral("\";\n");
#line 51 "MethodBodyTemplateRestCall.cshtml"
}
else
{
if (Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("var _baseUrl = ");
#line 56 "MethodBodyTemplateRestCall.cshtml"
             Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".HttpClient.BaseAddress ?? ");
#line 56 "MethodBodyTemplateRestCall.cshtml"
                                                                Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".BaseUri;\nvar _url = _baseUrl + (_baseUrl.EndsWith(\"/\") ? \"\" : \"/\") + \"");
#line 57 "MethodBodyTemplateRestCall.cshtml"
                                                           Write(Model.Url.TrimStart('/'));

#line default
#line hidden
            WriteLiteral("\";\n");
#line 58 "MethodBodyTemplateRestCall.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("var _baseUrl = ");
#line 61 "MethodBodyTemplateRestCall.cshtml"
             Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".HttpClient.BaseAddress.AbsoluteUri; ?? ");
#line 61 "MethodBodyTemplateRestCall.cshtml"
                                                                             Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".BaseUri.AbsoluteUri;\nvar _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith(\"/\") ? \"\" : \"/\")), \"");
#line 62 "MethodBodyTemplateRestCall.cshtml"
                                                                                         Write(Model.Url.TrimStart('/'));

#line default
#line hidden
            WriteLiteral("\").ToString();\n");
#line 63 "MethodBodyTemplateRestCall.cshtml"
}    
}

#line default
#line hidden

#line 65 "MethodBodyTemplateRestCall.cshtml"
Write(Model.BuildUrl("_url"));

#line default
#line hidden
            WriteLiteral("\n// Create HTTP transport objects\nvar _httpRequest = new System.Net.Http.HttpRequestMessage();\nSystem.Net.Http.HttpResponseMessage _httpResponse = null;\n\n_httpRequest.Method = new System.Net.Http.HttpMethod(\"");
#line 70 "MethodBodyTemplateRestCall.cshtml"
                                                  Write(Model.HttpMethod.ToString().ToUpper());

#line default
#line hidden
            WriteLiteral("\");\n_httpRequest.RequestUri = new System.Uri(_url);\n// Set Headers\n");
#line 73 "MethodBodyTemplateRestCall.cshtml"
Write(Model.SetDefaultHeaders);

#line default
#line hidden
            WriteLiteral("\n");
#line 74 "MethodBodyTemplateRestCall.cshtml"
 foreach (var parameter in Model.LogicalParameters.OfType<ParameterCs>().Where(p => p.Location == ParameterLocation.Header && !p.IsHeaderCollection && !p.IsContentTypeHeader))
{
    if (!parameter.IsNullable())
    {

#line default
#line hidden

            WriteLiteral("if (_httpRequest.Headers.Contains(\"");
#line 78 "MethodBodyTemplateRestCall.cshtml"
                                 Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\"))\n{\n    _httpRequest.Headers.Remove(\"");
#line 80 "MethodBodyTemplateRestCall.cshtml"
                               Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\");\n}\n_httpRequest.Headers.TryAddWithoutValidation(\"");
#line 82 "MethodBodyTemplateRestCall.cshtml"
                                            Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 82 "MethodBodyTemplateRestCall.cshtml"
                                                                         Write(parameter.ModelType.ToString(Model.ClientReference, parameter.Name));

#line default
#line hidden
            WriteLiteral(");\n");
#line 83 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("if (");
#line 86 "MethodBodyTemplateRestCall.cshtml"
  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n    if (_httpRequest.Headers.Contains(\"");
#line 88 "MethodBodyTemplateRestCall.cshtml"
                                     Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\"))\n    {\n        _httpRequest.Headers.Remove(\"");
#line 90 "MethodBodyTemplateRestCall.cshtml"
                                   Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\");\n    }\n    _httpRequest.Headers.TryAddWithoutValidation(\"");
#line 92 "MethodBodyTemplateRestCall.cshtml"
                                                Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 92 "MethodBodyTemplateRestCall.cshtml"
                                                                             Write(parameter.ModelType.ToString(Model.ClientReference, parameter.Name));

#line default
#line hidden
            WriteLiteral(");\n}\n");
#line 94 "MethodBodyTemplateRestCall.cshtml"
    }
}

#line default
#line hidden

#line 96 "MethodBodyTemplateRestCall.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 97 "MethodBodyTemplateRestCall.cshtml"
 foreach (var parameter in Model.LogicalParameters.OfType<ParameterCs>().Where(p => p.Location == ParameterLocation.Header && p.IsHeaderCollection))
{

#line default
#line hidden

            WriteLiteral("if (");
#line 99 "MethodBodyTemplateRestCall.cshtml"
  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n    foreach (var _header in ");
#line 101 "MethodBodyTemplateRestCall.cshtml"
                          Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(")\n    {\n        var key = \"");
#line 103 "MethodBodyTemplateRestCall.cshtml"
                 Write(parameter.HeaderCollectionPrefix);

#line default
#line hidden
            WriteLiteral("\" + _header.Key;\n        if (_httpRequest.Headers.Contains(key))\n        {\n            _httpRequest.Headers.Remove(key);\n        }\n        _httpRequest.Headers.TryAddWithoutValidation(key, _header.Value);\n    }\n}\n");
#line 111 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

#line 112 "MethodBodyTemplateRestCall.cshtml"
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
#line 124 "MethodBodyTemplateRestCall.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n\n// Serialize Request\nstring _requestContent = null;\n");
#line 128 "MethodBodyTemplateRestCall.cshtml"
 if (Model.RequestBody != null)
{
    if (Model.RequestBody.ModelType.IsPrimaryType(KnownPrimaryType.Stream))
    {
        if (Model.RequestBody.IsRequired)
        {

#line default
#line hidden

            WriteLiteral("if(");
#line 134 "MethodBodyTemplateRestCall.cshtml"
 Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" == null)\n{\n  throw new System.ArgumentNullException(\"");
#line 136 "MethodBodyTemplateRestCall.cshtml"
                                        Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral("\");\n}\n");
#line 138 "MethodBodyTemplateRestCall.cshtml"
        }

#line default
#line hidden

            WriteLiteral("\nif (");
#line 140 "MethodBodyTemplateRestCall.cshtml"
Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" != null && ");
#line 140 "MethodBodyTemplateRestCall.cshtml"
                                     Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" != System.IO.Stream.Null)\n{\n    _httpRequest.Content = new System.Net.Http.StreamContent(");
#line 142 "MethodBodyTemplateRestCall.cshtml"
                                                         Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(");\n    _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(");
#line 143 "MethodBodyTemplateRestCall.cshtml"
                                                                                             Write(((Func<Parameter, string>)(p => p != null ? (p.Name.Value + ((p.ModelType as EnumType)?.ModelAsString == false ? ".ToSerializedValue()" : "")) : $"\"{Model.RequestContentType}\"" ))(Model.LocalParameters.FirstOrDefault(p => p.IsContentTypeHeader)));

#line default
#line hidden
            WriteLiteral(");\n}\n    ");
#line 145 "MethodBodyTemplateRestCall.cshtml"
           
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
#line 154 "MethodBodyTemplateRestCall.cshtml"
                                             Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\", System.Linq.Enumerable.Select(");
#line 154 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                   Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", x => x.XmlSerialize(new System.Xml.Linq.XElement(\"");
#line 154 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                                Write((Model.RequestBody.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\")))).ToString();\n");
#line 155 "MethodBodyTemplateRestCall.cshtml"
                }
                else if (Model.RequestBody.ModelType is SequenceType)
                { // for primitive sequences for now

#line default
#line hidden

            WriteLiteral("_requestContent = new System.Xml.Linq.XElement(\"");
#line 158 "MethodBodyTemplateRestCall.cshtml"
                                             Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\", System.Linq.Enumerable.Select(");
#line 158 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                   Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", x => new System.Xml.Linq.XElement(\"");
#line 158 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                 Write((Model.RequestBody.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\", x))).ToString();\n");
#line 159 "MethodBodyTemplateRestCall.cshtml"
                }
                else
                {

#line default
#line hidden

            WriteLiteral("_requestContent = ");
#line 162 "MethodBodyTemplateRestCall.cshtml"
                Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(".XmlSerialize( new System.Xml.Linq.XElement(\"");
#line 162 "MethodBodyTemplateRestCall.cshtml"
                                                                                     Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\") ).ToString(); \n_requestContent = $\"<?xml version=\\\"1.0\\\" encoding=\\\"utf-8\\\" ?>\\n{_requestContent}\";\n");
#line 164 "MethodBodyTemplateRestCall.cshtml"
                }

#line default
#line hidden

            WriteLiteral("_httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);\n_httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(\"");
#line 166 "MethodBodyTemplateRestCall.cshtml"
                                                                                            Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\");\n");
#line 167 "MethodBodyTemplateRestCall.cshtml"
            }
            else {

#line default
#line hidden

            WriteLiteral("if(");
#line 169 "MethodBodyTemplateRestCall.cshtml"
 Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n");
#line 171 "MethodBodyTemplateRestCall.cshtml"
                if (Model.RequestBody.ModelType is SequenceType && (Model.RequestBody.ModelType as SequenceType).ElementType is CompositeType)
                { // for primitive sequences for now

#line default
#line hidden

            WriteLiteral("    _requestContent = new System.Xml.Linq.XElement(\"");
#line 173 "MethodBodyTemplateRestCall.cshtml"
                                                 Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\", System.Linq.Enumerable.Select(");
#line 173 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                       Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", x => x.XmlSerialize(new System.Xml.Linq.XElement(\"");
#line 173 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                                    Write((Model.RequestBody.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\")))).ToString();\n");
#line 174 "MethodBodyTemplateRestCall.cshtml"
                }
                else if (Model.RequestBody.ModelType is SequenceType)
                { // for primitive sequences for now

#line default
#line hidden

            WriteLiteral("    _requestContent = new System.Xml.Linq.XElement(\"");
#line 177 "MethodBodyTemplateRestCall.cshtml"
                                                 Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\", System.Linq.Enumerable.Select(");
#line 177 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                       Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", x => new System.Xml.Linq.XElement(\"");
#line 177 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                     Write((Model.RequestBody.ModelType as SequenceType).ElementXmlName);

#line default
#line hidden
            WriteLiteral("\", x))).ToString();\n");
#line 178 "MethodBodyTemplateRestCall.cshtml"
                }
                else
                {

#line default
#line hidden

            WriteLiteral("    _requestContent = ");
#line 181 "MethodBodyTemplateRestCall.cshtml"
                    Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(".XmlSerialize( new System.Xml.Linq.XElement(\"");
#line 181 "MethodBodyTemplateRestCall.cshtml"
                                                                                         Write(Model.RequestBody.ModelType.XmlName);

#line default
#line hidden
            WriteLiteral("\") ).ToString(); \n    _requestContent = $\"<?xml version=\\\"1.0\\\" encoding=\\\"utf-8\\\" ?>\\n{_requestContent}\";\n");
#line 183 "MethodBodyTemplateRestCall.cshtml"
                }

#line default
#line hidden

            WriteLiteral("    _httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);\n    _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(\"");
#line 185 "MethodBodyTemplateRestCall.cshtml"
                                                                                                Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\");\n}\n");
#line 187 "MethodBodyTemplateRestCall.cshtml"
            }
        }
        else
        {
            if (!Model.RequestBody.IsNullable()) {

#line default
#line hidden

            WriteLiteral("\n_requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(");
#line 192 "MethodBodyTemplateRestCall.cshtml"
                                                                           Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", ");
#line 192 "MethodBodyTemplateRestCall.cshtml"
                                                                                                      Write(Model.GetSerializationSettingsReference(Model.RequestBody.ModelType));

#line default
#line hidden
            WriteLiteral(");\n_httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);\n_httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(\"");
#line 194 "MethodBodyTemplateRestCall.cshtml"
                                                                                          Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\");");
#line 194 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                   
            }
            else {

#line default
#line hidden

            WriteLiteral("\nif(");
#line 197 "MethodBodyTemplateRestCall.cshtml"
Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n    _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(");
#line 199 "MethodBodyTemplateRestCall.cshtml"
                                                                               Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", ");
#line 199 "MethodBodyTemplateRestCall.cshtml"
                                                                                                          Write(Model.GetSerializationSettingsReference(Model.RequestBody.ModelType));

#line default
#line hidden
            WriteLiteral(");\n    _httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);\n    _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse(\"");
#line 201 "MethodBodyTemplateRestCall.cshtml"
                                                                                              Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\");\n}");
#line 202 "MethodBodyTemplateRestCall.cshtml"
        
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
#line 212 "MethodBodyTemplateRestCall.cshtml"
    foreach (ParameterCs parameter in Model.LogicalParameters.Where(p => p.Location == ParameterLocation.FormData))
    {

#line default
#line hidden

            WriteLiteral("if (");
#line 214 "MethodBodyTemplateRestCall.cshtml"
  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n");
#line 216 "MethodBodyTemplateRestCall.cshtml"
    

#line default
#line hidden

#line 216 "MethodBodyTemplateRestCall.cshtml"
       string localParam = "_"+ @parameter.Name.Value.Replace("this.", ""); 

#line default
#line hidden

#line 216 "MethodBodyTemplateRestCall.cshtml"
                                                                             
    if (parameter.ModelType.IsPrimaryType(KnownPrimaryType.Stream))
    {

#line default
#line hidden

            WriteLiteral("        \n    System.Net.Http.StreamContent _");
#line 220 "MethodBodyTemplateRestCall.cshtml"
                              Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" = new System.Net.Http.StreamContent(");
#line 220 "MethodBodyTemplateRestCall.cshtml"
                                                                                  Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(");\n    ");
#line 221 "MethodBodyTemplateRestCall.cshtml"
Write(localParam);

#line default
#line hidden
            WriteLiteral(@".Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(""application/octet-stream"");
    System.Net.Http.Headers.ContentDispositionHeaderValue _contentDispositionHeaderValue = new System.Net.Http.Headers.ContentDispositionHeaderValue(""form-data"");
    _contentDispositionHeaderValue.Name = """);
#line 223 "MethodBodyTemplateRestCall.cshtml"
                                       Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\";\n\n    // get filename from stream if it\'s a file otherwise, just use  \'unknown\'\n    var _fileStream = ");
#line 226 "MethodBodyTemplateRestCall.cshtml"
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
#line 240 "MethodBodyTemplateRestCall.cshtml"
Write(localParam);

#line default
#line hidden
            WriteLiteral(".Headers.ContentDisposition = _contentDispositionHeaderValue;        \n\n");
#line 242 "MethodBodyTemplateRestCall.cshtml"
       
        }
        else
        {

#line default
#line hidden

            WriteLiteral("    System.Net.Http.StringContent ");
#line 246 "MethodBodyTemplateRestCall.cshtml"
                                Write(localParam);

#line default
#line hidden
            WriteLiteral(" = new System.Net.Http.StringContent(");
#line 246 "MethodBodyTemplateRestCall.cshtml"
                                                                                  Write(parameter.ModelType.ToString(Model.ClientReference, parameter.Name));

#line default
#line hidden
            WriteLiteral(", System.Text.Encoding.UTF8);\n");
#line 247 "MethodBodyTemplateRestCall.cshtml"
        }

#line default
#line hidden

            WriteLiteral("    _multiPartContent.Add(");
#line 248 "MethodBodyTemplateRestCall.cshtml"
                        Write(localParam);

#line default
#line hidden
            WriteLiteral(", \"");
#line 248 "MethodBodyTemplateRestCall.cshtml"
                                        Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\");\n}\n");
#line 250 "MethodBodyTemplateRestCall.cshtml"
    }

#line default
#line hidden

            WriteLiteral("_httpRequest.Content = _multiPartContent;\n");
#line 252 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("var values = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>();\n");
#line 256 "MethodBodyTemplateRestCall.cshtml"
    foreach (ParameterCs parameter in Model.LogicalParameters.Where(p => p.Location == ParameterLocation.FormData))
    {

#line default
#line hidden

            WriteLiteral("if(");
#line 258 "MethodBodyTemplateRestCall.cshtml"
 Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" != null)\n{\n    values.Add(new System.Collections.Generic.KeyValuePair<string,string>(\"");
#line 260 "MethodBodyTemplateRestCall.cshtml"
                                                                         Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\", ");
#line 260 "MethodBodyTemplateRestCall.cshtml"
                                                                                                      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("));\n}\n");
#line 262 "MethodBodyTemplateRestCall.cshtml"
    }

#line default
#line hidden

            WriteLiteral("var _formContent = new System.Net.Http.FormUrlEncodedContent(values);\n_httpRequest.Content = _formContent;\n");
#line 265 "MethodBodyTemplateRestCall.cshtml"
    }
}

#line default
#line hidden

            WriteLiteral("\n");
#line 268 "MethodBodyTemplateRestCall.cshtml"
 if (Settings.AddCredentials)
{

#line default
#line hidden

            WriteLiteral("\n// Set Credentials\nif (");
#line 272 "MethodBodyTemplateRestCall.cshtml"
Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".Credentials != null)\n{\n    cancellationToken.ThrowIfCancellationRequested();\n    await ");
#line 275 "MethodBodyTemplateRestCall.cshtml"
      Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);\n}\n    ");
#line 277 "MethodBodyTemplateRestCall.cshtml"
           
}

#line default
#line hidden

            WriteLiteral("\n// Send Request\nif (_shouldTrace)\n{\n    Microsoft.Rest.ServiceClientTracing.SendRequest(_invocationId, _httpRequest);\n}\n\ncancellationToken.ThrowIfCancellationRequested();\n");
#line 287 "MethodBodyTemplateRestCall.cshtml"
 if (Model.ReturnType.Body.IsPrimaryType(KnownPrimaryType.Stream) || Model.HttpMethod == HttpMethod.Head)
{

#line default
#line hidden

            WriteLiteral("_httpResponse = await ");
#line 289 "MethodBodyTemplateRestCall.cshtml"
                    Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".HttpClient.SendAsync(_httpRequest, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);\n");
#line 290 "MethodBodyTemplateRestCall.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("_httpResponse = await ");
#line 293 "MethodBodyTemplateRestCall.cshtml"
                    Write(Model.ClientReference);

#line default
#line hidden
            WriteLiteral(".HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);\n");
#line 294 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

            WriteLiteral(@"if (_shouldTrace)
{
    Microsoft.Rest.ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
}

System.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;
cancellationToken.ThrowIfCancellationRequested();
string _responseContent = null;

if (");
#line 304 "MethodBodyTemplateRestCall.cshtml"
Write(Model.FailureStatusCodePredicate);

#line default
#line hidden
            WriteLiteral(")\n{\n    var ex = new ");
#line 306 "MethodBodyTemplateRestCall.cshtml"
             Write(Model.OperationExceptionTypeString);

#line default
#line hidden
            WriteLiteral("(string.Format(\"Operation returned an invalid status code \'{0}\'\", _statusCode));\n");
#line 307 "MethodBodyTemplateRestCall.cshtml"
 if (Model.DefaultResponse.Body != null)
{

#line default
#line hidden

            WriteLiteral("    try\n    {\n");
#line 311 "MethodBodyTemplateRestCall.cshtml"
        if (Model.DefaultResponse.Body.IsPrimaryType(KnownPrimaryType.Stream))
        {

#line default
#line hidden

            WriteLiteral("        ");
#line 313 "MethodBodyTemplateRestCall.cshtml"
      Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(" _errorBody = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);\n");
#line 314 "MethodBodyTemplateRestCall.cshtml"
        }
        else
        {

#line default
#line hidden

            WriteLiteral("        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);\n        ");
#line 318 "MethodBodyTemplateRestCall.cshtml"
      Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(" _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 318 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                  Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(">(_responseContent, ");
#line 318 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                                    Write(Model.GetDeserializationSettingsReference(Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral(");\n");
#line 319 "MethodBodyTemplateRestCall.cshtml"
        }

#line default
#line hidden

            WriteLiteral("        if (_errorBody != null)\n        {\n            ");
#line 322 "MethodBodyTemplateRestCall.cshtml"
          Write(Model.InitializeExceptionWithMessage);

#line default
#line hidden
            WriteLiteral("\n            ex.Body = _errorBody;\n        }\n    }\n    catch (Newtonsoft.Json.JsonException)\n    {\n        // Ignore the exception\n    }\n");
#line 330 "MethodBodyTemplateRestCall.cshtml"
}
else
{
    //If not defined by default model, read content as string

#line default
#line hidden

            WriteLiteral("    if (_httpResponse.Content != null) {\n        _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);\n    }\n    else {\n        _responseContent = string.Empty;\n    }\n");
#line 340 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n    ex.Request = new Microsoft.Rest.HttpRequestMessageWrapper(_httpRequest, _requestContent);\n    ex.Response = new Microsoft.Rest.HttpResponseMessageWrapper(_httpResponse, _responseContent);\n    ");
#line 344 "MethodBodyTemplateRestCall.cshtml"
Write(Model.InitializeException);

#line default
#line hidden
            WriteLiteral(@"
    if (_shouldTrace)
    {
        Microsoft.Rest.ServiceClientTracing.Error(_invocationId, ex);
    }

    _httpRequest.Dispose();
    if (_httpResponse != null)
    {
        _httpResponse.Dispose();
    }
    throw ex;
}

// Create Result
var _result = new ");
#line 359 "MethodBodyTemplateRestCall.cshtml"
              Write(Model.OperationResponseReturnTypeString);

#line default
#line hidden
            WriteLiteral("();\n_result.Request = _httpRequest;\n_result.Response = _httpResponse;\n");
#line 362 "MethodBodyTemplateRestCall.cshtml"
Write(Model.InitializeResponseBody);

#line default
#line hidden
            WriteLiteral("\n\n");
#line 364 "MethodBodyTemplateRestCall.cshtml"
 foreach (var responsePair in Model.Responses.Where(r => r.Value.Body != null))
{

#line default
#line hidden

            WriteLiteral("\n// Deserialize Response\nif ((int)_statusCode == ");
#line 368 "MethodBodyTemplateRestCall.cshtml"
                   Write(MethodCs.GetStatusCodeReference(responsePair.Key));

#line default
#line hidden
            WriteLiteral(")\n{\n");
#line 370 "MethodBodyTemplateRestCall.cshtml"
    

#line default
#line hidden

#line 370 "MethodBodyTemplateRestCall.cshtml"
     if (responsePair.Value.Body.IsPrimaryType(KnownPrimaryType.Stream))
    {

#line default
#line hidden

            WriteLiteral("    _result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);\n");
#line 373 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("\n    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);\n    try\n    {\n");
#line 379 "MethodBodyTemplateRestCall.cshtml"
        

#line default
#line hidden

#line 379 "MethodBodyTemplateRestCall.cshtml"
         if (Model.CodeModel.ShouldGenerateXmlSerialization)
        {

#line default
#line hidden

            WriteLiteral("\n        ");
#line 381 "MethodBodyTemplateRestCall.cshtml"
   Write(responsePair.Value.Body.AsNullableType(Model.IsXNullableReturnType));

#line default
#line hidden
            WriteLiteral(" _tmp_ = null;\n        if (_httpResponse.Content.Headers.ContentType.MediaType == \"application/xml\" &&\n            ");
#line 383 "MethodBodyTemplateRestCall.cshtml"
        Write(XmlSerialization.XmlDeserializationClass);

#line default
#line hidden
            WriteLiteral(".Root(");
#line 383 "MethodBodyTemplateRestCall.cshtml"
                                                         Write(XmlSerialization.GenerateDeserializer(Model.CodeModel, responsePair.Value.Body));

#line default
#line hidden
            WriteLiteral(")(System.Xml.Linq.XElement.Parse(_responseContent), out _tmp_))\n        {\n            _result.Body = _tmp_;\n        }\n        else\n        {\n            _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 389 "MethodBodyTemplateRestCall.cshtml"
                                                                                      Write(responsePair.Value.Body.AsNullableType(Model.IsXNullableReturnType));

#line default
#line hidden
            WriteLiteral(">(_responseContent, ");
#line 389 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                                Write(Model.GetDeserializationSettingsReference(responsePair.Value.Body));

#line default
#line hidden
            WriteLiteral(");\n        }\n");
#line 391 "MethodBodyTemplateRestCall.cshtml"
       
        }
        else
        {

#line default
#line hidden

            WriteLiteral("\n        _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 395 "MethodBodyTemplateRestCall.cshtml"
                                                                                  Write(responsePair.Value.Body.AsNullableType(Model.IsXNullableReturnType));

#line default
#line hidden
            WriteLiteral(">(_responseContent, ");
#line 395 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                                            Write(Model.GetDeserializationSettingsReference(responsePair.Value.Body));

#line default
#line hidden
            WriteLiteral(");\n");
#line 396 "MethodBodyTemplateRestCall.cshtml"
       
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
#line 408 "MethodBodyTemplateRestCall.cshtml"
       
    }

#line default
#line hidden

            WriteLiteral("}\n");
#line 411 "MethodBodyTemplateRestCall.cshtml"
       
}

#line default
#line hidden

            WriteLiteral("\n");
#line 414 "MethodBodyTemplateRestCall.cshtml"
 if (Model.ReturnType.Body != null && Model.DefaultResponse.Body != null && !Model.Responses.Any())
{
    if (Model.DefaultResponse.Body.IsPrimaryType(KnownPrimaryType.Stream))
    {

#line default
#line hidden

            WriteLiteral("_result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);\n");
#line 419 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("string _defaultResponseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);\ntry\n{\n");
#line 425 "MethodBodyTemplateRestCall.cshtml"
    if (Model.CodeModel.ShouldGenerateXmlSerialization)
    {

#line default
#line hidden

            WriteLiteral("     ");
#line 427 "MethodBodyTemplateRestCall.cshtml"
  Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(" _tmp_ = null;\n     if (_httpResponse.Content.Headers.ContentType.MediaType == \"application/xml\" &&\n         ");
#line 429 "MethodBodyTemplateRestCall.cshtml"
       Write(XmlSerialization.XmlDeserializationClass);

#line default
#line hidden
            WriteLiteral(".Root(");
#line 429 "MethodBodyTemplateRestCall.cshtml"
                                                        Write(XmlSerialization.GenerateDeserializer(Model.CodeModel, Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral(")(System.Xml.Linq.XElement.Parse(_defaultResponseContent), out _tmp_))\n    {\n       _result.Body = _tmp_;\n    } else \n    {\n        _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 434 "MethodBodyTemplateRestCall.cshtml"
                                                                                    Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(">(_defaultResponseContent, ");
#line 434 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                             Write(Model.GetDeserializationSettingsReference(Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral(");\n    }\n");
#line 436 "MethodBodyTemplateRestCall.cshtml"
    }
    else
    {

#line default
#line hidden

            WriteLiteral("    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<");
#line 439 "MethodBodyTemplateRestCall.cshtml"
                                                                                Write(Model.DefaultResponse.Body.AsNullableType());

#line default
#line hidden
            WriteLiteral(">(_defaultResponseContent, ");
#line 439 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                                         Write(Model.GetDeserializationSettingsReference(Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral(");\n");
#line 440 "MethodBodyTemplateRestCall.cshtml"
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
#line 451 "MethodBodyTemplateRestCall.cshtml"
    }
}

#line default
#line hidden

            WriteLiteral("\n");
#line 454 "MethodBodyTemplateRestCall.cshtml"
 if (Model.ReturnType.Headers != null)
{


#line default
#line hidden

            WriteLiteral("try\n{\n    _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<");
#line 459 "MethodBodyTemplateRestCall.cshtml"
                                                              Write(Model.ReturnType.Headers.Name);

#line default
#line hidden
            WriteLiteral(">(Newtonsoft.Json.JsonSerializer.Create(");
#line 459 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                      Write(Model.GetDeserializationSettingsReference(Model.DefaultResponse.Body));

#line default
#line hidden
            WriteLiteral("));\n");
#line 460 "MethodBodyTemplateRestCall.cshtml"
    foreach (var property in (Model.ReturnType.Headers as CompositeType).Properties.OfType<PropertyCs>().Where(p => p.IsHeaderCollection))
    {

#line default
#line hidden

            WriteLiteral("    _result.Headers.");
#line 462 "MethodBodyTemplateRestCall.cshtml"
                  Write(property.Name);

#line default
#line hidden
            WriteLiteral(" = new ");
#line 462 "MethodBodyTemplateRestCall.cshtml"
                                         Write(property.ModelTypeName.Replace("IDictionary", "Dictionary"));

#line default
#line hidden
            WriteLiteral("();\n    foreach (var header in _httpResponse.Headers)\n    {\n        if (header.Key.StartsWith(\"");
#line 465 "MethodBodyTemplateRestCall.cshtml"
                                 Write(property.HeaderCollectionPrefix);

#line default
#line hidden
            WriteLiteral("\"))\n        {\n            _result.Headers.");
#line 467 "MethodBodyTemplateRestCall.cshtml"
                          Write(property.Name);

#line default
#line hidden
            WriteLiteral("[header.Key.Replace(\"");
#line 467 "MethodBodyTemplateRestCall.cshtml"
                                                               Write(property.HeaderCollectionPrefix);

#line default
#line hidden
            WriteLiteral("\", \"\")] = header.Value.FirstOrDefault() as ");
#line 467 "MethodBodyTemplateRestCall.cshtml"
                                                                                                                                            Write((property.ModelType as DictionaryType).ValueType.Name);

#line default
#line hidden
            WriteLiteral(";\n        }\n    }\n");
#line 470 "MethodBodyTemplateRestCall.cshtml"
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
#line 481 "MethodBodyTemplateRestCall.cshtml"
}

#line default
#line hidden

            WriteLiteral("\nif (_shouldTrace)\n{\n    Microsoft.Rest.ServiceClientTracing.Exit(_invocationId, _result);\n}\n\nreturn _result;\n\n");
        }
        #pragma warning restore 1998
    }
}
