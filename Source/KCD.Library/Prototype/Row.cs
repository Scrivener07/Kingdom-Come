using System;
using System.IO;

namespace KCD.Library.Prototype
{
	/// <summary>
	/// An abstract representation of a table row.
	/// </summary>
	public abstract class Row
	{
		/// <summary>
		/// The table which owns this row.
		/// </summary>
		protected readonly Table Owner;


		/// <summary>
		/// The identifier for this row object.
		/// </summary>
		public Guid ID { get { return GetID(); } }


		/// <summary>
		/// The actual size of this row as bytes, without any padding.
		/// </summary>
		public long SizeActual { get { return GetSizeActual(); } }


		/// <summary>
		/// The total amount of padding as bytes.
		/// </summary>
		public long SizePadding { get { return (Owner.Row.RowSize * Owner.Header.RowCount) - SizeActual; } }


		/// <summary>
		/// Creates a new row in the given table.
		/// </summary>
		/// <param name="table">The table to use.</param>
		public Row(Table table)
		{
			Owner = table ?? throw new ArgumentNullException("table", "The table cannot be null.");
		}


		/// <summary>
		/// Creates a new row in the given table, from the given binary stream.
		/// </summary>
		/// <param name="table">The table to use.</param>
		/// <param name="reader">The binary reader to use.</param>
		public Row(Table table, BinaryReader reader)
		{
			Owner = table ?? throw new ArgumentNullException("table", "The table cannot be null.");
			if (reader.BaseStream.Position < Owner.Header.Size)
			{
				throw new ArgumentException(string.Format("The reader postion cannot be less than {0} but equals {1}.", Owner.Header.Size, reader.BaseStream.Position));
			}
			if (reader.BaseStream.Position > Owner.Header.Size + Owner.Row.Size)
			{
				throw new ArgumentException(string.Format("The reader postion cannot be greater than {0} but equals {1}.", Owner.Header.Size, reader.BaseStream.Position));
			}
		}


		/// <summary>
		/// The identifier for this row object.
		/// </summary>
		/// <returns>Returns the identifier for this row object.</returns>
		protected abstract Guid GetID();


		/// <summary>
		/// The actual size of this row without any padding.
		/// </summary>
		/// <returns>The actual size in bytes.</returns>
		protected abstract long GetSizeActual();


		/// <summary>
		/// The string representation of this object.
		/// </summary>
		/// <returns>Returns a string which represents this object.</returns>
		public override string ToString()
		{
			return string.Format("ID:{0} [Type:{1}::{2}]", ID, GetType().Name, Owner.Key);
		}


	}
}
