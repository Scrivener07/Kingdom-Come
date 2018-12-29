using System;
using KCD.Library.Tables;
using Sharp.Reporting;

// TODO: Write output to file.

namespace KCD
{
	class Program
	{
		private static string Folder;
		private static Database Vanilla;

		/// <summary>
		/// Loads "tbl" files from the given directory. If no directory is given, then
		/// my personal test directory is used, which likely only works on my machine.
		/// </summary>
		/// <param name="arguments">Provide a string directory to load tbl files from.</param>
		static void Main(string[] arguments)
		{
			if (arguments.Length == 0)
			{
				Folder = @"E:\Studio\KCD\Data\Libs\Tables";
			}
			else
			{
				Folder = arguments[0];
			}

			try
			{
				Vanilla = new Database(Folder);
				Vanilla.Import();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.GetReport());
			}

			Console.WriteLine("\nPress any key to terminate the program.");
			Console.ReadKey();
		}


	}
}
