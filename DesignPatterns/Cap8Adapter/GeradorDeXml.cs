using System.Xml.Serialization;

namespace DesignPatterns2.Cap8Adapter
{
    public class GeradorDeXml
    {
        public String GeraXml(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, obj);
            return writer.ToString();
        }
    }
}