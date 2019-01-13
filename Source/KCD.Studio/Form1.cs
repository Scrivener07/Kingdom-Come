using System;
using System.Windows.Forms;
using KCD.Library.Tables;

namespace KCD.Studio
{
	public partial class Form1 : Form
	{
		private Database Vanilla;


		public Form1()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			Vanilla = new Database(Program.Folder, "Vanilla");
			Vanilla.Import();

			propertyGrid1.SelectedObject = Vanilla;
		}


	}
}
