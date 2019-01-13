using System;
using System.IO;

// Note: Has Padding

//game_over_id(integer; 4 bytes)
//game_over_name(text; 4 bytes)
//game_over_ui_message(text; 4 bytes)
//game_over_type_id(integer; 4 bytes)
namespace KCD.Library.Prototype
{
	class Game_Over : Row
	{
		public int Game_Over_ID { get; set; }
		public string Game_Over_Name { get; set; }
		public string Game_Over_UI_Message { get; set; }
		public int Game_Over_Type_ID { get; set; }


		public Game_Over(Table table) : base(table)
		{
			Game_Over_ID = -1;
			Game_Over_Name = string.Empty;
			Game_Over_UI_Message = string.Empty;
			Game_Over_Type_ID = -1;
		}


		//  Calculated Row Size is 32
		// Each value (int 4)+(text 4)+(text 4)+(int 4) is 16
		// 16 bytes of padding
		public Game_Over(Table table, BinaryReader reader) : base(table, reader)
		{
			Game_Over_ID = reader.ReadTableInteger();
			reader.SkipBytes(4);
			Game_Over_Name = reader.ReadTableText();
			reader.SkipBytes(4);
			Game_Over_UI_Message = reader.ReadTableText();
			reader.SkipBytes(4);
			Game_Over_Type_ID = reader.ReadTableInteger();
			reader.SkipBytes(4);
		}


		protected override Guid GetID()
		{
			return Guid.Empty;
		}


		public override string ToString()
		{
			return string.Format("ID:{0} [Type:{1}::{2}]", Game_Over_ID, GetType().Name, Owner.Key);
		}


		protected override long GetSizeActual()
		{
			return 16;
		}


	}
}