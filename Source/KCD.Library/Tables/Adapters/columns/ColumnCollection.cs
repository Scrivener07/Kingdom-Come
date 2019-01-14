using System;
using System.Collections;
using System.ComponentModel;

namespace KCD.Library.Tables.Adapters
{
	/// <summary>
	/// Type safe collection class for Column objects provides a customized type description.
	/// </summary>
	public class ColumnCollection : CollectionBase, ICustomTypeDescriptor
	{
		/// <summary>
		/// Adds a column object to the collection
		/// </summary>
		/// <param name="value"></param>
		public void Add(Column value)
		{
			List.Add(value);
		}

		/// <summary>
		/// Removes a column object from the collection
		/// </summary>
		/// <param name="value"></param>
		public void Remove(Column value)
		{
			List.Remove(value);
		}

		/// <summary>
		/// Returns a column object at index position.
		/// </summary>
		public Column this[int index] { get { return (Column)List[index]; } }


		#region ICustomTypeDescriptor

		public string GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		public string GetComponentName()
		{
			return TypeDescriptor.GetComponentName(this, true);
		}

		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		public EventDescriptor GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		public PropertyDescriptor GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		public object GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		public object GetPropertyOwner(PropertyDescriptor value)
		{
			return this;
		}


		/// <summary>
		/// Called to get the properties of this type. Returns properties with certain attributes.
		/// </summary>
		/// <param name="attributes"></param>
		/// <returns></returns>
		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return GetProperties();
		}


		/// <summary>
		/// Called to get the properties of this type.
		/// </summary>
		/// <returns></returns>
		public PropertyDescriptorCollection GetProperties()
		{
			// Create a collection object to hold property descriptors.
			PropertyDescriptorCollection values = new PropertyDescriptorCollection(null);

			// Iterate the list of columns.
			for (int index = 0; index < List.Count; index++)
			{
				// Create a property descriptor for the column item and add to the property descriptor collection.
				ColumnCollectionPropertyDescriptor value = new ColumnCollectionPropertyDescriptor(this, index);
				values.Add(value);
			}
			return values;
		}

		#endregion

	}
}
