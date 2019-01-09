using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Kaitai;
using Sharp;
using Sharp.Reporting;

namespace KCD.Kaitai.Tables
{
	public class Database
	{
		/// <summary>
		/// The games vanilla data table directory.
		/// </summary>
		public readonly string Folder;

		private BindingList<KaitaiStruct> Entities;


		public Database(string folder)
		{
			if (!Directory.Exists(folder))
			{
				throw new DirectoryNotFoundException(string.Format("Could not find the `{0}` directory.", folder));
			}
			else
			{
				Folder = folder;
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
				string filename = Path.GetFileName(fullpath);

				Type type = Definition.GetType(filename);
				if (type != null)
				{
					object[] arguments = new object[1];
					arguments[0] = filepath;
					var output = (KaitaiStruct)type.GetMethod("FromFile", BindingFlags.Public | BindingFlags.Static).Invoke(null, arguments);
					Entities.Add(output);
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				throw new FileNotFoundException(fullpath);
			}
		}


	}
}
