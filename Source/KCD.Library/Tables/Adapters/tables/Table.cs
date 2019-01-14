using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Kaitai;
using Sharp.ComponentModel;

namespace KCD.Library.Tables.Adapters
{
	[TypeConverter(typeof(TableConverter))]
	public class Table : ObjectComponent<Database>
	{
		/// <summary>
		/// The key used to lookup this table definition.
		/// </summary>
		public readonly string Key;


		/// <summary>
		/// The CLR system type for this table.
		/// </summary>
		public readonly Type CLR;


		/// <summary>
		/// The file system object for this table file.
		/// </summary>
		private readonly FileInfo Info;

		/// <summary>
		/// The full path of this table file.
		/// </summary>
		public string FilePath { get { return Info.FullName; } }

		/// <summary>
		/// The name of this table file.
		/// </summary>
		public string FileName { get { return Info.Name; } }


		/// <summary>
		/// This table's row collection.
		/// </summary>
		[TypeConverter(typeof(RowCollectionConverter))]
		public RowCollection Rows { get; private set; }

		/// <summary>
		/// The number of rows in this table.
		/// </summary>
		public int Count { get { return Rows.Count; } }


		/// <summary>
		/// The raw kaitai data structure for this table.
		/// </summary>
		public KaitaiStruct Raw { get; private set; }

		/// <summary>
		/// The file size of this table.
		/// </summary>
		public long FileSize { get { return Raw.M_Io.Size; } }


		/// <summary>
		/// Constructs a new table object.
		/// </summary>
		/// <param name="database">The database that owns this table.</param>
		/// <param name="fullpath">The file name of this table.</param>
		public Table(Database database, string fullpath) : base(database)
		{
			if (!File.Exists(fullpath))
			{
				throw new FileNotFoundException(string.Format("The file '{0}' does not exist. ", fullpath), fullpath);
			}
			else
			{
				Info = new FileInfo(fullpath);
				Rows = new RowCollection();

				Key = Definition.PathToKey(fullpath);
				if (Definition.Exists(Key) == false)
				{
					throw new InvalidOperationException(string.Format("The definition key {0} does not exist.", Key));
				}

				CLR = Definition.GetType(Key);
				if (CLR == null)
				{
					throw new InvalidOperationException(string.Format("The definition type object for the {0} key does not exist.", Key));
				}

				Raw = FromFile(fullpath);
				if (Raw == null)
				{
					throw new InvalidOperationException("The KaitaiStruct cannot be null.");
				}

				GetRows();
			}
		}


		/// <summary>
		/// Invokes the `FromFile` method on this table.
		/// </summary>
		/// <param name="filepath">The filepath to use.</param>
		/// <returns>Returns the KaitaiStruct object for this table.</returns>
		private KaitaiStruct FromFile(string filepath)
		{
			object[] arguments = new object[1];
			arguments[0] = filepath;
			return (KaitaiStruct)CLR.GetMethod("FromFile", BindingFlags.Public | BindingFlags.Static).Invoke(null, arguments);
		}


		/// <summary>
		/// Populates the row collection for this table.
		/// </summary>
		private void GetRows()
		{
			PropertyInfo property = CLR.GetProperty("Rows");
			var values = (IEnumerable<KaitaiStruct>)property.GetValue(Raw);
			foreach (var value in values)
			{
				Rows.Add(new Row(this, value));
			}
		}


		/// <summary>
		/// The string representation of this object.
		/// </summary>
		/// <returns>Returns a string which represents this object.</returns>
		public override string ToString()
		{
			return string.Format("{0}:{1} [{2} Bytes]", Owner.Name, FilePath, FileSize);
		}


	}
}
