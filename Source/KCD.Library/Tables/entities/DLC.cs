using System;
using System.IO;

//dlc_id(integer; 4 bytes)
//affects_savegame(boolean; 1 bytes)
//need_mount(boolean; 1 bytes)

namespace KCD.Library.Tables
{
	public class DLC : Row
	{
		public int DLC_ID { get; set; }
		public bool Affects_Savegame { get; set; }
		public bool Need_Mount { get; set; }


		public DLC(Table table) : base(table)
		{
			//TODO: Look into maintaining consistant default values for entities. For `DLC_ID`, zero is a valid value.
			DLC_ID = -1;
			Affects_Savegame = false;
			Need_Mount = false;
		}


		public DLC(Table table, BinaryReader reader) : base(table, reader)
		{ // TODO: Look further into why skipping a byte after boolean works.
			DLC_ID = reader.ReadTableInteger();
			Affects_Savegame = reader.ReadTableBoolean();
			reader.SkipByte(); // padding?
			Need_Mount = reader.ReadTableBoolean();
			reader.SkipByte(); // padding?
		}


		protected override Guid GetID()
		{
			return Guid.Empty;
		}


		public override string ToString()
		{
			return string.Format("ID:{0} [Type:{1}::{2}]", DLC_ID, GetType().Name, Owner.Key);
		}

		protected override long GetSizeActual()
		{
			throw new NotImplementedException();
		}
	}
}