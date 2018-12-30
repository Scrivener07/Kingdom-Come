using System.IO;

namespace KCD.Library.Tables.Format
{
	public abstract class Block
	{
		/// <summary>
		/// The table that owns this block.
		/// </summary>
		protected readonly Table Self;


		/// <summary>
		/// Gets the size of this block in bytes.
		/// </summary>
		public long Size { get { return GetSize(); } }


		/// <summary>
		/// Creates a new file block for this table.
		/// </summary>
		/// <param name="table">The table which owns this block.</param>
		public Block(Table table)
		{
			Self = table;
		}


		/// <summary>
		/// Gets the size of this block in bits.
		/// </summary>
		/// <returns>Returns the size of this block in bits.</returns>
		protected abstract long GetSize();


		/// <summary>
		/// Reads from the table file.
		/// </summary>
		/// <param name="reader">The binary reader to use.</param>
		/// <returns>Returns true on success.</returns>
		public abstract bool Read(BinaryReader reader);


		/// <summary>
		/// Writes to the table file.
		/// </summary>
		/// <param name="writer">The binary writer to use.</param>
		/// <returns>Returns true on success.</returns>
		public abstract bool Write(BinaryWriter writer);


		/// <summary>
		/// The string representation of this object.
		/// </summary>
		/// <returns>Returns a string which represents this object.</returns>
		public override string ToString()
		{
			return string.Format("Block Size:{0}", Size);
		}


	}
}
