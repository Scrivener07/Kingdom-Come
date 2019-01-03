using System;
using System.IO;

namespace KCD.Library.Tables
{
	//poi_type_id(uuid; 16 bytes)
	//perk_id(uuid; 16 bytes)
	public class POI_Type2Perk : Row
	{
		public Guid POI_Type_ID { get; set; }
		public Guid Perk_ID { get; set; }


		public POI_Type2Perk(Table table) : base(table)
		{
			POI_Type_ID = Guid.Empty;
			Perk_ID = Guid.Empty;
		}


		public POI_Type2Perk(Table table, BinaryReader reader) : base(table, reader)
		{
			// TODO: Still problems reading GUID.

			/*
			row perk_id
			Bytes:CD 47 0E EE 67 27 1A 07 37 EC C9 E5 1F 0C F7 9C
			Hex:dce595c7-5d2b-4344-bae0-8a4a4e965b2a
			Int:293622232927555659393294770838739245866
			B64:x5Xl3CtdREO64IpKTpZbKg==
			*/
			/*
			poi_type_id
			Bytes:44 43 2B 5D C7 95 E5 DC 2A 5B 96 4E 4A 8A E0 BA
			Hex:071a2767-ee0e-47cd-9cf7-0c1fe5c9ec37
			Int:9440394936966294392909820744864230455
			B64:ZycaBw7uzUec9wwf5cnsNw==
			*/

			POI_Type_ID = reader.ReadTableGuid();
			Perk_ID = reader.ReadTableGuid();
		}


		protected override Guid GetID()
		{
			return POI_Type_ID;
		}

		protected override long GetSizeActual()
		{
			throw new NotImplementedException();
		}
	}
}