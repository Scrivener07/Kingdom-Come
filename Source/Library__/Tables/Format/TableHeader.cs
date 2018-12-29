using System;
using System.IO;
using Sharp.Reporting;

namespace KingdomCome.Library.Tables.Format
{
	/// <summary>
	/// Generating new hashes is unnecessary because new XML files cannot be added without modifying the game binaries.
	/// </summary>
	public class TableHeader : DataBlock
	{
		#region Table

		/// <summary>
		/// The table format version used.
		/// </summary>
		public int FileFormatVersion { get; private set; }

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
		/// The number of rows in this table.
		/// </summary>
		public int LineCount { get; private set; }

		/// <summary>
		///The total string data block size.
		/// </summary>
		public int StringDataSize { get; private set; }

		/// <summary>
		/// The number of unique strings.
		/// </summary>
		public int UniqueStringCount { get; private set; }

		#endregion

		/// <summary>
		/// The size of the row data block.
		/// </summary>
		public long LineSize { get; private set; }


		public TableHeader(Table table) : base(table)
		{
			FileFormatVersion = 0;
			DescriptorsHash = 0;
			LayoutHash = 0;
			TableVersion = 0;
			LineCount = 0;
			StringDataSize = 0;
			UniqueStringCount = 0;
			LineSize = 0;
		}


		#region DataBlock

		public override long GetSize()
		{
			return 28;
		}


		public override bool Read(BinaryReader reader)
		{
			bool success = true;
			try
			{
				FileFormatVersion = reader.ReadInt32();
				DescriptorsHash = reader.ReadUInt32();
				LayoutHash = reader.ReadUInt32();
				TableVersion = reader.ReadInt32();
				LineCount = reader.ReadInt32();
				StringDataSize = reader.ReadInt32();
				UniqueStringCount = reader.ReadInt32();
			}
			catch (Exception exception)
			{
				success = false;
				Console.WriteLine(exception.GetReport());
			}

			if (success)
			{
				LineSize = GetLineSize();
			}

			return success;
		}


		public override bool Write(BinaryWriter writer)
		{
			throw new NotImplementedException();
		}

		#endregion


		private long GetLineSize()
		{
			if (LineCount != 0) return (Self.FileSize - GetSize() - StringDataSize) / LineCount;
			else return 0;
		}


		[Obsolete("This is not working correctly, or doesnt measure what I expected it to.")]
		private long GetStringDataSize()
		{
			// TODO: Calculates `588` for the `character_beard.tbl` table?
			return GetSize() + LineSize * LineCount;
		}


	}
}
