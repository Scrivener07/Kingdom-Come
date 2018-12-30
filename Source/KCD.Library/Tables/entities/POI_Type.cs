using System;
using System.IO;

namespace KCD.Library.Tables
{
	//poi_type_id(uuid; 16 bytes)
	//mark_type(integer; 4 bytes)
	//label(text; 4 bytes)
	//discovery_msg(text; 4 bytes)
	//discovery_dist(real; 4 bytes)
	//compass_mark_type_id(integer; 4 bytes)
	//associated_codex_perk_id(uuid; 16 bytes)
	//discovery_msg_mode(integer; 4 bytes)
	//discoverable_by_location(boolean; 1 bytes)
	//ui_order(integer; 4 bytes)
	public class POI_Type : Row
	{
		public Guid POI_Type_ID { get; set; }
		public int Mark_Type { get; set; }
		public int Label { get; set; }
		public int Discovery_MSG { get; set; }
		public float Discovery_Dist { get; set; }
		public int Compass_Mark_Type_ID { get; set; }
		public Guid Associated_Codex_Perk_ID { get; set; }
		public int Discovery_MSG_Mode { get; set; }
		public bool Discoverable_By_Location { get; set; }
		public int UI_Order { get; set; }


		public POI_Type(Table table) : base(table)
		{
			POI_Type_ID = Guid.Empty;
			Mark_Type = 0;
			Label = 0;
			Discovery_MSG = 0;
			Discovery_Dist = 0.0f;
			Compass_Mark_Type_ID = 0;
			Associated_Codex_Perk_ID = Guid.Empty;
			Discovery_MSG_Mode = 0;
			Discoverable_By_Location = false;
			UI_Order = 0;
		}


		public POI_Type(Table table, BinaryReader reader) : base(table, reader)
		{
			POI_Type_ID = reader.ReadTableGuid();
			Mark_Type = reader.ReadTableInteger();
			Label = reader.ReadTableText();
			Discovery_MSG = reader.ReadTableText();
			Discovery_Dist = reader.ReadTableReal();
			Compass_Mark_Type_ID = reader.ReadTableInteger();
			Associated_Codex_Perk_ID = reader.ReadTableGuid();
			Discovery_MSG_Mode = reader.ReadTableInteger();
			Discoverable_By_Location = reader.ReadTableBoolean();
			UI_Order = reader.ReadTableInteger();
		}


		protected override Guid GetID()
		{
			return POI_Type_ID;
		}


	}
}