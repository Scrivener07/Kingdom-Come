using System;
using System.IO;

namespace KCD.Library.Tables
{
	//computer_name(text; 4 bytes)
	//timestamp(text; 4 bytes)
	//source_id(uuid; 16 bytes)
	//target_id(uuid; 16 bytes)
	//note(text; 4 bytes)
	//position(text; 4 bytes)
	//rotate(text; 4 bytes)
	//scale(text; 4 bytes)
	public class Editor_Object_Binding : Entity
	{

		public Editor_Object_Binding(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Editor_Object_Binding(Table table, BinaryReader reader) : base(table, reader)
		{
			throw new NotImplementedException();
		}


	}
}