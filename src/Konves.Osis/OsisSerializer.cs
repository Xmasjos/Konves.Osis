using Konves.Osis.ObjectModel;
using System.IO;

namespace Konves.Osis
{
	public class OsisSerializer
	{
		public static osisCT Deserialize(Stream stream)
		{
			var s = new System.Xml.Serialization.XmlSerializer(typeof(osisCT));
			return (osisCT)s.Deserialize(stream);
		}

		public static void Serialize(Stream stream, osisCT document)
		{
			var s = new System.Xml.Serialization.XmlSerializer(typeof(osisCT));
			s.Serialize(stream, document);
		}
	}
}
