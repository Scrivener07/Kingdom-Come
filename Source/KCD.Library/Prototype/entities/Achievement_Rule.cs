using System;
using System.IO;

namespace KCD.Library.Prototype
{
	//achievement_id(integer; 4 bytes)
	//statistic_id(integer; 4 bytes)
	//achievement_rule_name(text; 4 bytes)
	//threshold(real; 4 bytes)
	//achievement_rule_action_id(integer; 4 bytes)
	public class Achievement_Rule : Row
	{

		public Achievement_Rule(Table table) : base(table)
		{
			throw new NotImplementedException();
		}


		public Achievement_Rule(Table table, BinaryReader reader) : base(table, reader)
		{
			throw new NotImplementedException();
		}


		protected override Guid GetID()
		{
			throw new NotImplementedException();
		}

		protected override long GetSizeActual()
		{
			throw new NotImplementedException();
		}
	}
}