using System;
using System.IO;

namespace KingdomCome.Library.Tables
{
	public abstract class Entity
	{
		protected readonly Table Owner;

		public Entity(Table table)
		{
			Owner = table ?? throw new ArgumentNullException("table", "The table cannot be null.");
		}

		public Entity(Table table, BinaryReader reader)
		{
			Owner = table ?? throw new ArgumentNullException("table", "The table cannot be null.");
			if (reader.BaseStream.Position != 28)
			{
				throw new ArgumentException("The reader postion must be 28 but is equal to " + reader.BaseStream.Position + ".");
			}
		}

		public override string ToString()
		{
			return Owner.Key + "::" + GetType().Name;
		}

	}
}
