using System.IO;

namespace KingdomCome.Library.Tables.Format
{
	public abstract class DataBlock
	{
		protected readonly Table Self;

		public DataBlock(Table table)
		{
			Self = table;
		}

		public abstract long GetSize();
		public abstract bool Read(BinaryReader reader);
		public abstract bool Write(BinaryWriter writer);


		public override string ToString()
		{
			return string.Format("Block Size:{0}", GetSize());
		}

	}
}
