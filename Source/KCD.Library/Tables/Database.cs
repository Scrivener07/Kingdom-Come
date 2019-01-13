using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Kaitai;
using KCD.Library.Tables.Adapters;
using Sharp;
using Sharp.Reporting;

namespace KCD.Library.Tables
{
	/// <summary>
	/// A database is a collection of tables.
	/// </summary>
	public class Database
	{
		/// <summary>
		/// The games vanilla data table directory.
		/// </summary>
		public readonly string Folder;

		/// <summary>
		/// The name of this database.
		/// </summary>
		public readonly string Name;


		[Category("Database")]
		[Description("The tables belonging to this database.")]
		[TypeConverter(typeof(RowCollectionConverter))]
		public TableCollection Tables { get; private set; }


		[Category("Database")]
		[Description("The entities belonging to this database.")]
		public BindingList<KaitaiStruct> Entities { get; private set; }


		public Database(string folder, string name = "")
		{
			if (!Directory.Exists(folder))
			{
				throw new DirectoryNotFoundException(string.Format("Could not find the `{0}` directory.", folder));
			}
			else
			{
				Folder = folder;
				if (string.IsNullOrWhiteSpace(name)) Guid.NewGuid().ToString();
				else Name = name;
				Tables = new TableCollection();
				Entities = new BindingList<KaitaiStruct>();
				if (!Definition.Initialized) { Definition.Initialize(); }
				Trace.WriteLine(string.Format("Created database at '{0}'.", Folder));
			}
		}


		public void Import()
		{
			ImportDirectory(Folder);
		}


		private bool ImportDirectory(string directory, SearchOption option = SearchOption.AllDirectories)
		{
			bool success = true;
			try
			{
				var filepaths = SharpIO.GetFiles(directory, ".tbl", option);
				foreach (var filepath in filepaths)
				{
					ImportFile(filepath);
				}
			}
			catch (Exception exception)
			{
				success = false;
				Trace.WriteLine(exception.GetReport());
			}

			Trace.WriteLine(string.Format("Loaded {0} tables.", Entities.Count));
			return success;
		}


		private bool ImportFile(string filepath)
		{
			string fullpath = Path.GetFullPath(filepath);
			if (File.Exists(fullpath))
			{
				Table table = new Table(this, fullpath);
				Tables.Add(table);
				Entities.Add(table.Raw);
				return true;
			}
			else
			{
				Trace.WriteLine(string.Format("The file {0} does not exist.", fullpath));
				return false;
			}
		}


		public override string ToString()
		{
			return Name;
		}


	}
}
