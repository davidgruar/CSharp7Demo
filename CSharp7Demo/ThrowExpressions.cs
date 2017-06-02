using System;

namespace CSharp7Demo
{
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class ThrowExpressions
    {
        public string MyProperty => throw new NotImplementedException();

        public int GetLength(string s)
        {
            return s?.Length ?? throw new ArgumentNullException(nameof(s));
        }

        public void ValidateXml()
        {
            var xDoc = XDocument.Parse("<MyXmlDocument></MyXmlDocument>");
            var schemas = new XmlSchemaSet();
            schemas.Add(null, "path/to/my/schema.xsd");
            xDoc.Validate(schemas, (sender, eventargs) => throw new Exception(eventargs.Message));
        }
    }
}
