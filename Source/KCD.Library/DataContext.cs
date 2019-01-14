using System.ComponentModel;
using KCD.Library.Tables;
using KCD.Library.Tables.Adapters;

namespace KCD.Library
{
	public class DataContext
	{
		[Category("Context")]
		[Description("A database is a collection of tables from the same directory.")]
		[TypeConverter(typeof(DatabaseConverter))]
		public Database Vanilla { get; private set; }


		public DataContext(string folder)
		{
			Vanilla = new Database(this, folder, "Vanilla");
			Vanilla.Import();
		}


	}
}
