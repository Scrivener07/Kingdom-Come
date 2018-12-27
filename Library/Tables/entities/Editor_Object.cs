using System;
using System.IO;

namespace KingdomCome.Library.Tables
{
	//computer_name(text; 4 bytes)
	//timestamp(text; 4 bytes)
	//level_name(text; 4 bytes)
	//id(uuid; 16 bytes)
	//name(text; 4 bytes)
	//type(text; 4 bytes)
	public class Editor_Object : Entity
	{


		public Editor_Object(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Editor_Object(Table table, BinaryReader reader) : base(table, reader)
		{
			throw new NotImplementedException();
		}


	}
}