using System;
using System.IO;

namespace KCD.Library.Prototype
{
	//random_event_option_id(integer; 4 bytes)
	//random_event_option_set_id(integer; 4 bytes)
	//random_event_source_type_id(integer; 4 bytes)
	//ui_caption(text; 4 bytes)
	//condition_expression(text; 4 bytes)
	//chance_expression(text; 4 bytes)
	//success_cmd(text; 4 bytes)
	//fail_cmd(text; 4 bytes)
	//success_msg(text; 4 bytes)
	//fail_msg(text; 4 bytes)
	public class Random_Event_Option : Row
	{

		public Random_Event_Option(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Random_Event_Option(Table table, BinaryReader reader) : base(table, reader)
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