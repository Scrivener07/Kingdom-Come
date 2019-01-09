using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Linq;
using Kaitai;

namespace KCD.Kaitai.Tables
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


		///// <summary>
		///// Registers the given filename with the given System.Type.
		///// </summary>
		///// <param name="filename">The file name and extension to use. A path may also be passed in.</param>
		///// <param name="type">The system type to associate.</param>
		///// <returns>Returns true on success.</returns>
		//private static bool Register(string filename, Type type)
		//{
		//	filename = Path.GetFileName(filename);
		//	if (!Types.ContainsKey(filename))
		//	{
		//		Types.Add(filename, type);
		//		if (type == null)
		//		{
		//			Trace.WriteLine(string.Format("Registered the {0} key with no type.", filename, type));
		//		}
		//		else
		//		{
		//			Trace.WriteLine(string.Format("Registered the {0} key with the {1} type.", filename, type));
		//		}

		//		return true;
		//	}
		//	else
		//	{
		//		Trace.WriteLine(string.Format("Failed to register the {0} key with the {1} type.", filename, type));
		//		return false;
		//	}
		//}


		public static Type GetType(string key)
		{
			return Types[key];
		}





		public static bool Exists(string key)
		{
			return Types.ContainsKey(key);
		}






		// THIS IS SOME IDEA STUFF


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
			return Assembly.GetExecutingAssembly().GetTypes()
				.Where(variable => variable.IsSubclassOf(typeof(KaitaiStruct)));
		}


		public static string PathToKey(string path)
		{
			return Path.GetFileNameWithoutExtension(path)
				.ToLowerInvariant()
				.Replace("_", "");
		}



	}
}
