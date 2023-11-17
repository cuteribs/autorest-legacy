// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace AutoRest.CSharp.vanilla.Templates.Rest.Client
{
#line 1 "XmlSerializationTemplate.cshtml"
using System

#line default
#line hidden
    ;
#line 2 "XmlSerializationTemplate.cshtml"
using System.Linq

#line default
#line hidden
    ;
#line 3 "XmlSerializationTemplate.cshtml"
using AutoRest.Core.Utilities

#line default
#line hidden
    ;
#line 4 "XmlSerializationTemplate.cshtml"
using AutoRest.CSharp

#line default
#line hidden
    ;
#line 5 "XmlSerializationTemplate.cshtml"
using AutoRest.CSharp.Model

#line default
#line hidden
    ;
    using System.Threading.Tasks;

    public class XmlSerializationTemplate : AutoRest.Core.Template<object>
    {
        #line hidden
        public XmlSerializationTemplate()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            WriteLiteral("namespace ");
#line 8 "XmlSerializationTemplate.cshtml"
     Write(Settings.Namespace);

#line default
#line hidden
            WriteLiteral("\n{\n    internal static class ");
#line 10 "XmlSerializationTemplate.cshtml"
                      Write(XmlSerialization.XmlDeserializationClass);

#line default
#line hidden
            WriteLiteral(@"
    {
        internal delegate bool XmlRootDeserializer<T>( System.Xml.Linq.XElement root, out T result );
        internal delegate bool XmlDeserializer<T>( System.Xml.Linq.XElement parent, string propertyName, out T result );

        internal static XmlRootDeserializer<T> Root<T>( XmlDeserializer<T> deserializer ) =>
            (System.Xml.Linq.XElement root, out T result) => deserializer(new System.Xml.Linq.XElement(""artificialRoot"", root), root.Name.LocalName, out result);

        private static XmlDeserializer<T> Unroot<T>( XmlRootDeserializer<T> deserializer )
        {
            return (System.Xml.Linq.XElement parent, string propertyName, out T result) => {
                result = default(T);
                var element = parent.Element(propertyName);
                if (element == null)
                {
                    return false;
                }
                return deserializer(element, out result);
            };
        }
    
        private static XmlRootDeserializer<T> ToRoo");
            WriteLiteral(@"tDeserializer<T>( System.Func<System.Xml.Linq.XElement, T> unsafeDeserializer )
            => (System.Xml.Linq.XElement root, out T result) => {
                try 
                {
                    result = unsafeDeserializer(root);
                    return true;
                }
                catch 
                {
                    result = default(T);
                    return false;
                }};

        internal static XmlDeserializer<T> ToDeserializer<T>( System.Func<System.Xml.Linq.XElement, T> unsafeDeserializer )
            => Unroot(ToRootDeserializer(unsafeDeserializer));

        internal static XmlDeserializer<System.Collections.Generic.IList<T>> CreateListXmlDeserializer<T>( XmlDeserializer<T> elementDeserializer, string elementTagName = null /*if isWrapped = false*/ )
        {
            if (elementTagName != null)
            {
                // create non-wrapped deserializer and forward
                var slave = CreateListXmlDeserializer<T>( elementDeserializer ");
            WriteLiteral(@");
                return (System.Xml.Linq.XElement parent, string propertyName, out System.Collections.Generic.IList<T> result) => {
                    result = null;
                    var wrapper = parent.Element(propertyName);
                    return wrapper != null && slave(wrapper, elementTagName, out result);
                };
            }
            var rootElementDeserializer = Root(elementDeserializer);
            return (System.Xml.Linq.XElement parent, string propertyName, out System.Collections.Generic.IList<T> result) => {
                result = new System.Collections.Generic.List<T>();
                foreach (var element in parent.Elements(propertyName))
                {
                    T elementResult;
                    if (!rootElementDeserializer(element, out elementResult))
                    {
                        return false;
                    }
                    result.Add(elementResult);
                }
                return true;
            };
        }
");
            WriteLiteral(@"    
        internal static XmlDeserializer<System.Collections.Generic.IDictionary<string, T>> CreateDictionaryXmlDeserializer<T>( XmlDeserializer<T> elementDeserializer )
        {
            return (System.Xml.Linq.XElement parent, string propertyName, out System.Collections.Generic.IDictionary<string, T> result) => {
                result = null;
                var childElement = parent.Element(propertyName);
                if (childElement == null)
                {
                    return false;
                }
                result = new System.Collections.Generic.Dictionary<string, T>();
                foreach (var element in childElement.Elements())
                {
                    T elementResult;
                    if (!elementDeserializer(childElement, element.Name.LocalName, out elementResult))
                    {
                        return false;
                    }
                    result.Add(element.Name.LocalName, elementResult);
                }
                r");
            WriteLiteral("eturn true;\n            };\n        }\n    }\n}");
        }
        #pragma warning restore 1998
    }
}
