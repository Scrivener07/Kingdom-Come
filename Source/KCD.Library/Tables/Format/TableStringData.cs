using System;
using System.IO;
using Sharp.Reporting;

namespace KCD.Library.Tables.Format
{
	public class TableStringData : DataBlock
	{
		public int Data { get; private set; }


		public TableStringData(Table table) : base(table)
		{
			Data = 0;
		}


		#region DataBlock

		public override long GetSize()
		{
			return Self.Header.StringDataSize;
		}


		public override bool Read(BinaryReader reader)
		{
			bool success = true;
			try
			{
				//Data = reader.ReadInt32();
			}
			catch (Exception exception)
			{
				success = false;
				Console.WriteLine(exception.GetReport());
			}
			return success;
		}


		public override bool Write(BinaryWriter writer)
		{
			throw new NotImplementedException();
		}

		#endregion

	}
}
