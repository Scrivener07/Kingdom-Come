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
			//  <row perk_id="dce595c7-5d2b-4344-bae0-8a4a4e965b2a" poi_type_id="071a2767-ee0e-47cd-9cf7-0c1fe5c9ec37" />
			POI_Type_ID = reader.ReadTableGuid();
			Perk_ID = reader.ReadTableGuid();
		}


		protected override Guid GetID()
		{
			return POI_Type_ID;
		}


	}
}