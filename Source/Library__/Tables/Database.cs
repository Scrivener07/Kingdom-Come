﻿using System;
using System.ComponentModel;
using System.IO;
using Sharp;
using Sharp.Reporting;

namespace KingdomCome.Library.Tables
{
	public class Database
	{
		/// <summary>
		/// The games vanilla data table directory.
		/// </summary>
		public readonly string Folder;

		/// <summary>
		/// A collection of table files which are used for on disk storage.
		/// </summary>
		/// <remarks>The "Data Store"</remarks>
		private BindingList<Table> Tables { get; set; }

		/// <summary>
		/// A collection of table entities which exist as CLR objects.
		/// </summary>
		public BindingList<Entity> Entities { get; private set; }


		public Database(string folder)
		{
			if (!Directory.Exists(folder))
			{
				throw new DirectoryNotFoundException(string.Format("Could not find the `{0}` directory.", folder));
			}
			Folder = folder;
			Definition.Initialize();
			Tables = new BindingList<Table>();
			Entities = new BindingList<Entity>();
			Console.WriteLine("Created the database.\n\n");
		}


		public void Import()
		{
			//ImportDirectory(Folder);
			ImportFile(Path.Combine(Folder, "rpg", "poi_type.tbl"));
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
				Console.WriteLine(exception.GetReport());
			}

			Console.WriteLine(string.Format("Loaded {0} tables.", Tables.Count));
			return success;
		}


		private bool ImportFile(string filepath)
		{
			if (File.Exists(filepath))
			{
				Table table = new Table(this, filepath);
				if (table.Read())
				{
					Tables.Add(table);
					table.Print();
					Console.WriteLine(string.Format("Loaded `{0}` with descriptor type {1}.", filepath, table.Key));
					return true;
				}
				else
				{
					Console.WriteLine(string.Format("Failed to load `{0}`.", filepath));
					return false;
				}
			}
			else
			{
				throw new FileNotFoundException(filepath);
			}
		}


	}
}