using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using Sharp.Reporting;

namespace KCD.Library.Tables
{
	public static class Definition
	{
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
		public const uint POI_Type = 0x5ba68aa5;
		public const uint POI_Type2Perk = 0x2fe2a608;
		public const uint Race = 0xc063cd1a;
		public const uint Random_Event = 0xc80f132c;
		public const uint Random_Event_Option = 0xae0f3ae6;
		public const uint Random_Event_Option_Set = 0xa44f3f0;
		public const uint Random_Event_Source_Type = 0x5f259326;
		#endregion

		#region Dictionary

		public static int Count { get { return Types.Count; } }
		private static Dictionary<uint, Type> Types { get; set; }

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
			Register(POI_Type, typeof(POI_Type));
			Register(POI_Type2Perk, typeof(POI_Type2Perk));
			Register(Race, typeof(Race));
			Register(Random_Event, typeof(Random_Event));
			Register(Random_Event_Option, typeof(Random_Event_Option));
			Register(Random_Event_Option_Set, typeof(Random_Event_Option_Set));
			Register(Random_Event_Source_Type, typeof(Random_Event_Source_Type));
			Trace.WriteLine("Initialized with " + Count + " definitions.");
		}


		/// <summary>
		/// Adds the given type & descriptor pair to the dictionary.
		/// </summary>
		/// <param name="key">The table descriptor hash to use.</param>
		/// <param name="type">The object type to use.</param>
		/// <returns></returns>
		private static bool Register(uint key, Type type)
		{
			if (!Types.ContainsKey(key))
			{
				Types.Add(key, type);
				if (type == null)
				{ // TODO: I will allow null types for now, but print a warning.
					Trace.WriteLine(string.Format("Registered the {0} key with no type.", key, type));
				}
				else
				{
					Trace.WriteLine(string.Format("Registered the {0} key with the {1} type.", key, type));
				}

				return true;
			}
			else
			{
				Trace.WriteLine(string.Format("Failed to register the {0} key with the {1} type.", key, type));
				return false;
			}
		}


		/// <summary>
		/// Gets a type using its descriptor hash.
		/// </summary>
		/// <param name="key">The table descriptor hash to use.</param>
		/// <returns></returns>
		public static Type GetType(uint key)
		{
			return Types[key];
		}


		/// <summary>
		/// Returns true is the definition key is within the dictionary.
		/// </summary>
		/// <param name="key">The table descriptor hash to use.</param>
		/// <returns></returns>
		public static bool Exists(uint key)
		{
			return Types.ContainsKey(key);
		}
		#endregion

		#region Binary Reader

		/// <summary>
		/// An Int has a 32 bit width in TBL files.
		/// This is called "integer" within the XML files.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static int ReadTableInteger(this BinaryReader reader)
		{
			int value = 0;
			try
			{
				value = reader.ReadInt32();
			}
			catch (Exception exception)
			{
				Trace.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// An Int64 has a 64 bit width in TBL files.
		/// This is called "bigint" within the XML files.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static long ReadTableBigInteger(this BinaryReader reader)
		{
			long value = 0;
			try
			{
				value = reader.ReadInt64();
			}
			catch (Exception exception)
			{
				Trace.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// A Float has a 32 bit width in TBL files.
		/// This is called "real" within the XML files.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static float ReadTableReal(this BinaryReader reader)
		{
			float value = 0.0f;
			try
			{
				value = reader.ReadSingle();
			}
			catch (Exception exception)
			{
				Trace.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// A Guid has a 128 bit width in TBL files.
		/// This is called "uuid" within the XML files.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static Guid ReadTableGuid(this BinaryReader reader)
		{
			byte[] bytes = new byte[0];
			try
			{
				bytes = reader.ReadBytes(16);
			}
			catch (ArgumentException exception)
			{
				Trace.WriteLine(exception.GetReport());
			}
			catch (Exception exception)
			{
				Trace.WriteLine(exception.GetReport());
			}
			return new Guid(bytes);
		}


		/// <summary>
		/// A Bool has an 8 bit width in TBL files.
		/// This is called "boolean" within the XML files.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static bool ReadTableBoolean(this BinaryReader reader)
		{
			bool value = false;
			try
			{
				value = reader.ReadBoolean();
			}
			catch (Exception exception)
			{
				Trace.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// A "String" has a 32 bit width in TBL files.
		/// This is called "text" or "character varying" within the XML files.
		/// Strings are stored as 32-bit signed integers pointing into the string table.
		/// A string is "prefixed with the length, and encoded as an integer, seven bits at a time.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static int ReadTableText(this BinaryReader reader)
		{// TODO: Implement reader for String.
			int value = 0;
			try
			{
				value = reader.ReadInt32();
			}
			catch (Exception exception)
			{
				Trace.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// A Vec3 has [96 bit(3 * 32 bit)] width in TBL files.
		/// This is called "boolean" within the XML files.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static Vector3 ReadTableVector3(this BinaryReader reader)
		{// TODO: Implement reader for Vector3.
			throw new NotImplementedException();
		}


		/// <summary>
		/// A Quat has [128 bit(4 * 32 bit)] width in TBL files.
		/// This is called "quat" within the XML files.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static Quaternion ReadTableQuaternion(this BinaryReader reader)
		{// TODO: Implement reader for Quaternion.
			throw new NotImplementedException();
		}


		/// <summary>
		/// A QuatT has [224 bit((4 + 3) * 32 bit)] width in TBL files.
		/// This is called "quatt" within the XML files.
		/// </summary>
		/// <param name="reader">The binary reader responsible for reading a TBL file.</param>
		/// <returns>The value read in by the binary reader.</returns>
		public static Quaternion ReadTableQuaternionT(this BinaryReader reader)
		{// TODO: Implement reader for QuatT. This is possibly "Quaternion Transform"?
			throw new NotImplementedException();
		}

		#endregion

	}
}
