using System;
using System.Diagnostics;
using System.IO;
using KCD.Library.Tables.Format;
using Sharp.Reporting;

namespace KCD.Library.Tables
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
		/// Used for looking up this table type definition.
		/// </summary>
		public uint Key { get { return Header.DescriptorsHash; } }

		/// <summary>
		/// These hashes are not dynamically generated based on the table content; they are hardcoded.
		/// </summary>
		/// <remarks>32-bit FNV-1a</remarks>
		public uint HashDefault { get { return 0x811c9dc5; } }

		/// <summary>
		///The file size of this table.
		/// </summary>
		public long FileSize { get; private set; }

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
				try
				{
					Header = new HeaderBlock(this);
					Header.Read(reader);

					Row = new RowBlock(this);
					Row.Read(reader);

					Text = new TextBlock(this);
					Text.Read(reader);
				}
				catch (Exception exception)
				{
					success = false;
					Trace.WriteLine(exception.GetReport());
				}
			}
			return success;
		}

		#endregion



		/// <summary>
		/// Prints table information to the console.
		/// </summary>
		public void Print()
		{
			Trace.WriteLine("Table File: " + FileName);
			Trace.WriteLine("Header:" + Header.ToString());
			Trace.WriteLine("---- FormatVersion: " + Header.FormatVersion);
			Trace.WriteLine("---- DescriptorsHash: " + Header.DescriptorsHash);
			Trace.WriteLine("---- LayoutHash: " + Header.LayoutHash);
			Trace.WriteLine("---- TableVersion: " + Header.TableVersion);
			Trace.WriteLine("---- RowCount: " + Header.RowCount);
			Trace.WriteLine("---- StringDataSize: " + Header.StringDataSize);
			Trace.WriteLine("---- StringUniqueCount: " + Header.StringUniqueCount);
			Trace.WriteLine("Row: " + Row.ToString());
			Trace.WriteLine("---- Count: ");
			Trace.WriteLine("Text: " + Text.ToString());
			Trace.WriteLine("---- Data: ");
			Trace.WriteLine("\n");
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
