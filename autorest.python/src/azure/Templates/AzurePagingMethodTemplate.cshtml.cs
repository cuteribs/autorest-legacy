// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.Python.azure.Templates
{
#line 1 "AzurePagingMethodTemplate.cshtml"
using System;

#line default
#line hidden
#line 2 "AzurePagingMethodTemplate.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "AzurePagingMethodTemplate.cshtml"
using AutoRest.Python

#line default
#line hidden
    ;
#line 4 "AzurePagingMethodTemplate.cshtml"
using AutoRest.Python.Model

#line default
#line hidden
    ;
#line 5 "AzurePagingMethodTemplate.cshtml"
using AutoRest.Python.vanilla.Templates

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class AzurePagingMethodTemplate : AutoRest.Python.PythonTemplate<AutoRest.Python.Azure.Model.MethodPya>
    {
        #line hidden
        public AzurePagingMethodTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 7 "AzurePagingMethodTemplate.cshtml"
  
string methodName = Model.Name.ToPythonCase();
string trace_decorator = "";
string sync_trace_decorator = "";
var nextLink = Model.PagedMetadata.NextLinkProp;
string nextLinkName = (nextLink != null && nextLink.Name != "")?"deserialized."+nextLink.Name:"None";

#line default
#line hidden

#line 14 "AzurePagingMethodTemplate.cshtml"
 if (Model.AddTracingDecorators)
{
trace_decorator = AsyncMode? "@distributed_trace_async" : "@distributed_trace";
sync_trace_decorator = "@distributed_trace";
}

#line default
#line hidden

            WriteLiteral("    ");
#line 19 "AzurePagingMethodTemplate.cshtml"
Write(sync_trace_decorator);

#line default
#line hidden
            WriteLiteral("\n    def ");
#line 20 "AzurePagingMethodTemplate.cshtml"
    Write(methodName);

#line default
#line hidden
            WriteLiteral("(\n            self, ");
#line 21 "AzurePagingMethodTemplate.cshtml"
              Write(Model.MethodParameterDeclaration(Python3Mode));

#line default
#line hidden
            WriteLiteral(", **kwargs):\n        \"\"\"");
#line 22 "AzurePagingMethodTemplate.cshtml"
       Write(WrapComment(string.Empty, Model.BuildSummaryAndDescriptionString()));

#line default
#line hidden
            WriteLiteral("\n");
#line 23 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 24 "AzurePagingMethodTemplate.cshtml"
 if (Model.Deprecated)
{

#line default
#line hidden

            WriteLiteral("        .. warning::\n           This method is deprecated\n");
#line 28 "AzurePagingMethodTemplate.cshtml"

#line default
#line hidden

#line 28 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 28 "AzurePagingMethodTemplate.cshtml"
          
}

#line default
#line hidden

#line 30 "AzurePagingMethodTemplate.cshtml"
                                                

#line default
#line hidden

#line 31 "AzurePagingMethodTemplate.cshtml"
 foreach(var parameter in Model.DocumentationParameters)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 33 "AzurePagingMethodTemplate.cshtml"
     Write(ParameterWrapComment(string.Empty, MethodPy.GetParameterDocumentationString(parameter)));

#line default
#line hidden
            WriteLiteral("\n        ");
#line 34 "AzurePagingMethodTemplate.cshtml"
     Write(ParameterWrapComment(string.Empty, ":type " + parameter.Name + ": " + Model.GetDocumentationType(parameter.ModelType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 35 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 36 "AzurePagingMethodTemplate.cshtml"
   Write(ParameterWrapComment(string.Empty, ":return: An iterator like instance of " + Model.GetDocumentationTypeName(Model.PagedMetadata.ItemType)));

#line default
#line hidden
            WriteLiteral("\n");
#line 37 "AzurePagingMethodTemplate.cshtml"
 if (!AsyncMode)
{

#line default
#line hidden

            WriteLiteral("        ");
#line 39 "AzurePagingMethodTemplate.cshtml"
     Write(ParameterWrapComment(string.Empty, string.Format(":rtype: ~azure.core.paging.ItemPaged[{0}]", Model.GetReturnTypeDocumentation(Model.PagedMetadata.ItemType))));

#line default
#line hidden
            WriteLiteral("\n");
#line 40 "AzurePagingMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        ");
#line 43 "AzurePagingMethodTemplate.cshtml"
     Write(ParameterWrapComment(string.Empty, string.Format(":rtype: ~azure.core.async_paging.AsyncItemPaged[{0}]", Model.GetReturnTypeDocumentation(Model.PagedMetadata.ItemType))));

#line default
#line hidden
            WriteLiteral("\n");
#line 44 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 45 "AzurePagingMethodTemplate.cshtml"
   Write(ParameterWrapComment(string.Empty, string.Format(":raises: {0}", Model.ExceptionDocumentation)));

#line default
#line hidden
            WriteLiteral("\n        \"\"\"\n");
#line 47 "AzurePagingMethodTemplate.cshtml"
 if (Model.Deprecated)
{

#line default
#line hidden

            WriteLiteral("        warnings.warn(\'Method ");
#line 49 "AzurePagingMethodTemplate.cshtml"
                           Write(methodName);

#line default
#line hidden
            WriteLiteral(" is deprecated\', DeprecationWarning)\n");
#line 50 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("        ");
#line 51 "AzurePagingMethodTemplate.cshtml"
   Write(Model.BuildInputMappings());

#line default
#line hidden
            WriteLiteral("\n");
#line 52 "AzurePagingMethodTemplate.cshtml"
 if (Model.InputParameterTransformation.Any())
{

#line default
#line hidden

#line 54 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 54 "AzurePagingMethodTemplate.cshtml"
          
}

#line default
#line hidden

#line 56 "AzurePagingMethodTemplate.cshtml"
 if (Model.ConstantParameters.Any())
{
	foreach (var parameter in Model.ConstantParameters)
	{

#line default
#line hidden

            WriteLiteral("        ");
#line 60 "AzurePagingMethodTemplate.cshtml"
      Write(parameter.Name);

#line default
#line hidden
            WriteLiteral(" = ");
#line 60 "AzurePagingMethodTemplate.cshtml"
                          Write(parameter.DefaultValue);

#line default
#line hidden
            WriteLiteral("\n");
#line 61 "AzurePagingMethodTemplate.cshtml"
	}

#line default
#line hidden

#line 62 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 62 "AzurePagingMethodTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("        error_map = kwargs.pop(\'error_map\', None)\n        def prepare_request(next_link=None):\n            query_parameters = {}\n            if not next_link:\n                # Construct URL\n                url = self.");
#line 69 "AzurePagingMethodTemplate.cshtml"
                       Write(((string)Model.Name).ToPythonCase());

#line default
#line hidden
            WriteLiteral(".metadata[\'url\']\n                ");
#line 70 "AzurePagingMethodTemplate.cshtml"
            Write(Model.BuildUrlPath("url", Model.LogicalParameters));

#line default
#line hidden
            WriteLiteral("\n                ");
#line 71 "AzurePagingMethodTemplate.cshtml"
            Write(Model.BuildUrlQuery("query_parameters", Model.LogicalParameters));

#line default
#line hidden
            WriteLiteral("\n");
#line 72 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n            else:\n");
#line 74 "AzurePagingMethodTemplate.cshtml"
 if (Model.PagingURL != null)
{

#line default
#line hidden

            WriteLiteral("                url = \'");
#line 76 "AzurePagingMethodTemplate.cshtml"
                     Write(Model.PagingURL);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 77 "AzurePagingMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("                url = next_link\n");
#line 81 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

#line 82 "AzurePagingMethodTemplate.cshtml"
 if (Model.IsCustomBaseUri)
{

#line default
#line hidden

            WriteLiteral("                ");
#line 84 "AzurePagingMethodTemplate.cshtml"
              Write(Model.BuildUrlPath("url", Model.PagingLogicalParameters));

#line default
#line hidden
            WriteLiteral("\n");
#line 85 "AzurePagingMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("                ");
#line 88 "AzurePagingMethodTemplate.cshtml"
              Write(Model.BuildUrlPath("url", Model.PagingParameters));

#line default
#line hidden
            WriteLiteral("\n");
#line 89 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("                ");
#line 90 "AzurePagingMethodTemplate.cshtml"
            Write(Model.BuildUrlQuery("query_parameters", Model.PagingParameters));

#line default
#line hidden
            WriteLiteral("\n");
#line 91 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n            # Construct headers\n            header_parameters = {}\n");
#line 94 "AzurePagingMethodTemplate.cshtml"
 if (Model.HasAnyResponse)
{

#line default
#line hidden

            WriteLiteral("            header_parameters[\'Accept\'] = \'");
#line 96 "AzurePagingMethodTemplate.cshtml"
                                         Write(Model.AcceptContentType);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 97 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

#line 98 "AzurePagingMethodTemplate.cshtml"
 if (Model.RequestBody != null || Model.IsFormData)
{

#line default
#line hidden

            WriteLiteral("            header_parameters[\'Content-Type\'] = \'");
#line 100 "AzurePagingMethodTemplate.cshtml"
                                               Write(Model.RequestContentType);

#line default
#line hidden
            WriteLiteral("\'\n");
#line 101 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            ");
#line 102 "AzurePagingMethodTemplate.cshtml"
        Write(Model.SetDefaultHeaders);

#line default
#line hidden
            WriteLiteral("\n            ");
#line 103 "AzurePagingMethodTemplate.cshtml"
        Write(Model.BuildHeaders("header_parameters"));

#line default
#line hidden
            WriteLiteral("\n");
#line 104 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 105 "AzurePagingMethodTemplate.cshtml"
 if (Model.RequestBody != null)
{

#line default
#line hidden

            WriteLiteral("            # Construct body\n");
#line 108 "AzurePagingMethodTemplate.cshtml"
  if (Model.RequestBody.IsRequired)
  {

#line default
#line hidden

            WriteLiteral("            body_content = self._serialize.body(");
#line 110 "AzurePagingMethodTemplate.cshtml"
                                             Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", \'");
#line 110 "AzurePagingMethodTemplate.cshtml"
                                                                        Write(Model.RequestBody.ModelType.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\')\n");
#line 111 "AzurePagingMethodTemplate.cshtml"
  }
  else
  {

#line default
#line hidden

            WriteLiteral("            if ");
#line 114 "AzurePagingMethodTemplate.cshtml"
            Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(" is not None:\n                body_content = self._serialize.body(");
#line 115 "AzurePagingMethodTemplate.cshtml"
                                                 Write(Model.RequestBody.Name);

#line default
#line hidden
            WriteLiteral(", \'");
#line 115 "AzurePagingMethodTemplate.cshtml"
                                                                            Write(Model.RequestBody.ModelType.ToPythonRuntimeTypeString());

#line default
#line hidden
            WriteLiteral("\')\n            else:\n                body_content = None\n");
#line 118 "AzurePagingMethodTemplate.cshtml"
  }

#line default
#line hidden

#line 119 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 119 "AzurePagingMethodTemplate.cshtml"
          
}

#line default
#line hidden

            WriteLiteral("            # Construct and send request\n");
#line 122 "AzurePagingMethodTemplate.cshtml"
 if (Model.RequestBody != null)
{

#line default
#line hidden

            WriteLiteral("            request = self._client.");
#line 124 "AzurePagingMethodTemplate.cshtml"
                                 Write(MethodPy.GetHttpFunction(Model.HttpMethod));

#line default
#line hidden
            WriteLiteral("(url, query_parameters, header_parameters, body_content)\n");
#line 125 "AzurePagingMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("            request = self._client.");
#line 128 "AzurePagingMethodTemplate.cshtml"
                                 Write(MethodPy.GetHttpFunction(Model.HttpMethod));

#line default
#line hidden
            WriteLiteral("(url, query_parameters, header_parameters)\n");
#line 129 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            return request\n");
#line 131 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n");
#line 132 "AzurePagingMethodTemplate.cshtml"
 if(!AsyncMode)
{

#line default
#line hidden

            WriteLiteral("        def extract_data(response):\n            deserialized = self._deserialize(\'");
#line 135 "AzurePagingMethodTemplate.cshtml"
                                            Write(Model.PagedResponseClass.Name);

#line default
#line hidden
            WriteLiteral("\', response)\n            list_of_elem = deserialized.");
#line 136 "AzurePagingMethodTemplate.cshtml"
                                      Write(Model.PagedMetadata.ItemProp.Name);

#line default
#line hidden
            WriteLiteral("\n            if cls:\n               list_of_elem = cls(list_of_elem)\n            return ");
#line 139 "AzurePagingMethodTemplate.cshtml"
                 Write(nextLinkName);

#line default
#line hidden
            WriteLiteral(", iter(list_of_elem)\n");
#line 140 "AzurePagingMethodTemplate.cshtml"

#line default
#line hidden

#line 140 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 140 "AzurePagingMethodTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("        def get_next(next_link=None):\n            request = prepare_request(next_link)\n");
#line 143 "AzurePagingMethodTemplate.cshtml"

#line default
#line hidden

#line 143 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 143 "AzurePagingMethodTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("            pipeline_response = self._client._pipeline.run(request, **kwargs)\n");
#line 145 "AzurePagingMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        async def extract_data_async(response):\n            deserialized = self._deserialize(\'");
#line 149 "AzurePagingMethodTemplate.cshtml"
                                            Write(Model.PagedResponseClass.Name);

#line default
#line hidden
            WriteLiteral("\', response)\n            list_of_elem = deserialized.");
#line 150 "AzurePagingMethodTemplate.cshtml"
                                      Write(Model.PagedMetadata.ItemProp.Name);

#line default
#line hidden
            WriteLiteral("\n            if cls:\n               list_of_elem = cls(list_of_elem)\n            return ");
#line 153 "AzurePagingMethodTemplate.cshtml"
                 Write(nextLinkName);

#line default
#line hidden
            WriteLiteral(", AsyncList(list_of_elem)\n");
#line 154 "AzurePagingMethodTemplate.cshtml"

#line default
#line hidden

#line 154 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 154 "AzurePagingMethodTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("        async def get_next_async(next_link=None):\n            request = prepare_request(next_link)\n");
#line 157 "AzurePagingMethodTemplate.cshtml"

#line default
#line hidden

#line 157 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
#line 157 "AzurePagingMethodTemplate.cshtml"
          

#line default
#line hidden

            WriteLiteral("            pipeline_response = await self._client._pipeline.run(request, **kwargs)\n");
#line 159 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("            response = pipeline_response.http_response\n");
#line 161 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n            if ");
#line 162 "AzurePagingMethodTemplate.cshtml"
          Write(Model.FailureStatusCodePredicate);

#line default
#line hidden
            WriteLiteral(":\n                ");
#line 163 "AzurePagingMethodTemplate.cshtml"
           Write(Model.RaisedException);

#line default
#line hidden
            WriteLiteral("\n            return response\n");
#line 165 "AzurePagingMethodTemplate.cshtml"
Write(EmptyLine);

#line default
#line hidden
            WriteLiteral("\n        # Deserialize response\n");
#line 167 "AzurePagingMethodTemplate.cshtml"
 if(!AsyncMode)
{

#line default
#line hidden

            WriteLiteral("        return ItemPaged(\n            get_next, extract_data\n        )\n");
#line 172 "AzurePagingMethodTemplate.cshtml"
}
else
{

#line default
#line hidden

            WriteLiteral("        return AsyncItemPaged(\n            get_next_async, extract_data_async\n        )\n");
#line 178 "AzurePagingMethodTemplate.cshtml"
}

#line default
#line hidden

            WriteLiteral("    ");
#line 179 "AzurePagingMethodTemplate.cshtml"
Write(methodName);

#line default
#line hidden
            WriteLiteral(".metadata = {\'url\': \'");
#line 179 "AzurePagingMethodTemplate.cshtml"
                                  Write(Model.Url);

#line default
#line hidden
            WriteLiteral("\'}");
        }
        #pragma warning restore 1998
    }
}
