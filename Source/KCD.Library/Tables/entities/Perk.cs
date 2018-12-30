using System;
using System.IO;

namespace KCD.Library.Tables
{
	/// perk_id(uuid; 16 bytes)
	/// parent_id(uuid; 16 bytes)
	/// perk_name(text; 4 bytes)
	/// perk_ui_name(text; 4 bytes)
	/// perk_ui_desc(text; 4 bytes)
	/// icon_id(text; 4 bytes)
	/// stat_selector(integer; 4 bytes)
	/// skill_selector(integer; 4 bytes)
	/// level(integer; 4 bytes)
	/// visibility(integer; 4 bytes)
	/// metaperk_id(uuid; 16 bytes)
	/// ui_priority(integer; 4 bytes)
	public class Perk : Row
	{
		public Guid perk_id { get; set; }
		public Guid parent_id { get; set; }
		public int perk_name { get; set; }
		public int perk_ui_name { get; set; }
		public int perk_ui_desc { get; set; }
		public int icon_id { get; set; }
		public int stat_selector { get; set; }
		public int skill_selector { get; set; }
		public int level { get; set; }
		public int visibility { get; set; }
		public Guid metaperk_id { get; set; }
		public int ui_priority { get; set; }

		public Perk(Table table) : base(table)
		{
			perk_id = Guid.Empty;
			parent_id = Guid.Empty;
			perk_name = 0;
			perk_ui_name = 0;
			perk_ui_desc = 0;
			icon_id = 0;
			stat_selector = 0;
			skill_selector = 0;
			level = 0;
			visibility = 0;
			metaperk_id = Guid.Empty;
			ui_priority = 0;
		}


		public Perk(Table table, BinaryReader reader) : base(table, reader)
		{
			perk_id = reader.ReadTableGuid();
			parent_id = reader.ReadTableGuid();
			perk_name = reader.ReadTableInteger();
			perk_ui_name = reader.ReadTableText();
			perk_ui_desc = reader.ReadTableText();
			icon_id = reader.ReadTableInteger();
			stat_selector = reader.ReadTableInteger();
			skill_selector = reader.ReadTableInteger();
			level = reader.ReadTableInteger();
			visibility = reader.ReadTableInteger();
			metaperk_id = reader.ReadTableGuid();
			ui_priority = reader.ReadTableInteger();
		}


		protected override Guid GetID()
		{
			throw new NotImplementedException();
		}


	}
}
