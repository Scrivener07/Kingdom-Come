using System;
using System.IO;

namespace KCD.Library.Tables
{
	//computer_name(text; 4 bytes)
	//timestamp(text; 4 bytes)
	//character_hair_id(uuid; 16 bytes)
	//character_hair_name(text; 4 bytes)
	//model(text; 4 bytes)
	//material(text; 4 bytes)
	//social_class_id(integer; 4 bytes)
	//wealth_level(integer; 4 bytes)
	//gender_id(integer; 4 bytes)
	//race_id(integer; 4 bytes)
	//character_hair_archetype_id(integer; 4 bytes)
	public class Character_Hair : Row
	{

		public Character_Hair(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Character_Hair(Table table, BinaryReader reader) : base(table, reader)
		{
			throw new NotImplementedException();
		}


		protected override Guid GetID()
		{
			throw new NotImplementedException();
		}


	}
}