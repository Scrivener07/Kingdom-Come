using System;
using System.Windows.Forms;
using Kaitai;
using KCD.Kaitai.Tables;

namespace KCD.Studio
{
	public partial class Form1 : Form
	{
		private static Database Vanilla;

		public Form1()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			Vanilla = new Database(Program.Folder);
			Vanilla.Import();

			//KaitaiStruct[] array = new KaitaiStruct[Vanilla.Entities.Count];
			//Vanilla.Entities.CopyTo(array, 0);
			//propertyGrid1.SelectedObjects = array;

			var table = (CharacterBeard)Vanilla.Entities[0];
			var row = table.Rows[0];
			propertyGrid1.SelectedObject = row;
		}


	}
}
