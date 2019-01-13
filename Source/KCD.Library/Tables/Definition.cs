using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Linq;
using Kaitai;

namespace KCD.Library.Tables
{
	/// <summary>
	/// Provides static information about table entities.
	/// </summary>
	public static class Definition
	{
		public static bool Initialized { get; private set; }
		public static int Count { get { return Types.Count; } }
		private static Dictionary<string, Type> Types { get; set; }


		static Definition()
		{
			Types = new Dictionary<string, Type>();
		}


		public static void Initialize()
		{
			if (Initialized) return; else Initialized = true;
			Types = New();
			Trace.WriteLine("Initialized with " + Count + " definitions.");
		}


		public static Type GetType(string key)
		{
			return Types[key];
		}


		public static bool Exists(string key)
		{
			return Types.ContainsKey(key);
		}


		private static Dictionary<string, Type> New()
		{
			var dictionary = new Dictionary<string, Type>();
			try
			{
				foreach (Type type in GetTypes())
				{
					string key = type.Name.ToLowerInvariant();
					if (!dictionary.ContainsKey(key))
					{
						dictionary.Add(key, type);
						Trace.WriteLine("Adding " + key);
					}
					else
					{
						Trace.WriteLine("Dictionary already contains the key. " + key);
					}
				}
			}
			catch (Exception exception)
			{
				throw exception; // TODO: Im only throwing like this for a breakpoint.
			}


			return dictionary;
		}


		private static IEnumerable<Type> GetTypes()
		{
			return Assembly.GetAssembly(typeof(Kaitai)).GetTypes()
				.Where(variable => variable.IsSubclassOf(typeof(KaitaiStruct)) && !variable.IsNested);
		}


		public static string PathToKey(string path)
		{
			return Path.GetFileNameWithoutExtension(path)
				.ToLowerInvariant()
				.Replace("_", "");
		}


	}
}
