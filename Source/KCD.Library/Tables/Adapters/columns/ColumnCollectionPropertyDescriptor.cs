using System;
using System.ComponentModel;

namespace KCD.Library.Tables.Adapters
{
	public class ColumnCollectionPropertyDescriptor : PropertyDescriptor
	{
		private ColumnCollection Collection = null;
		private int index = -1;


		public ColumnCollectionPropertyDescriptor(ColumnCollection collection, int index) : base("#" + index.ToString(), null)
		{
			Collection = collection;
			this.index = index;
		}

		public override AttributeCollection Attributes { get { return new AttributeCollection(null); } }

		public override bool CanResetValue(object component) { return true; }

		public override Type ComponentType { get { return Collection.GetType(); } }

		public override string DisplayName
		{
			get
			{
				Column column = Collection[index];
				return column.ToString();
			}
		}

		public override string Description
		{
			get
			{
				Column column = Collection[index];
				return string.Format("This is a column.");
			}
		}

		public override object GetValue(object component)
		{
			return Collection[index];
		}

		public override bool IsReadOnly
		{
			get { return false; }
		}

		public override string Name
		{
			get { return "#" + index.ToString(); }
		}

		public override Type PropertyType
		{
			get { return Collection[index].GetType(); }
		}

		public override void ResetValue(object component)
		{
		}

		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}

		public override void SetValue(object component, object value)
		{
			// Collection[index] = value;
		}


	}
}
