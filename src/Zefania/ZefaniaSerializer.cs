using System.IO;

using Zefania.ObjectModel;

namespace Zefania
{
    public class ZefaniaSerializer
    {
        public static XMLBIBLE Deserialize(Stream stream)
        {
            var s = new System.Xml.Serialization.XmlSerializer(typeof(XMLBIBLE));
            return (XMLBIBLE)s.Deserialize(stream);
        }

        public static void Serialize(Stream stream, XMLBIBLE document)
        {
            var s = new System.Xml.Serialization.XmlSerializer(typeof(XMLBIBLE));
            s.Serialize(stream, document);
        }
    }
}