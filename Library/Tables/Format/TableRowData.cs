using System;
using System.IO;
using Sharp.Reporting;

namespace KingdomCome.Library.Tables.Format
{
	public class TableRowData : DataBlock
	{
		public int Data { get; private set; }
		public Entity CLR { get; private set; }


		public TableRowData(Table table) : base(table)
		{
			Data = 0;
		}


		#region DataBlock

		public override long GetSize()
		{
			return Self.Header.LineSize;
		}


		public override bool Read(BinaryReader reader)
		{
			bool success = true;
			try
			{
				if (Self.Key == Definition.Achievement)
				{
					CLR = new Achievement(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Achievement_Rule)
				{
					CLR = new Achievement_Rule(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Character_Beard)
				{
					CLR = new Character_Beard(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Character_Body)
				{
					CLR = new Character_Body(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Character_Hair)
				{
					CLR = new Character_Hair(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Character_Head)
				{
					CLR = new Character_Head(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.DLC)
				{
					CLR = new DLC(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Editor_Object)
				{
					CLR = new Editor_Object(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Editor_Object_Binding)
				{
					CLR = new Editor_Object_Binding(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Faction)
				{
					CLR = new Faction(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Game_Mode)
				{
					CLR = new Game_Mode(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Perk)
				{
					CLR = new Perk(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Race)
				{
					CLR = new Race(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Random_Event)
				{
					CLR = new Random_Event(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Random_Event_Option)
				{
					CLR = new Random_Event_Option(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Random_Event_Option_Set)
				{
					CLR = new Random_Event_Option_Set(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Random_Event_Source_Type)
				{
					CLR = new Random_Event_Source_Type(Self, reader);
					Self.Owner.Entities.Add(CLR);
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
