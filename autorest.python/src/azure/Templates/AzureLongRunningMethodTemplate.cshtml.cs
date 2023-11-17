// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.TypeScript.azure.Templates
{
#line 1 "AzureLongRunningMethodTemplate.cshtml"
using System;

#line default
#line hidden
#line 2 "AzureLongRunningMethodTemplate.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "AzureLongRunningMethodTemplate.cshtml"
using AutoRest.Core.Model

#line default
#line hidden
    ;
#line 4 "AzureLongRunningMethodTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 5 "AzureLongRunningMethodTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 6 "AzureLongRunningMethodTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
#line 7 "AzureLongRunningMethodTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzureLongRunningMethodTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Azure.Model.MethodPya>
    {
        #line hidden
        public AzureLongRunningMethodTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 9 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 10 "AzureLongRunningMethodTemplate.cshtml"
  
string defKeyword = AsyncMode? "async def" : "def";
string methodName = Model.Name.ToPythonCase();
string initialMethodName = "_" + methodName + "_initial";
string trace_decorator = "";

#line default
#line hidden

#line 16 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.AddTracingDecorators)
{
trace_decorator = AsyncMode? "@distributed_trace_async" : "@distributed_trace";
}

#line default
#line hidden

            WriteLiteral("    ");
#line 20 "AzureLongRunningMethodTemplate.cshtml"
Write(defKeyword);

#line default
#line hidden
            WriteLiteral(" ");
#line 20 "AzureLongRunningMethodTemplate.cshtml"
              Write(initialMethodName);

#line default
#line hidden
            WriteLiteral("(\n            self, ");
#line 21 "AzureLongRunningMethodTemplate.cshtml"
              Write(Model.MethodParameterDeclaration(Python3Mode));

#line default
#line hidden
            WriteLiteral(", **kwargs):\n        error_map = kwargs.pop(\'error_map\', None)\n        ");
#line 23 "AzureLongRunningMethodTemplate.cshtml"
   Write(Model.BuildInputMappings());

#line default
#line hidden
            WriteLiteral("\n");
#line 24 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.InputParameterTransformation.Any())
{

#line default
#line hidden

#line 26 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 26 "AzureLongRunningMethodTemplate.cshtml"
          
}

#line default
#line hidden

#line 28 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.ConstantParameters.Any())
{
	foreach (var parameter in Model.ConstantParameters)
	{

#line default
#line hidden

            WriteLiteral("        ");
#line 32 "AzureLongRunningMethodTemplate.cshtml"
      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 32 "AzureLongRunningMethodTemplate.cshtml"
                          Write(parameter.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 33 "AzureLongRunningMethodTemplate.cshtml"
	}

#line default
#line hidden

#line 34 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 34 "AzureLongRunningMethodTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("        # Construct URL\n        url = self.");
#line 37 "AzureLongRunningMethodTemplate.cshtml"
               Write(methodName);

#line default
#line hidden
            WriteLiteral(".metadata[\'url\']\n        ");
#line 38 "AzureLongRunningMethodTemplate.cshtml"
    Write(Model.BuildUrlPath("url", Model.LogicalParameters));

#line default
#line hidden
            WriteLiteral("\n");
#line 39 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        # Construct parameters\n        query_parameters = {}\n        ");
#line 42 "AzureLongRunningMethodTemplate.cshtml"
    Write(Model.BuildUrlQuery("query_parameters", Model.LogicalParameters));

#line default
#line hidden
            WriteLiteral("\n");
#line 43 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        # Construct headers\n        header_parameters = {}\n");
#line 46 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.HasAnyResponse)
{

#line default
#line hidden

            WriteLiteral("        header_parameters[\'Accept\'] = \'");
#line 48 "AzureLongRunningMethodTemplate.cshtml"
                                     Write(Model.AcceptContentType);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 49 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

#line 50 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.RequestBody != null || Model.IsFormData)
{

#line default
#line hidden

            WriteLiteral("        header_parameters[\'Content-Type\'] = \'");
#line 52 "AzureLongRunningMethodTemplate.cshtml"
                                           Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 53 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 54 "AzureLongRunningMethodTemplate.cshtml"
    Write(Model.SetDefaultHeaders);

#line default
#line hidden
            WriteLiteral("\n        ");
#line 55 "AzureLongRunningMethodTemplate.cshtml"
    Write(Model.BuildHeaders("header_parameters"));

#line default
#line hidden
            WriteLiteral("\n");
#line 56 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 57 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.RequestBody != null)
{

#line default
#line hidden

            WriteLiteral("        # Construct body\n");
#line 60 "AzureLongRunningMethodTemplate.cshtml"
  if (Model.IsStreamRequestBody)
  {
    foreach (var parameter in Model.LocalParameters)
    {
      if (parameter.Location == ParameterLocation.Body && parameter.ModelType.IsPrimaryType(KnownPrimaryType.Stream))
      {

#line default
#line hidden

            WriteLiteral("        body_content = upload_gen(");
#line 66 "AzureLongRunningMethodTemplate.cshtml"
                               Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(")\n");
#line 67 "AzureLongRunningMethodTemplate.cshtml"
        break;
      }
    }
  }
  else if (Model.RequestBody.IsRequired)
  {

#line default
#line hidden

            WriteLiteral("        body_content = self._serialize.body(");
#line 73 "AzureLongRunningMethodTemplate.cshtml"
                                         Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", \'");
#line 73 "AzureLongRunningMethodTemplate.cshtml"
                                                                    Write(Model.RequestBody.ModelType.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\')\n");
#line 74 "AzureLongRunningMethodTemplate.cshtml"
  }
  else
  {

#line default
#line hidden

            WriteLiteral("        if ");
#line 77 "AzureLongRunningMethodTemplate.cshtml"
        Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" is not None:\n            body_content = self._serialize.body(");
#line 78 "AzureLongRunningMethodTemplate.cshtml"
                                             Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", \'");
#line 78 "AzureLongRunningMethodTemplate.cshtml"
                                                                        Write(Model.RequestBody.ModelType.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\')\n        else:\n            body_content = None\n");
#line 81 "AzureLongRunningMethodTemplate.cshtml"
  }

#line default
#line hidden

#line 82 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 82 "AzureLongRunningMethodTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("        # Construct and send request\n");
#line 85 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.RequestBody != null)
{

#line default
#line hidden

            WriteLiteral("        request = self._client.");
#line 87 "AzureLongRunningMethodTemplate.cshtml"
                             Write(MethodPy.GetHttpFunction(Model.HttpMethod));

#line default
#line hidden
            WriteLiteral("(url, query_parameters, header_parameters, body_content)\n");
#line 88 "AzureLongRunningMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        request = self._client.");
#line 91 "AzureLongRunningMethodTemplate.cshtml"
                             Write(MethodPy.GetHttpFunction(Model.HttpMethod));

#line default
#line hidden
            WriteLiteral("(url, query_parameters, header_parameters)\n");
#line 92 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

#line 93 "AzureLongRunningMethodTemplate.cshtml"
  string sendCall = Model.GetSendCall(AsyncMode);

#line default
#line hidden

            WriteLiteral("        pipeline_response = ");
#line 94 "AzureLongRunningMethodTemplate.cshtml"
                        Write(sendCall);

#line default
#line hidden
            WriteLiteral("(request, stream=False, **kwargs)\n        response = pipeline_response.http_response\n");
#line 96 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        if ");
#line 97 "AzureLongRunningMethodTemplate.cshtml"
      Write(Model.FailureStatusCodePredicate);

#line default
#line hidden
            WriteLiteral(":\n            ");
#line 98 "AzureLongRunningMethodTemplate.cshtml"
       Write(Model.RaisedException);

#line default
#line hidden
            WriteLiteral("\n");
#line 99 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.HasAnyResponse)
{

#line default
#line hidden

#line 101 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 101 "AzureLongRunningMethodTemplate.cshtml"
          
  if (Model.HasResponseHeader)
  {

#line default
#line hidden

            WriteLiteral("        header_dict = {}\n");
#line 105 "AzureLongRunningMethodTemplate.cshtml"
  }

#line default
#line hidden

#line 106 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 106 "AzureLongRunningMethodTemplate.cshtml"
          
  foreach (var responsePair in Model.Responses.Where(r => r.Value.Body != null))
  {

#line default
#line hidden

            WriteLiteral("        if response.status_code == ");
#line 109 "AzureLongRunningMethodTemplate.cshtml"
                                Write(MethodPy.GetStatusCodeReference(responsePair.Key));

#line default
#line hidden
            WriteLiteral(":\n            self._deserialize(\'");
#line 110 "AzureLongRunningMethodTemplate.cshtml"
                            Write(responsePair.Value.Body.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\', response)\n            ");
#line 111 "AzureLongRunningMethodTemplate.cshtml"
         Write(Model.AddIndividualResponseHeader(responsePair.Key));

#line default
#line hidden
            WriteLiteral("\n");
#line 112 "AzureLongRunningMethodTemplate.cshtml"
  }
}

#line default
#line hidden

#line 114 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        return response\n");
#line 116 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n    ");
#line 117 "AzureLongRunningMethodTemplate.cshtml"
Write(trace_decorator);

#line default
#line hidden
            WriteLiteral("\n    ");
#line 118 "AzureLongRunningMethodTemplate.cshtml"
Write(defKeyword);

#line default
#line hidden
            WriteLiteral(" ");
#line 118 "AzureLongRunningMethodTemplate.cshtml"
              Write(methodName);

#line default
#line hidden
            WriteLiteral("(\n            self, ");
#line 119 "AzureLongRunningMethodTemplate.cshtml"
              Write(Model.MethodParameterDeclaration(Python3Mode));

#line default
#line hidden
            WriteLiteral(", polling=True, **kwargs):\n        \"\"\"");
#line 120 "AzureLongRunningMethodTemplate.cshtml"
       Write(WrapComment(string.Empty, Model.BuildSummaryAndDescriptionString()));

#line default
#line hidden
            WriteLiteral("\n");
#line 122 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 123 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.Deprecated)
{

#line default
#line hidden

            WriteLiteral("        .. warning::\n           This method is deprecated\n");
#line 127 "AzureLongRunningMethodTemplate.cshtml"

#line default
#line hidden

#line 127 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 127 "AzureLongRunningMethodTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("\n");
#line 130 "AzureLongRunningMethodTemplate.cshtml"
 foreach(var parameter in Model.DocumentationParameters)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 132 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(MethodPy.GetParameterDocumentationString(parameter)));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 133 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(":type " + parameter.Name + ": " + Model.GetDocumentationType(parameter.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 134 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

#line 135 "AzureLongRunningMethodTemplate.cshtml"
 if (AsyncMode)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 137 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(":param callable cls: A custom type or function that will be passed the direct response"));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 138 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(":param polling: True for AsyncARMPolling, False for no polling, or a polling object for personal polling strategy"));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 139 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(":return: An instance of " + Model.GetDocumentationTypeName(Model.ReturnType.Body)));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 140 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(string.Format(":rtype: ~{0}", Model.GetReturnTypeDocumentation(Model.ReturnType.Body))));

#line default
#line hidden
            WriteLiteral("\n");
#line 141 "AzureLongRunningMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        ");
#line 144 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(":param callable cls: A custom type or function that will be passed the direct response"));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 145 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(":param polling: True for ARMPolling, False for no polling, or a polling object for personal polling strategy"));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 146 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(":return: An instance of LROPoller that returns " + Model.GetDocumentationTypeName(Model.ReturnType.Body)));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 147 "AzureLongRunningMethodTemplate.cshtml"
     Write(ParameterWrapComment(string.Format(":rtype: ~msrestazure.azure_operation.AzureOperationPoller[{0}]", Model.GetReturnTypeDocumentation(Model.ReturnType.Body))));

#line default
#line hidden
            WriteLiteral("\n");
#line 148 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 149 "AzureLongRunningMethodTemplate.cshtml"
   Write(ParameterWrapComment(string.Format(":raises: {0}", Model.ExceptionDocumentation)));

#line default
#line hidden
            WriteLiteral("\n        \"\"\"\n");
#line 151 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.Deprecated)
{

#line default
#line hidden

            WriteLiteral("        warnings.warn(\'Method ");
#line 153 "AzureLongRunningMethodTemplate.cshtml"
                           Write(methodName);

#line default
#line hidden
            WriteLiteral(" is deprecated\', DeprecationWarning)\n");
#line 154 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

#line 155 "AzureLongRunningMethodTemplate.cshtml"
 if (AsyncMode)
{

#line default
#line hidden

            WriteLiteral("        raw_result = await self.");
#line 157 "AzureLongRunningMethodTemplate.cshtml"
                              Write(initialMethodName);

#line default
#line hidden
            WriteLiteral("(\n");
#line 158 "AzureLongRunningMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        raw_result = self.");
#line 161 "AzureLongRunningMethodTemplate.cshtml"
                        Write(initialMethodName);

#line default
#line hidden
            WriteLiteral("(\n");
#line 162 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

#line 163 "AzureLongRunningMethodTemplate.cshtml"
 foreach(var parameter in Model.DocumentationParameters)
{

#line default
#line hidden

            WriteLiteral("            ");
#line 165 "AzureLongRunningMethodTemplate.cshtml"
         Write(parameter.Name);

#line default
#line hidden
            WriteLiteral("=");
#line 165 "AzureLongRunningMethodTemplate.cshtml"
                         Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(",\n");
#line 166 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            **kwargs\n        )\n");
#line 169 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        def get_long_running_output(response):\n");
#line 171 "AzureLongRunningMethodTemplate.cshtml"
 if (Model.HasAnyResponse)
{
  if (Model.HasResponseHeader)
  {

#line default
#line hidden

            WriteLiteral("            ");
#line 175 "AzureLongRunningMethodTemplate.cshtml"
         Write(Model.AddIndividualResponseHeader(null));

#line default
#line hidden
            WriteLiteral("\n");
#line 176 "AzureLongRunningMethodTemplate.cshtml"
  }

#line default
#line hidden

            WriteLiteral("            deserialized = self._deserialize(\'");
#line 177 "AzureLongRunningMethodTemplate.cshtml"
                                           Write(Model.ReturnType.Body.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\', response)\n");
#line 178 "AzureLongRunningMethodTemplate.cshtml"

#line default
#line hidden

#line 178 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 178 "AzureLongRunningMethodTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("            return deserialized\n");
#line 180 "AzureLongRunningMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("            ");
#line 183 "AzureLongRunningMethodTemplate.cshtml"
         Write(Model.ReturnEmptyResponse);

#line default
#line hidden
            WriteLiteral("\n");
#line 184 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

#line 185 "AzureLongRunningMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        lro_delay = kwargs.get(\n            \'polling_interval \',\n            self._config.polling_interval)\n");
#line 189 "AzureLongRunningMethodTemplate.cshtml"
  
var lro_string = Model.GetLROOptions();
if(lro_string != "")
{
        lro_string = ", lro_options="+lro_string;
}

#line default
#line hidden

#line 196 "AzureLongRunningMethodTemplate.cshtml"
 if (AsyncMode)
{

#line default
#line hidden

            WriteLiteral("        if polling is True: polling_method = AsyncARMPolling(lro_delay");
#line 198 "AzureLongRunningMethodTemplate.cshtml"
                                                                    Write(lro_string);

#line default
#line hidden
            WriteLiteral(", **kwargs)\n        elif polling is False: polling_method = AsyncNoPolling()\n        else: polling_method = polling\n        return await async_poller(self._client, raw_result, get_long_running_output, polling_method)\n");
#line 202 "AzureLongRunningMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        if polling is True: polling_method = ARMPolling(lro_delay");
#line 205 "AzureLongRunningMethodTemplate.cshtml"
                                                               Write(lro_string);

#line default
#line hidden
            WriteLiteral(", **kwargs)\n        elif polling is False: polling_method = NoPolling()\n        else: polling_method = polling\n        return LROPoller(self._client, raw_result, get_long_running_output, polling_method)\n");
#line 209 "AzureLongRunningMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    ");
#line 210 "AzureLongRunningMethodTemplate.cshtml"
Write(methodName);

#line default
#line hidden
            WriteLiteral(".metadata = {\'url\': \'");
#line 210 "AzureLongRunningMethodTemplate.cshtml"
                                  Write(Model.Url);

#line default
#line hidden
            WriteLiteral("\'}\n");
        }
        #pragma warning restore 1998
    }
}
