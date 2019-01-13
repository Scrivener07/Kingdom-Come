using System;
using System.IO;

namespace KCD.Library.Prototype
{
	//random_event_source_type_id(integer; 4 bytes)
	//random_event_source_type_name(text; 4 bytes)
	public class Random_Event_Source_Type : Row
	{

		public Random_Event_Source_Type(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Random_Event_Source_Type(Table table, BinaryReader reader) : base(table, reader)
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