using System;
using System.ComponentModel;
using System.Reflection;
using Sharp.ComponentModel;

namespace KCD.Library.Tables.Adapters
{
	[TypeConverter(typeof(ColumnConverter))]
	public class Column : ObjectComponent<Row>
	{
		public readonly PropertyInfo Raw;


		/// <summary>
		/// Constructs a new column object.
		/// </summary>
		/// <param name="row">The row that owns this column.</param>
		public Column(Row row, PropertyInfo raw) : base(row)
		{
			if (raw == null)
			{
				throw new ArgumentNullException("raw", "A column requires a PropertyInfo object which cannot be null.");
			}
			else
			{
				Raw = raw;
			}
		}


		/// <summary>
		/// The string representation of this object.
		/// </summary>
		/// <returns>Returns a string which represents this object.</returns>
		public override string ToString()
		{
			return string.Format("Column");
		}


	}
}
