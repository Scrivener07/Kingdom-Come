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
				if (Self.Key == Definition.Character_Beard)
				{
					CLR = new Character_Beard(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Achievement)
				{
					CLR = new Achievement(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Achievement_Rule)
				{
					CLR = new Achievement_Rule(Self, reader);
					Self.Owner.Entities.Add(CLR);
				}
				else if (Self.Key == Definition.Perk)
				{
					CLR = new Perk(Self, reader);
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
