using System;
using System.Windows.Forms;
using KCD.Library;

namespace KCD.Studio.Presentation
{
	public partial class MainForm : Form
	{
		private DataContext context;


		public MainForm()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			context = new DataContext(Program.Folder);
			propertyGrid1.SelectedObject = context;
		}


	}
}
