using System;
using System.IO;

namespace KCD.Library.Tables
{
	//dlc_id(integer; 4 bytes)
	//affects_savegame(boolean; 1 bytes)
	//need_mount(boolean; 1 bytes)
	public class DLC : Row
	{


		public DLC(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public DLC(Table table, BinaryReader reader) : base(table, reader)
		{
			throw new NotImplementedException();
		}


		protected override Guid GetID()
		{
			throw new NotImplementedException();
		}


	}
}