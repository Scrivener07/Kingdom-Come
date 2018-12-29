using System;
using System.IO;
using Sharp.Reporting;

namespace KCD.Library.Tables.Format
{
	public class TableRowData : DataBlock
	{
		public object Data { get; private set; }

		public TableRowData(Table table) : base(table)
		{
			Data = new object();
		}


		#region DataBlock

		public override long GetSize()
		{
			return Self.Header.LineSize * Self.Header.LineCount;
		}





		public override bool Read(BinaryReader reader)
		{
			byte[] bytes = new byte[0]; // TODO: array size
			int index = 0;
			while (index < Self.Header.LineCount)
			{
				ReadRow(reader);
				index += 1;
			}

			return true;
		}


		private bool ReadRow(BinaryReader reader)
		{
			bool success = true;
			Entity entity;
			try
			{
				if (Self.Key == Definition.Achievement)
				{
					entity = new Achievement(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Achievement_Rule)
				{
					entity = new Achievement_Rule(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Character_Beard)
				{
					entity = new Character_Beard(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Character_Body)
				{
					entity = new Character_Body(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Character_Hair)
				{
					entity = new Character_Hair(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Character_Head)
				{
					entity = new Character_Head(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.DLC)
				{
					entity = new DLC(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Editor_Object)
				{
					entity = new Editor_Object(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Editor_Object_Binding)
				{
					entity = new Editor_Object_Binding(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Faction)
				{
					entity = new Faction(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Game_Mode)
				{
					entity = new Game_Mode(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Perk)
				{
					entity = new Perk(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.POI_Type)
				{
					entity = new POI_Type(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.POI_Type2Perk)
				{
					entity = new POI_Type2Perk(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Race)
				{
					entity = new Race(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Random_Event)
				{
					entity = new Random_Event(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Random_Event_Option)
				{
					entity = new Random_Event_Option(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Random_Event_Option_Set)
				{
					entity = new Random_Event_Option_Set(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else if (Self.Key == Definition.Random_Event_Source_Type)
				{
					entity = new Random_Event_Source_Type(Self, reader);
					Self.Owner.Entities.Add(entity);
				}
				else
				{
					Console.WriteLine("An unknown type definition has been encountered. Key:" + Self.Key);
				}
			}
			catch (Exception exception)
			{
				success = false;
				Console.WriteLine(exception.GetReport());
			}

			return success;
		}


		public override bool Write(BinaryWriter writer)
		{
			throw new NotImplementedException();
		}

		#endregion

	}
}
