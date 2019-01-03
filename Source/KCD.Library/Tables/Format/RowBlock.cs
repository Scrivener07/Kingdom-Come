using System;
using System.IO;

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
		/// Gets the size of this block in bytes.
		/// </summary>
		/// <returns>Returns the size of this block in bytes.</returns>
		protected override long GetSize()
		{
			return RowSize * Self.Header.RowCount;
		}


		/// <summary>
		/// Gets the line size of each row in the row data block.
		/// </summary>
		/// <returns>Returns the line size of an individual row in the row data block.</returns>
		private long GetRowSize()
		{
			if (Self.Header.RowCount != 0) return (Self.FileSize - Self.Header.Size - Self.Header.StringDataSize) / Self.Header.RowCount;
			else return 0;
		}


		/// <summary>
		/// Gets the total size of the string data block.
		/// </summary>
		/// <returns>The size in bytes.</returns>
		private long GetStringDataSize()
		{
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
				Row row = reader.ReadRow(Self);
				if (row != null)
				{
					Self.Owner.Rows.Add(row);
				}
				else
				{
					// TODO: Suppress tracing here, most types are not known.
					// Its screwing up the signal-to-noise ratio of logs.
					//Trace.WriteLine("An unknown row type definition has been encountered. Key:" + Self.Key);
				}

				index += 1;
			}

			return true;
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
