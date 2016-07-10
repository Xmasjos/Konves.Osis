using Konves.Osis.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;

namespace Konves.Osis.UnitTests
{
	[TestClass]
	public class OsisSerializerTestFixture
	{
		[TestMethod]
		public void Test()
		{
			// Arrange
			Assembly assembly = Assembly.GetExecutingAssembly();
			string resourceName = "Konves.Osis.UnitTests.Data.eng-web_osis.xml";
			osisCT document = null;
			string outputString = null;

			// Act
			using (Stream input = assembly.GetManifestResourceStream(resourceName))
			using (Stream output = new MemoryStream())
			{
				document = OsisSerializer.Deserialize(input);
				OsisSerializer.Serialize(output, document);

				output.Flush();
				output.Position = 0;

				using (StreamReader reader = new StreamReader(output))
				{
					outputString = reader.ReadToEnd();
				}
			}

			// Assert
			Assert.IsNotNull(document);
			Assert.IsNotNull(outputString);
		}
	}
}
