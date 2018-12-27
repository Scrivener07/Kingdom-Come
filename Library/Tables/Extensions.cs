using System;
using System.IO;
using Sharp.Reporting;

namespace KingdomCome.Library.Tables
{
	public static class Extensions
	{

		/// <summary>
		/// Int32
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static int ReadTableInteger(this BinaryReader reader)
		{
			int value = 0;
			try
			{
				value = reader.ReadInt32();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// Int64
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static long ReadTableBigInteger(this BinaryReader reader)
		{
			long value = 0;
			try
			{
				value = reader.ReadInt64();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// Float
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static float ReadTableReal(this BinaryReader reader)
		{
			float value = 0.0f;
			try
			{
				value = (float)reader.ReadDouble();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// Guid
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static Guid ReadTableGuid(this BinaryReader reader)
		{
			byte[] bytes = new byte[0];
			try
			{
				bytes = reader.ReadBytes(16);
			}
			catch (ArgumentException exception)
			{
				Console.WriteLine(exception.GetReport());
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.GetReport());
			}
			return new Guid(bytes);
		}


		/// <summary>
		/// Bool
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static bool ReadTableBoolean(this BinaryReader reader)
		{
			bool value = false;
			try
			{
				value = reader.ReadBoolean();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.GetReport());
			}
			return value;
		}


		/// <summary>
		/// Strings are stored as 32-bit signed integers pointing into the string table.
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static int ReadTableText(this BinaryReader reader)
		{
			int value = 0;
			try
			{
				value = reader.ReadInt32();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.GetReport());
			}
			return value;
		}


	}
}
