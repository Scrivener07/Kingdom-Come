using System;
using System.Diagnostics;
using System.IO;
using KCD.Library.Prototype.Format;

namespace KCD.Library.Prototype
{
	public class Table
	{
		#region Meta

		/// <summary>
		/// The database which is responsible for loading this table.
		/// </summary>
		public readonly Database Owner;

		/// <summary>
		/// The file path of this table.
		/// </summary>
		public readonly string FileName;

		/// <summary>
		///The file size of this table.
		/// </summary>
		public long FileSize { get; private set; }

		/// <summary>
		/// Used for looking up this table type definition.
		/// </summary>
		public uint Key { get { return Header.DescriptorsHash; } }

		/// <summary>
		/// True if this table contains string text.
		/// </summary>
		public bool HasText { get { return Header.StringUniqueCount > 0; } }


		/// <summary>
		/// These hashes are not dynamically generated based on the table content; they are hardcoded.
		/// </summary>
		/// <remarks>32-bit FNV-1a</remarks>
		public uint HashDefault { get { return 0x811c9dc5; } }

		#endregion

		#region Blocks

		/// <summary>
		/// The header data for a table file.
		/// </summary>
		public HeaderBlock Header;

		/// <summary>
		/// The row data for a table file.
		/// </summary>
		public RowBlock Row;

		/// <summary>
		/// The string data for a table file.
		/// </summary>
		public TextBlock Text;

		#endregion


		public Table(Database database, string filename)
		{
			if (database == null)
			{
				throw new ArgumentNullException("database", "A table requires an owning database which cannot be null.");
			}
			else if (!File.Exists(filename))
			{
				throw new FileNotFoundException(string.Format("The file '{0}' does not exist. ", filename), filename);
			}
			else
			{
				Owner = database;
				FileName = filename;
				Header = new HeaderBlock(this);
				Row = new RowBlock(this);
				Text = new TextBlock(this);
			}
		}


		#region IO

		public bool Read()
		{
			if (!File.Exists(FileName))
			{
				throw new FileNotFoundException(string.Format("The file '{0}' does not exist. ", FileName), FileName);
			}

			bool success = true;
			using (BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open)))
			{
				FileSize = reader.BaseStream.Length;

				Header = new HeaderBlock(this);
				Header.Read(reader);

				Row = new RowBlock(this);
				Row.Read(reader);

				Text = new TextBlock(this);
				Text.Read(reader);
			}
			return success;
		}

		#endregion



		/// <summary>
		/// Prints table information to the console.
		/// </summary>
		public void Print()
		{
			Trace.WriteLine("|----------------------------------------");
			Trace.WriteLine(string.Format("|File: {0}", FileName));
			Trace.WriteLine("|----------------------------------------");
			Trace.WriteLine(string.Format("|    FileSize: {0}", FileSize));
			Trace.WriteLine(string.Format("|    HasText: {0}", HasText));
			Trace.WriteLine(string.Format("|Header: {0}", Header.ToString()));
			Trace.WriteLine(string.Format("|    FormatVersion: {0}", Header.FormatVersion));
			Trace.WriteLine(string.Format("|    DescriptorsHash: {0}", Header.DescriptorsHash));
			Trace.WriteLine(string.Format("|    LayoutHash: {0}", Header.LayoutHash));
			Trace.WriteLine(string.Format("|    TableVersion: {0}", Header.TableVersion));
			Trace.WriteLine(string.Format("|    RowCount: {0}", Header.RowCount));
			Trace.WriteLine(string.Format("|    StringDataSize: {0}", Header.StringDataSize));
			Trace.WriteLine(string.Format("|    StringUniqueCount: {0}", Header.StringUniqueCount));
			Trace.WriteLine(string.Format("|Row: {0}", Row.ToString()));
			Trace.WriteLine(string.Format("|    RowSize: {0}", Row.RowSize));
			Trace.WriteLine(string.Format("|Text: {0}", Text.ToString()));
			Trace.WriteLine(string.Format("|    HasText: {0}", HasText));
			Trace.WriteLine("|----------------------------------------");
			Trace.WriteLine(Environment.NewLine);
		}


		/// <summary>
		/// The string representation of this object.
		/// </summary>
		/// <returns>Returns a string which represents this object.</returns>
		public override string ToString()
		{
			return FileName;
		}


	}
}
