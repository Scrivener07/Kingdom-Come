﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using KCD.Library.Tables;
using KCD.Studio.Presentation;

namespace KCD.Studio
{
	static class Program
	{
		public static string Folder { get; private set; }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] arguments)
		{
			Configure(arguments);
			Trace.WriteLine(string.Format("Using folder {0}.", Folder));

			Definition.Initialize();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
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
