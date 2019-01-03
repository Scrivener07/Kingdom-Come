using System;
using System.IO;

namespace KCD.Library.Tables
{
	//poi_type_id(uuid; 16 bytes)
	//perk_id(uuid; 16 bytes)
	public class Race : Row
	{

		public Race(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Race(Table table, BinaryReader reader) : base(table, reader)
		{
			throw new NotImplementedException();
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
