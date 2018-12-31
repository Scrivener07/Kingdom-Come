using System;
using System.IO;

// TODO: This table possibly has some padding.

namespace KCD.Library.Tables
{
	//RowCount:7
	//FileSize:84
	//RowSize:8
	//RealRowSize:6
	//RowsBlockSize:56
	// Bits [8+8+32] == 48 Bits
	//------------------------------------
	//dlc_id(integer; 4 bytes)
	//affects_savegame(boolean; 1 bytes)
	//need_mount(boolean; 1 bytes)
	public class DLC : Row
	{
		public int DLC_ID { get; set; }
		public bool Affects_Savegame { get; set; }
		public bool Need_Mount { get; set; }


		public DLC(Table table) : base(table)
		{
			DLC_ID = -1;
			Affects_Savegame = false;
			Need_Mount = false;
		}


		public DLC(Table table, BinaryReader reader) : base(table, reader)
		{ // TODO: Handle padding here.

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


	}
}