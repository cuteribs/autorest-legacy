using AutoRest.Modeler.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AutoRest.Modeler.JsonConverters;

public class AdditionalPropertiesConverter : SwaggerJsonConverter
{
	public override bool CanConvert(Type objectType)
		=> objectType == typeof(Schema);

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		var obj = JObject.Load(reader);

		if (bool.TryParse(obj["additionalProperties"]?.ToString(), out _))
		{
			obj["additionalProperties"] = null;
		}

		var result = JsonConvert.DeserializeObject<Schema>(obj.ToString(), GetSettings(serializer));
		return result;
	}
}
