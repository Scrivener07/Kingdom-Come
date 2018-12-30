using System.Collections.Generic;
using System.Xml.Serialization;
/*
<?xml version="1.0" encoding="utf-8"?>
<kcd_mod>
  <info>
	<name>Name of mod -- can be different from mod folder name</name>
	<description>Some text</description>
	<author>Your name</author>
	<version>Version of the mod -- string</version>
	<created_on>some date -- string</created_on>
	<dependencies>
	  <req_mod>name of a required other mod</req_mod>
	  ...
	</dependencies>
  </info>
  <supports>
	<kcd_version>1.2</kcd_version>
	<kcd_version>1.3</kcd_version>
	...
  </supports>
</kcd_mod>
*/
// TODO: Xml serialization.
namespace KCD.Library.Packages
{
	[XmlRoot("kcd_mod")]
	public class Manifest
	{
		[XmlElement("info")]
		public InfoType ModInfo { get; set; }

		[XmlArray("Supports")]
		[XmlArrayItem("kcd_version")]
		public List<VersionType> Supports { get; set; }


		public Manifest(string filepath)
		{
			ModInfo = new InfoType();
			Supports = new List<VersionType>();
		}
	}

	[XmlType("info")]
	public class InfoType
	{
		[XmlElement("name")]
		public string Name { get; set; }

		[XmlElement("description")]
		public string Description { get; set; }

		[XmlElement("author")]
		public string Author { get; set; }

		[XmlElement("version")]
		public string Version { get; set; }

		[XmlElement("created")]
		public string Created { get; set; }

		public InfoType()
		{
			Name = "";
			Description = "";
			Author = "";
			Version = "";
			Created = "";
		}

	}

	[XmlType("kcd_version")]
	public class VersionType
	{
		[XmlText]
		public double Value { get; set; }

		public VersionType()
		{
			Value = 0.0;
		}
	}

}
