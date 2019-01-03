using System;
using System.IO;

namespace KCD.Library.Tables
{
	// TODO: This definition is not documented on the wiki.
	public class Game_Mode : Row
	{
		public int Game_Mode_ID { get; set; }
		public string Game_Mode_Name { get; set; }
		public Guid Player_Perk_ID { get; set; }


		public Game_Mode(Table table) : base(table)
		{
			Game_Mode_ID = 0;
			Game_Mode_Name = string.Empty;
			Player_Perk_ID = Guid.Empty;
		}


		public Game_Mode(Table table, BinaryReader reader) : base(table, reader)
		{
			Game_Mode_ID = reader.ReadTableInteger();
			Game_Mode_Name = reader.ReadTableText();
			Player_Perk_ID = reader.ReadTableGuid();
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
