using System;
using System.IO;

namespace KCD.Library.Prototype
{
	//computer_name(text; 4 bytes)
	//timestamp(text; 4 bytes)
	//source_id(uuid; 16 bytes)
	//target_id(uuid; 16 bytes)
	//note(text; 4 bytes)
	//position(text; 4 bytes)
	//rotate(text; 4 bytes)
	//scale(text; 4 bytes)
	public class Editor_Object_Binding : Row
	{

		public Editor_Object_Binding(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Editor_Object_Binding(Table table, BinaryReader reader) : base(table, reader)
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