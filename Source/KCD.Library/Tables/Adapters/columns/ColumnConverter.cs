using System;
using System.ComponentModel;
using System.Globalization;

namespace KCD.Library.Tables.Adapters
{
	internal class ColumnConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type type)
		{
			if (type == typeof(string) && value is Column)
			{
				Column column = (Column)value;
				return string.Format("Contains ? entries.");
			}
			return base.ConvertTo(context, culture, value, type);
		}
	}


	internal class ColumnCollectionConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type type)
		{
			if (type == typeof(string) && value is ColumnCollection)
			{
				return "Row's column data";
			}
			return base.ConvertTo(context, culture, value, type);
		}
	}
}
