using System;
using System.IO;
using Sharp.Reporting;

namespace KCD.Library.Tables.Format
{
	interface IHeaderBlock
	{
		int FormatVersion { get; }
		uint DescriptorsHash { get; }
		uint LayoutHash { get; }
		int TableVersion { get; }
		int RowCount { get; }
		int StringDataSize { get; }
		int StringUniqueCount { get; }
	}
	/// <summary>
	/// Generating new hashes is unnecessary because new XML files cannot be added without modifying the game binaries.
	/// </summary>
	public class HeaderBlock : Block, IHeaderBlock
	{
		#region IHeaderBlock

		/// <summary>
		/// The file format version for this table.
		/// </summary>
		public int FormatVersion { get; private set; }

		/// <summary>
		/// The table descriptors hash.
		/// </summary>
		/// <seealso cref="Table.HashDefault"/>
		public uint DescriptorsHash { get; private set; }

		/// <summary>
		/// The table layout hash.
		/// </summary>
		/// <seealso cref="Table.HashDefault"/>
		public uint LayoutHash { get; private set; }

		/// <summary>
		/// The table version.
		/// </summary>
		public int TableVersion { get; private set; }

		/// <summary>
		/// The number of row lines in this table.
		/// </summary>
		public int RowCount { get; private set; }

		/// <summary>
		///The total string data block size.
		/// </summary>
		public int StringDataSize { get; private set; }

		/// <summary>
		/// The number of unique strings in this table.
		/// </summary>
		public int StringUniqueCount { get; private set; }

		#endregion


		/// <summary>
		/// Creates a new header block for this table.
		/// </summary>
		/// <param name="table">The table which owns this block.</param>
		public HeaderBlock(Table table) : base(table)
		{
			FormatVersion = 0;
			DescriptorsHash = 0;
			LayoutHash = 0;
			TableVersion = 0;
			RowCount = 0;
			StringDataSize = 0;
			StringUniqueCount = 0;
		}


		/// <summary>
		/// The header size is 7 bytes or 28 bits.
		/// </summary>
		/// <returns>The header size in bits. This will always be 28 bits.</returns>
		protected override long GetSize()
		{
			return sizeof(int) * 7;
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
				FormatVersion = reader.ReadInt32();
				DescriptorsHash = reader.ReadUInt32();
				LayoutHash = reader.ReadUInt32();
				TableVersion = reader.ReadInt32();
				RowCount = reader.ReadInt32();
				StringDataSize = reader.ReadInt32();
				StringUniqueCount = reader.ReadInt32();
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
