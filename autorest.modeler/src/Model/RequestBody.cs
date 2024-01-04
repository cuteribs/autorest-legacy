// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace AutoRest.Modeler.Model
{
    /// <summary>
    /// Describes a single response from an API Operation.
    /// </summary>
    public class RequestBody : SwaggerBase
    {
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value.StripControlCharacters(); }
        }

        [JsonProperty(PropertyName = "$ref")]
        public string Reference { get; set; }

        // TODO: get rid of this
        private IEnumerable<SwaggerParameter> asParamCache = null;
        public IEnumerable<SwaggerParameter> AsParameters()
        {
            if (asParamCache == null)
            {
                Func<string, bool> isFormDataMimeType = type => type == "multipart/form-data" || type == "application/x-www-form-urlencoded";
                var parameterLocation = ParameterLocation.Body;
                var name = "body";
                var reference = Reference;
                var schema = Content?.Values.FirstOrDefault()?.Schema;

                if (isFormDataMimeType(Content?.Keys?.FirstOrDefault()) && Content.Values.First().Schema != null)
                {
                    parameterLocation = ParameterLocation.FormData;
                    name = "form";
                    reference = schema.Reference;
                }

                var p = new SwaggerParameter
                {
                    Description = Description,
                    In = parameterLocation,
                    Name = Extensions.GetValue<string>("x-ms-requestBody-name") ?? name,
                    IsRequired = Required,
                    Schema = schema,
                    Reference = reference,
                    Extensions = Extensions,
                    Style = schema?.Style
                };
                asParamCache = new[] { p };
            }
            return asParamCache;
        }

        public Dictionary<string, MediaTypeObject> Content { get; set; }

        public bool Required { get; set; }
    }
}
