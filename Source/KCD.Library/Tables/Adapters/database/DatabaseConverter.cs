using System;
using System.ComponentModel;
using System.Globalization;

namespace KCD.Library.Tables.Adapters
{
	internal class DatabaseConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type type)
		{
			if (type == typeof(string) && value is Database)
			{
				var database = (Database)value;
				return string.Format("Database: {0}", database.Name);
			}
			return base.ConvertTo(context, culture, value, type);
		}
	}
}
