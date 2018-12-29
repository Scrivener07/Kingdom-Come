using System;
using System.IO;

namespace KCD.Library.Tables
{
	//random_event_id(integer; 4 bytes)
	//ui_caption(text; 4 bytes)
	//condition_expression(text; 4 bytes)
	//base_run_chance(real; 4 bytes)
	//night_run_chance_modif(real; 4 bytes)
	//map_disappear_time(real; 4 bytes)
	//map_game_speed(real; 4 bytes)
	//map_icon_id(integer; 4 bytes)
	//random_event_option_set_id(integer; 4 bytes)
	//cooldown(text; 4 bytes)
	public class Random_Event : Entity
	{

		public Random_Event(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Random_Event(Table table, BinaryReader reader) : base(table, reader)
		{
			throw new NotImplementedException();
		}


	}
}