using System;
using System.Diagnostics;
using System.IO;
using KCD.Kaitai;
//using KCD.Library.Tables;
//using Sharp.Reporting;

namespace KCD
{
	class Program
	{
		private static string Folder;
		//private static Database Vanilla;

		/// <summary>
		/// Loads "tbl" files from the given directory. If no directory is given, then
		/// my personal test directory is used, which likely only works on my machine.
		/// </summary>
		/// <param name="arguments">Provide a string directory to load tbl files from.</param>
		static void Main(string[] arguments)
		{
			Configure(arguments);
			Trace.WriteLine(string.Format("Using folder {0}.", Folder));

			string filepath = Path.Combine(Folder, "rpg", "game_over.tbl");
			Table table = Table.FromFile(filepath);
			Trace.WriteLine(string.Format("Kaitai Table:{0}\nDescriptor:{1}", filepath, table.Header.Descriptors.ToString()));

			//try
			//{
			//	Vanilla = new Database(Folder);
			//	Vanilla.Import();
			//}
			//catch (Exception exception)
			//{
			//	Trace.WriteLine(exception.GetReport());
			//}

			Trace.WriteLine("\nPress any key to terminate the program.");
			Console.ReadKey();
		}


		private static void Configure(string[] arguments)
		{
			if (arguments.Length == 0)
				Folder = @"..\..\..\..\KCD\Data\Libs\Tables";
			else
				Folder = arguments[0];
		}


	}
}
