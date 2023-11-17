// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.vanilla.Templates
{
#line 1 "MethodTemplate.cshtml"
using System;

#line default
#line hidden
#line 2 "MethodTemplate.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "MethodTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "MethodTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "MethodTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 6 "MethodTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
#line 7 "MethodTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class MethodTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Model.MethodPy>
    {
        #line hidden
        public MethodTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 9 "MethodTemplate.cshtml"
  
string methodName = Model.Name.ToPythonCase();
string defKeyword = AsyncMode? "async def" : "def";
string trace_decorator = "";

#line default
#line hidden

#line 14 "MethodTemplate.cshtml"
 if (Model.AddTracingDecorators)
{
trace_decorator = AsyncMode? "@distributed_trace_async" : "@distributed_trace";
}

#line default
#line hidden

            WriteLiteral("    ");
#line 18 "MethodTemplate.cshtml"
Write(trace_decorator);

#line default
#line hidden
            WriteLiteral("\n    ");
#line 19 "MethodTemplate.cshtml"
Write(defKeyword);

#line default
#line hidden
            WriteLiteral(" ");
#line 19 "MethodTemplate.cshtml"
              Write(methodName);

#line default
#line hidden
            WriteLiteral("(self, ");
#line 19 "MethodTemplate.cshtml"
                                  Write(Model.MethodParameterDeclaration(Python3Mode));

#line default
#line hidden
            WriteLiteral(", **kwargs):\n        \"\"\"");
#line 20 "MethodTemplate.cshtml"
       Write(WrapComment(string.Empty, Model.BuildSummaryAndDescriptionString()));

#line default
#line hidden
            WriteLiteral("\n");
#line 21 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 22 "MethodTemplate.cshtml"
 if (Model.Deprecated)
{

#line default
#line hidden

            WriteLiteral("        .. warning::\n           This method is deprecated\n");
#line 26 "MethodTemplate.cshtml"

#line default
#line hidden

#line 26 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 26 "MethodTemplate.cshtml"
          
}

#line default
#line hidden

#line 28 "MethodTemplate.cshtml"
 foreach(var parameter in Model.DocumentationParameters)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 30 "MethodTemplate.cshtml"
     Write(ParameterWrapComment(string.Empty, MethodPy.GetParameterDocumentationString(parameter)));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 31 "MethodTemplate.cshtml"
     Write(ParameterWrapComment(string.Empty, ":type " + parameter.Name + ": " + Model.GetDocumentationType(parameter.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 32 "MethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 33 "MethodTemplate.cshtml"
   Write(ParameterWrapComment(string.Empty, ":param callable cls: A custom type or function that will be passed the direct response"));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 34 "MethodTemplate.cshtml"
   Write(ParameterWrapComment(string.Empty, string.Format(":return: {0} or the result of cls(response)", Model.GetDocumentationTypeName(Model.ReturnType.Body))));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 35 "MethodTemplate.cshtml"
   Write(ParameterWrapComment(string.Empty, string.Format(":rtype: {0}", Model.GetReturnTypeDocumentation(Model.ReturnType.Body))));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 36 "MethodTemplate.cshtml"
   Write(ParameterWrapComment(string.Empty, string.Format(":raises: {0}", Model.ExceptionDocumentation)));

#line default
#line hidden
            WriteLiteral("\n        \"\"\"\n");
#line 38 "MethodTemplate.cshtml"
 if (Model.Deprecated)
{

#line default
#line hidden

            WriteLiteral("        warnings.warn(\'Method ");
#line 40 "MethodTemplate.cshtml"
                           Write(methodName);

#line default
#line hidden
            WriteLiteral(" is deprecated\', DeprecationWarning)\n");
#line 41 "MethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        error_map = kwargs.pop(\'error_map\', None)\n        ");
#line 43 "MethodTemplate.cshtml"
   Write(Model.BuildInputMappings());

#line default
#line hidden
            WriteLiteral("\n");
#line 44 "MethodTemplate.cshtml"
 if (Model.InputParameterTransformation.Any())
{

#line default
#line hidden

#line 46 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 46 "MethodTemplate.cshtml"
          
}

#line default
#line hidden

#line 48 "MethodTemplate.cshtml"
 if (Model.ConstantParameters.Any())
{
	foreach (var parameter in Model.ConstantParameters)
	{

#line default
#line hidden

            WriteLiteral("        ");
#line 52 "MethodTemplate.cshtml"
      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 52 "MethodTemplate.cshtml"
                          Write(parameter.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 53 "MethodTemplate.cshtml"
	}

#line default
#line hidden

#line 54 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 54 "MethodTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("        # Construct URL\n        url = self.");
#line 57 "MethodTemplate.cshtml"
               Write(methodName);

#line default
#line hidden
            WriteLiteral(".metadata[\'url\']\n        ");
#line 58 "MethodTemplate.cshtml"
    Write(Model.BuildUrlPath("url", Model.LogicalParameters));

#line default
#line hidden
            WriteLiteral("\n");
#line 59 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        # Construct parameters\n        query_parameters = {}\n        ");
#line 62 "MethodTemplate.cshtml"
    Write(Model.BuildUrlQuery("query_parameters", Model.LogicalParameters));

#line default
#line hidden
            WriteLiteral("\n");
#line 63 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        # Construct headers\n        header_parameters = {}\n");
#line 66 "MethodTemplate.cshtml"
 if (Model.HasAnyResponse)
{

#line default
#line hidden

            WriteLiteral("        header_parameters[\'Accept\'] = \'");
#line 68 "MethodTemplate.cshtml"
                                     Write(Model.AcceptContentType);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 69 "MethodTemplate.cshtml"
}

#line default
#line hidden

#line 70 "MethodTemplate.cshtml"
 if (Model.RequestBody != null || Model.IsFormData)
{

#line default
#line hidden

            WriteLiteral("        header_parameters[\'Content-Type\'] = \'");
#line 72 "MethodTemplate.cshtml"
                                           Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 73 "MethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 74 "MethodTemplate.cshtml"
    Write(Model.SetDefaultHeaders);

#line default
#line hidden
            WriteLiteral("\n        ");
#line 75 "MethodTemplate.cshtml"
    Write(Model.BuildHeaders("header_parameters"));

#line default
#line hidden
            WriteLiteral("\n");
#line 76 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 77 "MethodTemplate.cshtml"
 if (Model.RequestBody != null)
{

#line default
#line hidden

            WriteLiteral("        # Construct body\n");
#line 80 "MethodTemplate.cshtml"

#line default
#line hidden

#line 80 "MethodTemplate.cshtml"
 if (!Model.IsStreamRequestBody)
  {
        // Right now, just generate the serialization context if it's a sequence type. Could be smarter later
        string serializationContext = "";
        string is_xml = "";
        if(Model.ShouldGenerateXmlSerialization)
        {
                var serializationContextContent = Model.BuildSerializationContext();
                if(!string.IsNullOrEmpty(serializationContextContent))
                {
                        serializationContext = ", serialization_ctxt=serialization_ctxt";

#line default
#line hidden

            WriteLiteral("        serialization_ctxt = ");
#line 91 "MethodTemplate.cshtml"
                          Write(serializationContextContent);

#line default
#line hidden
            WriteLiteral("\n");
#line 92 "MethodTemplate.cshtml"
                }
        }
        else if(Model.CodeModel.ShouldGenerateXmlSerialization)
        {
                is_xml = ", is_xml=False";
        }
        if (Model.RequestBody.IsRequired)
        {

#line default
#line hidden

            WriteLiteral("        body_content = self._serialize.body(");
#line 100 "MethodTemplate.cshtml"
                                         Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", \'");
#line 100 "MethodTemplate.cshtml"
                                                                    Write(Model.RequestBody.ModelType.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\'");
#line 100 "MethodTemplate.cshtml"
                                                                                                                               Write(is_xml);

#line default
#line hidden
#line 100 "MethodTemplate.cshtml"
                                                                                                                                       Write(serializationContext);

#line default
#line hidden
            WriteLiteral(")\n");
#line 101 "MethodTemplate.cshtml"
        }
        else
        {

#line default
#line hidden

            WriteLiteral("        if ");
#line 104 "MethodTemplate.cshtml"
        Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" is not None:\n            body_content = self._serialize.body(");
#line 105 "MethodTemplate.cshtml"
                                             Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", \'");
#line 105 "MethodTemplate.cshtml"
                                                                        Write(Model.RequestBody.ModelType.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\'");
#line 105 "MethodTemplate.cshtml"
                                                                                                                                   Write(is_xml);

#line default
#line hidden
#line 105 "MethodTemplate.cshtml"
                                                                                                                                           Write(serializationContext);

#line default
#line hidden
            WriteLiteral(")\n        else:\n            body_content = None\n");
#line 108 "MethodTemplate.cshtml"
        }
  }

#line default
#line hidden

#line 109 "MethodTemplate.cshtml"
   

#line default
#line hidden

#line 110 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 110 "MethodTemplate.cshtml"
          
}
else if (Model.IsFormData)
{

#line default
#line hidden

            WriteLiteral("        # Construct form data\n        form_data_content = {\n");
#line 116 "MethodTemplate.cshtml"
  foreach (var parameter in Model.LocalParameters)
  {
    if (parameter.Location == ParameterLocation.FormData)
    {

#line default
#line hidden

            WriteLiteral("            \'");
#line 120 "MethodTemplate.cshtml"
          Write(parameter.SerializedName);

#line default
#line hidden
            WriteLiteral("\': ");
#line 120 "MethodTemplate.cshtml"
                                      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(",\n");
#line 121 "MethodTemplate.cshtml"
    }
  }

#line default
#line hidden

            WriteLiteral("        }\n");
#line 124 "MethodTemplate.cshtml"

#line default
#line hidden

#line 124 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 124 "MethodTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("        # Construct and send request\n");
#line 127 "MethodTemplate.cshtml"
 if (Model.IsFormData)
{

#line default
#line hidden

            WriteLiteral("        request = self._client.");
#line 129 "MethodTemplate.cshtml"
                             Write(MethodPy.GetHttpFunction(Model.HttpMethod));

#line default
#line hidden
            WriteLiteral("(url, query_parameters, header_parameters, form_content=form_data_content)\n");
#line 130 "MethodTemplate.cshtml"
}
else if (Model.IsStreamRequestBody)
{
  foreach (var parameter in Model.LocalParameters)
  {
    if (parameter.Location == ParameterLocation.Body && parameter.ModelType.IsPrimaryType(KnownPrimaryType.Stream))
    {

#line default
#line hidden

            WriteLiteral("        request = self._client.");
#line 137 "MethodTemplate.cshtml"
                             Write(MethodPy.GetHttpFunction(Model.HttpMethod));

#line default
#line hidden
            WriteLiteral("(url, query_parameters, header_parameters, stream_content=");
#line 137 "MethodTemplate.cshtml"
                                                                                                                                   Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(")\n");
#line 138 "MethodTemplate.cshtml"
        break;
    }
  }
}
else if (Model.RequestBody != null)
{

#line default
#line hidden

            WriteLiteral("        request = self._client.");
#line 144 "MethodTemplate.cshtml"
                             Write(MethodPy.GetHttpFunction(Model.HttpMethod));

#line default
#line hidden
            WriteLiteral("(url, query_parameters, header_parameters, body_content)\n");
#line 145 "MethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        request = self._client.");
#line 148 "MethodTemplate.cshtml"
                             Write(MethodPy.GetHttpFunction(Model.HttpMethod));

#line default
#line hidden
            WriteLiteral("(url, query_parameters, header_parameters)\n");
#line 149 "MethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("\n");
#line 151 "MethodTemplate.cshtml"
  string streamParameter = "stream="+(Model.IsStreamResponse?"True":"False");

#line default
#line hidden

#line 152 "MethodTemplate.cshtml"
  string sendCall = Model.GetSendCall(AsyncMode);

#line default
#line hidden

            WriteLiteral("        pipeline_response = ");
#line 153 "MethodTemplate.cshtml"
                        Write(sendCall);

#line default
#line hidden
            WriteLiteral("(request, ");
#line 153 "MethodTemplate.cshtml"
                                             Write(streamParameter);

#line default
#line hidden
            WriteLiteral(", **kwargs)\n        response = pipeline_response.http_response\n");
#line 155 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        if ");
#line 156 "MethodTemplate.cshtml"
      Write(Model.FailureStatusCodePredicate);

#line default
#line hidden
            WriteLiteral(":\n");
#line 157 "MethodTemplate.cshtml"
 if((AsyncMode) && (Model.IsStreamResponse))
{

#line default
#line hidden

            WriteLiteral("            await response.load_body()\n");
#line 160 "MethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            ");
#line 161 "MethodTemplate.cshtml"
       Write(Model.RaisedException);

#line default
#line hidden
            WriteLiteral("\n");
#line 162 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 163 "MethodTemplate.cshtml"
 if (Model.HasAnyResponse)
{
  if (Model.HasResponseHeader)
  {

#line default
#line hidden

            WriteLiteral("        header_dict = {}\n");
#line 168 "MethodTemplate.cshtml"
  }

#line default
#line hidden

            WriteLiteral("        deserialized = None\n");
#line 170 "MethodTemplate.cshtml"
foreach (var responsePair in Model.Responses.Where(r => r.Value.Body != null))
{

#line default
#line hidden

            WriteLiteral("        if response.status_code == ");
#line 172 "MethodTemplate.cshtml"
                                Write(MethodPy.GetStatusCodeReference(responsePair.Key));

#line default
#line hidden
            WriteLiteral(":\n");
#line 173 "MethodTemplate.cshtml"
if (Model.IsStreamResponse)
{

#line default
#line hidden

            WriteLiteral("            deserialized = response.stream_download(self._client._pipeline)\n");
#line 176 "MethodTemplate.cshtml"
}
else
{


#line default
#line hidden

            WriteLiteral("            deserialized = self._deserialize(\'");
#line 180 "MethodTemplate.cshtml"
                                           Write(responsePair.Value.Body.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\', response)\n");
#line 181 "MethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            ");
#line 182 "MethodTemplate.cshtml"
         Write(Model.AddIndividualResponseHeader(responsePair.Key));

#line default
#line hidden
            WriteLiteral("\n");
#line 183 "MethodTemplate.cshtml"
}

#line default
#line hidden

#line 184 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 184 "MethodTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("        if cls:\n            return cls(response, deserialized, ");
#line 186 "MethodTemplate.cshtml"
                                            Write(Model.AddResponseHeader());

#line default
#line hidden
            WriteLiteral(")\n");
#line 187 "MethodTemplate.cshtml"

#line default
#line hidden

#line 187 "MethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 187 "MethodTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("        return deserialized\n");
#line 189 "MethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        ");
#line 192 "MethodTemplate.cshtml"
     Write(Model.ReturnEmptyResponse);

#line default
#line hidden
            WriteLiteral("\n");
#line 193 "MethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    ");
#line 194 "MethodTemplate.cshtml"
Write(methodName);

#line default
#line hidden
            WriteLiteral(".metadata = {\'url\': \'");
#line 194 "MethodTemplate.cshtml"
                                  Write(Model.Url);

#line default
#line hidden
            WriteLiteral("\'}\n");
        }
        #pragma warning restore 1998
    }
}
