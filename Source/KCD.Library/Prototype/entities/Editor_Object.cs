using System;
using System.IO;

namespace KCD.Library.Prototype
{
	//computer_name(text; 4 bytes)
	//timestamp(text; 4 bytes)
	//level_name(text; 4 bytes)
	//id(uuid; 16 bytes)
	//name(text; 4 bytes)
	//type(text; 4 bytes)
	public class Editor_Object : Row
	{


		public Editor_Object(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Editor_Object(Table table, BinaryReader reader) : base(table, reader)
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