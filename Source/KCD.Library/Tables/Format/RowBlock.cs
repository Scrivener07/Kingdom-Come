using System;
using System.IO;
using Sharp.Reporting;

namespace KCD.Library.Tables.Format
{
	public class RowBlock : Block
	{
		/// <summary>
		/// The line size of each row in the row data block.
		/// </summary>
		public long RowSize { get; private set; }


		/// <summary>
		/// Creates a new row block for this table.
		/// </summary>
		/// <param name="table">The table which owns this block.</param>
		public RowBlock(Table table) : base(table)
		{
			RowSize = 0;
		}


		/// <summary>
		/// Gets the size of this block in bits.
		/// </summary>
		/// <returns>Returns the size of this block in bits.</returns>
		protected override long GetSize()
		{
			return RowSize * Self.Header.RowCount;
		}


		/// <summary>
		/// Gets the line size of each row in the row data block.
		/// </summary>
		/// <returns>Returns the line size of each row in the row data block.</returns>
		private long GetRowSize()
		{
			if (Self.Header.RowCount != 0) return (Self.FileSize - Self.Header.Size - Self.Header.StringDataSize) / Self.Header.RowCount;
			else return 0;
		}


		[Obsolete("This is not working correctly, or doesnt measure what I expected it to.")]
		private long GetStringDataSize()
		{
			// TODO: Calculates `588` for the `character_beard.tbl` table?
			return Self.Header.Size + RowSize * Self.Header.RowCount;
		}


		/// <summary>
		/// Reads from the table file.
		/// </summary>
		/// <param name="reader">The binary reader to use.</param>
		/// <returns>Returns true on success.</returns>
		public override bool Read(BinaryReader reader)
		{
			RowSize = GetRowSize();
			int index = 0;
			while (index < Self.Header.RowCount)
			{
				Row row = ReadRow(reader);
				if (row != null)
				{
					Self.Owner.Rows.Add(row);
				}
				else
				{
					Console.WriteLine("An unknown row type definition has been encountered. Key:" + Self.Key);
				}

				index += 1;
			}

			return true;
		}


		/// <summary>
		/// Reads an individual row line from the table file.
		/// </summary>
		/// <param name="reader">The binary reader to use.</param>
		/// <returns>Returns true on success.</returns>
		private Row ReadRow(BinaryReader reader)
		{
			Row row = null;
			try
			{
				if (Self.Key == Definition.Achievement)
				{
					row = new Achievement(Self, reader);
				}
				else if (Self.Key == Definition.Achievement_Rule)
				{
					row = new Achievement_Rule(Self, reader);
				}
				else if (Self.Key == Definition.Character_Beard)
				{
					row = new Character_Beard(Self, reader);
				}
				else if (Self.Key == Definition.Character_Body)
				{
					row = new Character_Body(Self, reader);
				}
				else if (Self.Key == Definition.Character_Hair)
				{
					row = new Character_Hair(Self, reader);
				}
				else if (Self.Key == Definition.Character_Head)
				{
					row = new Character_Head(Self, reader);
				}
				else if (Self.Key == Definition.DLC)
				{
					row = new DLC(Self, reader);
				}
				else if (Self.Key == Definition.Editor_Object)
				{
					row = new Editor_Object(Self, reader);
				}
				else if (Self.Key == Definition.Editor_Object_Binding)
				{
					row = new Editor_Object_Binding(Self, reader);
				}
				else if (Self.Key == Definition.Faction)
				{
					row = new Faction(Self, reader);
				}
				else if (Self.Key == Definition.Game_Mode)
				{
					row = new Game_Mode(Self, reader);
				}
				else if (Self.Key == Definition.Perk)
				{
					row = new Perk(Self, reader);
				}
				else if (Self.Key == Definition.POI_Type)
				{
					row = new POI_Type(Self, reader);
				}
				else if (Self.Key == Definition.POI_Type2Perk)
				{
					row = new POI_Type2Perk(Self, reader);
				}
				else if (Self.Key == Definition.Race)
				{
					row = new Race(Self, reader);
				}
				else if (Self.Key == Definition.Random_Event)
				{
					row = new Random_Event(Self, reader);
				}
				else if (Self.Key == Definition.Random_Event_Option)
				{
					row = new Random_Event_Option(Self, reader);
				}
				else if (Self.Key == Definition.Random_Event_Option_Set)
				{
					row = new Random_Event_Option_Set(Self, reader);
				}
				else if (Self.Key == Definition.Random_Event_Source_Type)
				{
					row = new Random_Event_Source_Type(Self, reader);
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.GetReport());
			}

			return row;
		}


		/// <summary>
		/// Writes to the table file.
		/// </summary>
		/// <param name="writer">The binary writer to use.</param>
		/// <returns>Returns true on success.</returns>
		public override bool Write(BinaryWriter writer)
		{
			throw new NotImplementedException();
		}


	}
}
