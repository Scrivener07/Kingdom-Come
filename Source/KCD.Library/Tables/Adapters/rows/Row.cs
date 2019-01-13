using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using Kaitai;

namespace KCD.Library.Tables.Adapters
{
	[TypeConverter(typeof(RowConverter))]
	public class Row
	{
		/// <summary>
		/// The table which owns this row.
		/// </summary>
		private readonly Table Owner;

		/// <summary>
		/// The Kaitai row object.
		/// </summary>
		public readonly KaitaiStruct Raw;


		/// <summary>
		/// The column properties of this row.
		/// </summary>
		public List<PropertyInfo> Columns { get; set; }


		// TODO: The following properties are temporary. This was a lazy shortcut to hookup type converters.

		[Category("Column")]
		public int Count { get { return Columns.Count; } }

		[Category("Column")]
		public string OwnerName { get { return Owner.FileName; } }

		[Category("Column")]
		public string OwnerKey { get { return Owner.Key; } }

		[Category("Column")]
		public string OwnerDatabase { get { return Owner.Owner.Name; } }


		public Row(Table table, KaitaiStruct raw)
		{
			if (table == null)
			{
				throw new ArgumentNullException("table", "A row requires an owning table which cannot be null.");
			}
			else if (raw == null)
			{
				throw new ArgumentNullException("raw", "A row requires a Kaitai structure which cannot be null.");
			}
			else
			{
				Owner = table;
				Raw = raw;
				Columns = new List<PropertyInfo>();
				GetColumns();
			}
		}


		private void GetColumns()
		{
			Type type = Raw.GetType();
			var properties = type.GetProperties();
			Columns.Clear();
			foreach (var property in properties)
			{
				if
				( // Skip Kaitai properties.
					!string.Equals(property.Name, "M_Root", StringComparison.InvariantCultureIgnoreCase) &&
					!string.Equals(property.Name, "M_Parent", StringComparison.InvariantCultureIgnoreCase) &&
					!string.Equals(property.Name, "M_Io", StringComparison.InvariantCultureIgnoreCase)
				)
				{
					var value = property.GetValue(Raw);
					Columns.Add(property);
					Trace.WriteLine(string.Format("{1}:{0}={2}", property.Name, property.PropertyType.Name, value));
				}
				else
				{
					Trace.WriteLine(string.Format("Skipped {1}:{0}", property.Name, property.PropertyType.Name));
				}
			}
		}


		/// <summary>
		/// The string representation of this object.
		/// </summary>
		/// <returns>Returns a string which represents this object.</returns>
		public override string ToString()
		{
			return string.Format("{0}, {1}, {2}, {3}", OwnerName, Count, OwnerKey, OwnerDatabase);
		}


	}
}
