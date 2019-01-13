using System;
using System.ComponentModel;
using System.Globalization;

namespace KCD.Library.Tables.Adapters
{
	internal class RowConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type type)
		{
			if (type == typeof(string) && value is Row)
			{
				Row row = (Row)value;
				return row.OwnerKey + ", " + row.OwnerDatabase;
			}
			return base.ConvertTo(context, culture, value, type);
		}
	}


	internal class RowCollectionConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type type)
		{
			if (type == typeof(string) && value is RowCollection)
			{
				return "The Table's row data";
			}
			return base.ConvertTo(context, culture, value, type);
		}
	}
}
