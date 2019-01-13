using System;
using System.IO;

namespace KCD.Library.Prototype
{
	//achievement_id(integer; 4 bytes)
	//achievement_name(text; 4 bytes)
	//trophy_id(integer; 4 bytes)
	//xboxlive_id(text; 4 bytes)
	//unlock_on_steam(boolean; 1 bytes)
	//platform_unlockable(boolean; 1 bytes)
	public class Achievement : Row
	{
		public int achievement_id { get; set; }
		public string achievement_name { get; set; }
		public int trophy_id { get; set; }
		public string xboxlive_id { get; set; }
		public bool unlock_on_steam { get; set; }
		public bool platform_unlockable { get; set; }

		public Achievement(Table table) : base(table)
		{
			achievement_id = 0;
			achievement_name = string.Empty;
			trophy_id = 0;
			xboxlive_id = string.Empty;
			unlock_on_steam = false;
			platform_unlockable = false;
		}


		public Achievement(Table table, BinaryReader reader) : base(table, reader)
		{
			achievement_id = reader.ReadTableInteger();
			achievement_name = reader.ReadTableText();
			trophy_id = reader.ReadTableInteger();
			xboxlive_id = reader.ReadTableText();
			unlock_on_steam = reader.ReadTableBoolean();
			platform_unlockable = reader.ReadTableBoolean();
		}


		protected override Guid GetID()
		{
			throw new NotImplementedException();
		}

		protected override long GetSizeActual()
		{
			throw new NotImplementedException();
		}
	}
}