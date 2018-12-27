using System;
using System.Collections.Generic;

namespace KingdomCome.Library.Tables
{
	public static class Definition
	{
		public static int Count { get { return Types.Count; } }
		private static Dictionary<uint, Type> Types { get; set; }

		#region Descriptors
		public const uint Achievement = 0xD5544673;
		public const uint Achievement_Rule = 0xCCF4602F;
		public const uint Character_Beard = 0x2c030c0e;
		public const uint Character_Body = 0xfa1c4402;
		public const uint Character_Hair = 0x7956b57e;
		public const uint Character_Head = 0x5c836cac;
		public const uint DLC = 0xdb96e796;
		public const uint Editor_Object = 0x8ae3114e;
		public const uint Editor_Object_Binding = 0xf5f64b06;
		public const uint Faction = 0xd1b6bf5f;
		public const uint Game_Mode = 0xB24CF8DF;
		public const uint Perk = 0x391674DE;
		public const uint Race = 0xc063cd1a;
		public const uint Random_Event = 0xc80f132c;
		public const uint Random_Event_Option = 0xae0f3ae6;
		public const uint Random_Event_Option_Set = 0xa44f3f0;
		public const uint Random_Event_Source_Type = 0x5f259326;
		#endregion


		static Definition()
		{
			Types = new Dictionary<uint, Type>();
		}


		/// <summary>
		/// Inititalizes all known table type definitions.
		/// </summary>
		public static void Initialize()
		{
			Register(Achievement, typeof(Achievement));
			Register(Achievement_Rule, typeof(Achievement_Rule));
			Register(Character_Beard, typeof(Character_Beard));
			Register(Character_Body, typeof(Character_Body));
			Register(Character_Hair, typeof(Character_Hair));
			Register(Character_Head, typeof(Character_Head));
			Register(DLC, typeof(DLC));
			Register(Editor_Object, typeof(Editor_Object));
			Register(Editor_Object_Binding, typeof(Editor_Object_Binding));
			Register(Faction, typeof(Faction));
			Register(Game_Mode, typeof(Game_Mode));
			Register(Perk, typeof(Perk));
			Register(Race, typeof(Race));
			Register(Random_Event, typeof(Random_Event));
			Register(Random_Event_Option, typeof(Random_Event_Option));
			Register(Random_Event_Option_Set, typeof(Random_Event_Option_Set));
			Register(Random_Event_Source_Type, typeof(Random_Event_Source_Type));
			Console.WriteLine("Initialized with " + Count + " definitions.");
		}


		/// <summary>
		/// Adds the given type to the dictionary.
		/// </summary>
		/// <param name="key">The table descriptor hash.</param>
		/// <param name="type">The CLR object type.</param>
		/// <returns></returns>
		private static bool Register(uint key, Type type)
		{
			if (!Types.ContainsKey(key))
			{
				Types.Add(key, type);
				if (type == null)
				{ // TODO: I will allow null types for now, but print a warning.
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine(string.Format("Registered the {0} key with no type.", key, type));
					Console.ResetColor();
				}
				else
				{
					Console.WriteLine(string.Format("Registered the {0} key with the {1} type.", key, type));
				}

				return true;
			}
			else
			{
				Console.WriteLine(string.Format("Failed to register the {0} key with the {1} type.", key, type));
				return false;
			}
		}


		public static Type GetType(uint key)
		{
			return Types[key];
		}


		/// <summary>
		/// Returns true is the definition key is within the dictionary.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static bool Exists(uint key)
		{
			return Types.ContainsKey(key);
		}


	}
}
