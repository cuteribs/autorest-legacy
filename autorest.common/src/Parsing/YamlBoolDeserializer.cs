// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace AutoRest.Core.Parsing
{
	public class YamlBoolDeserializer : INodeDeserializer
	{
		public bool Deserialize(IParser reader, Type expectedType, Func<IParser, Type, object> nestedObjectDeserializer, out object value)
		{
			if (reader == null)
			{
				value = null;
				return false;
			}

			// only try this if we're targeting a boolean or an untyped object
			if (expectedType == typeof(object) || expectedType == typeof(bool))
			{
				// if it's unquoted 
				if (reader.Accept<Scalar>(out var scalar) && scalar.Style == ScalarStyle.Plain)
				{
					// and the value is actually true or false
					switch (scalar.Value.ToUpperInvariant())
					{
						case "TRUE":
							value = true;
							reader.TryConsume<Scalar>(out _);
							return true;
						case "FALSE":
							value = false;
							reader.TryConsume<Scalar>(out _);
							return true;

					}
				}
			}

			// otherwise, fall thru
			value = null;
			return false;
		}
	}
}