using System;
using System.ComponentModel;
using System.Globalization;

namespace KCD.Library.Tables.Adapters
{
	internal class TableConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type type)
		{
			if (type == typeof(string) && value is Table)
			{
				Table table = (Table)value;
				return table.Key + ", " + table.Count;
			}
			return base.ConvertTo(context, culture, value, type);
		}
	}


	internal class TableCollectionConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type type)
		{
			if (type == typeof(string) && value is TableCollection)
			{
				return "Database's table data";
			}
			return base.ConvertTo(context, culture, value, type);
		}
	}
}
