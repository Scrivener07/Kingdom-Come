using System;
using System.IO;

namespace KCD.Library.Prototype
{
	//random_event_option_set_id(integer; 4 bytes)
	//random_event_option_set_name(text; 4 bytes)
	public class Random_Event_Option_Set : Row
	{

		public Random_Event_Option_Set(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Random_Event_Option_Set(Table table, BinaryReader reader) : base(table, reader)
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