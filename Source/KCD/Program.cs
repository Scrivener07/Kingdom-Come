using System;
using System.Diagnostics;
using KCD.Library.Tables;
using Sharp.Reporting;

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
			Configure(arguments);
			Trace.WriteLine(string.Format("Using folder `{0}`.", Folder));

			try
			{
				Vanilla = new Database(Folder);
				Vanilla.Import();
			}
			catch (Exception exception)
			{
				var report = exception.GetReport();
				Trace.WriteLine(report);
			}

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
