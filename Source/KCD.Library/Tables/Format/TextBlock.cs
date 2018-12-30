using System;
using System.IO;
using Sharp.Reporting;

namespace KCD.Library.Tables.Format
{
	public class TextBlock : Block
	{
		/// <summary>
		/// Creates a new text block for this table.
		/// </summary>
		/// <param name="table">The table which owns this block.</param>
		public TextBlock(Table table) : base(table) { }


		/// <summary>
		/// Gets the size of this block in bits.
		/// </summary>
		/// <returns>Returns the size of this block in bits.</returns>
		protected override long GetSize()
		{
			return Self.Header.StringDataSize;
		}


		/// <summary>
		/// Reads from the table file.
		/// </summary>
		/// <param name="reader">The binary reader to use.</param>
		/// <returns>Returns true on success.</returns>
		public override bool Read(BinaryReader reader)
		{
			bool success = true;
			try
			{
				//Data = reader.ReadInt32();
			}
			catch (Exception exception)
			{
				success = false;
				Console.WriteLine(exception.GetReport());
			}
			return success;
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
