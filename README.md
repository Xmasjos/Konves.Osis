[![Build status](https://img.shields.io/appveyor/ci/skonves/konves-osis.svg?maxAge=2592000)](https://ci.appveyor.com/project/skonves/konves-osis)
[![Build status](https://img.shields.io/nuget/v/Konves.Osis.svg?maxAge=2592000)](https://www.nuget.org/packages/konves.osis/)

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

# Zefania
http://www.bgfdb.de/zefaniaxml/bml/