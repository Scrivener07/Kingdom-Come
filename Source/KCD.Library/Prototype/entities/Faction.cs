using System;
using System.IO;

namespace KCD.Library.Prototype
{
	//faction_id(integer; 4 bytes)
	//faction_name(text; 4 bytes)
	//description(text; 4 bytes)
	//player_reputation(real; 4 bytes)
	//superfaction_id(integer; 4 bytes)
	//location_id(uuid; 16 bytes)
	//visible(boolean; 1 bytes)
	public class Faction : Row
	{

		public Faction(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Faction(Table table, BinaryReader reader) : base(table, reader)
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