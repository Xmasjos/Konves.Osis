# Konves.Osis
This project is a generated XML serializer for OSIS (Open Scripture Information Standard) files.
For more information on the OSIS format, see http://bibletechnologies.net/index.html.

## Usage

```
using(Stream stream = new System.IO.FileStream(path, FileMode.Open))
{
    var document = Konves.Osis.OsisSerializer.Deserialize(stream);
}

```