using System;
using System.IO;

namespace KCD.Library.Tables
{
	//computer_name(text; 4 bytes)
	//timestamp(text; 4 bytes)
	//character_beard_id(uuid; 16 bytes)
	//character_beard_name(text; 4 bytes)
	//model(text; 4 bytes)
	//material(text; 4 bytes)
	//social_class_id(integer; 4 bytes)
	//wealth_level(integer; 4 bytes)
	//gender_id(integer; 4 bytes)
	//race_id(integer; 4 bytes)
	//character_beard_archetype_id(integer; 4 bytes)
	public class Character_Beard : Row
	{
		public int ComputerName { get; set; }
		public int Timestamp { get; set; }
		public Guid CharacterBeard_ID { get; set; }
		public int CharacterBeard_Name { get; set; }
		public int Model { get; set; }
		public int Material { get; set; }
		public int SocialClass_ID { get; set; }
		public int WealthLevel { get; set; }
		public int Gender_ID { get; set; }
		public int Race_ID { get; set; }
		public int CharacterBeard_Archetype_ID { get; set; }


		public Character_Beard(Table table) : base(table)
		{
			ComputerName = 0;
			Timestamp = 0;
			CharacterBeard_ID = Guid.Empty;
			CharacterBeard_Name = 0;
			Model = 0;
			Material = 0;
			SocialClass_ID = 0;
			WealthLevel = 0;
			Gender_ID = 0;
			Race_ID = 0;
			CharacterBeard_Archetype_ID = 0;
		}


		public Character_Beard(Table table, BinaryReader reader) : base(table, reader)
		{
			ComputerName = reader.ReadTableInteger();
			Timestamp = reader.ReadTableInteger();
			CharacterBeard_ID = reader.ReadTableGuid();
			CharacterBeard_Name = reader.ReadTableInteger();
			Model = reader.ReadTableInteger();
			Material = reader.ReadTableInteger();
			SocialClass_ID = reader.ReadTableInteger();
			WealthLevel = reader.ReadTableInteger();
			Gender_ID = reader.ReadTableInteger();
			Race_ID = reader.ReadTableInteger();
			CharacterBeard_Archetype_ID = reader.ReadTableInteger();
		}


		protected override Guid GetID()
		{
			throw new NotImplementedException();
		}


	}
}
