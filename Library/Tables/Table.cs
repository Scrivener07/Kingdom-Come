using System;
using System.IO;
using KingdomCome.Library.Tables.Format;
using Sharp.Reporting;

namespace KingdomCome.Library.Tables
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
		public TableHeader Header;

		/// <summary>
		/// The row data for a table file.
		/// </summary>
		public TableRowData Rows;

		/// <summary>
		/// The string data for a table file.
		/// </summary>
		public TableStringData Strings;

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
				Header = new TableHeader(this);
				Rows = new TableRowData(this);
				Strings = new TableStringData(this);
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
					Header = new TableHeader(this);
					Header.Read(reader);

					Rows = new TableRowData(this);
					Rows.Read(reader);

					Strings = new TableStringData(this);
					Strings.Read(reader);
				}
				catch (Exception exception)
				{
					success = false;
					Console.WriteLine(exception.GetReport());
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
			Console.WriteLine("Table File:" + FileName);
			Console.WriteLine("Header");
			Console.WriteLine("---- FileFormatVersion:" + Header.FileFormatVersion);
			Console.WriteLine("---- DescriptorsHash:" + Header.DescriptorsHash);
			Console.WriteLine("---- LayoutHash:" + Header.LayoutHash);
			Console.WriteLine("---- TableVersion:" + Header.TableVersion);
			Console.WriteLine("---- LineCount:" + Header.LineCount);
			Console.WriteLine("---- StringDataSize:" + Header.StringDataSize);
			Console.WriteLine("---- UniqueStringCount:" + Header.UniqueStringCount);
			Console.WriteLine("Rows");
			Console.WriteLine("---- Data:" + Rows.Data);
			Console.WriteLine("Strings");
			Console.WriteLine("---- Data:" + Strings.Data);
			Console.WriteLine("\n");
		}

		/// <summary>
		/// The string representation of this object.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return FileName;
		}


	}
}
