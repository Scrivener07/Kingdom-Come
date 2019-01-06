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

			//string tableFilepath = Path.Combine(Folder, "rpg", "game_over.tbl");
			//Table table = Table.FromFile(tableFilepath);
			//Trace.WriteLine(string.Format("Kaitai Table:{0}\nDescriptor:{1}", tableFilepath, table.Header.Descriptors.ToString()));

			string perkFilepath = Path.Combine(Folder, "rpg", "perk.tbl");
			Perk perk = Perk.FromFile(perkFilepath);
			Trace.WriteLine(string.Format("Perk:{0}\nDescriptor:{1}", perkFilepath, perk.Table.DescriptorsHash.ToString()));


			string gameOverFilepath = Path.Combine(Folder, "rpg", "game_over.tbl");
			GameOver gameOver = GameOver.FromFile(gameOverFilepath);
			Trace.WriteLine(string.Format("GameOver:{0}\nDescriptor:{1}", gameOverFilepath, gameOver.Table.DescriptorsHash.ToString()));




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
