using System;
using System.ComponentModel;

namespace KCD.Library.Tables.Adapters
{
	public class RowCollectionPropertyDescriptor : PropertyDescriptor
	{
		private RowCollection Collection = null;
		private int index = -1;


		public RowCollectionPropertyDescriptor(RowCollection collection, int index) : base("#" + index.ToString(), null)
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
				Row row = Collection[index];
				return row.Count + " " + row.OwnerName;
			}
		}

		public override string Description
		{
			get
			{
				Row row = Collection[index];
				return string.Format("{0}, {1}, {2}, {3}", row.OwnerName, row.Count, row.OwnerKey, row.OwnerDatabase);
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
