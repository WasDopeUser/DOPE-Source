using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DOPE.Common.Models;

namespace PErkava
{
	public static class PErkava
	{
		public static bool IsSupported { get; set; }

		public static GClass933 Host { get; set; }

		[CompilerGenerated]
		public static ConcurrentDictionary<int, IPErkavaBotController> smethod_0()
		{
			return PErkava.concurrentDictionary_1;
		}

		[CompilerGenerated]
		public static void smethod_1(ConcurrentDictionary<int, IPErkavaBotController> concurrentDictionary_5)
		{
			PErkava.concurrentDictionary_1 = concurrentDictionary_5;
		}

		public static List<GClass937> AllServersData { get; private set; }

		public static bool smethod_2()
		{
			return PErkava.Proxy is GClass934;
		}

		public static void smethod_3()
		{
			if (PErkava.bool_0)
			{
				if (PErkava.Proxy == null)
				{
					PErkava.Proxy = new GClass936();
					if (!PErkava.Proxy.imethod_1())
					{
						PErkava.Proxy = new GClass934();
					}
					if (!PErkava.Proxy.imethod_1())
					{
						throw new Exception();
					}
				}
				PErkava.Proxy.EMJCLLSWGGV(null);
			}
		}

		static PErkava()
		{
			Class13.lOBHd9Nzn7x2T();
			PErkava.IsSupported = false;
			PErkava.concurrentDictionary_0 = new ConcurrentDictionary<IntPtr, GClass932>();
			PErkava.concurrentDictionary_1 = new ConcurrentDictionary<int, IPErkavaBotController>();
			PErkava.hashSet_0 = new HashSet<uint>();
			PErkava.concurrentDictionary_2 = new ConcurrentDictionary<IntPtr, bool>();
			PErkava.string_0 = new string[]
			{
				"asia1",
				"br1",
				"br2",
				"cz1",
				"cz2",
				"cz3",
				"de1",
				"de2",
				"de3",
				"de4",
				"de5",
				"de6",
				"de7",
				"es1",
				"es2",
				"es3",
				"es4",
				"fr1",
				"fr2",
				"fr3",
				"fr4",
				"int1",
				"int2",
				"int3",
				"int4",
				"int5",
				"int6",
				"int7",
				"int8",
				"int9",
				"int10",
				"int11",
				"int12",
				"int13",
				"int14",
				"int15",
				"it1",
				"it2",
				"it3",
				"mx1",
				"pl1",
				"pl2",
				"pl3",
				"ru1",
				"ru2",
				"ru3",
				"ru4",
				"ru5",
				"ru6",
				"tr1",
				"tr2",
				"tr3",
				"tr4",
				"tr5",
				"tr6",
				"us1",
				"us2",
				"us3",
				"us4",
				"gb1",
				"gb2"
			};
			PErkava.concurrentDictionary_3 = new ConcurrentDictionary<string, GClass937>();
			PErkava.concurrentDictionary_4 = new ConcurrentDictionary<string, HashSet<GClass937>>();
			PErkava.AllServersData = PErkava.string_0.Select(new Func<string, GClass937>(PErkava.<>c.<>c_0.method_0)).ToList<GClass937>();
		}

		public static string[] smethod_4()
		{
			return PErkava.string_0;
		}

		public static void smethod_5(GClass937 gclass937_0)
		{
			List<string> list = new List<string>();
			foreach (string text in gclass937_0.Servers)
			{
				HashSet<GClass937> hashSet = null;
				if (!PErkava.concurrentDictionary_4.TryGetValue(text, out hashSet))
				{
					hashSet = (PErkava.concurrentDictionary_4[text] = new HashSet<GClass937>());
				}
				if (hashSet.Count == 0)
				{
					list.Add(text);
				}
				hashSet.Add(gclass937_0);
			}
			PErkava.Proxy.imethod_0(list.ToArray());
		}

		public static void smethod_6(GClass937 gclass937_0)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string text in gclass937_0.Servers)
			{
				HashSet<GClass937> hashSet2 = null;
				if (!PErkava.concurrentDictionary_4.TryGetValue(text, out hashSet2))
				{
					hashSet2 = (PErkava.concurrentDictionary_4[text] = new HashSet<GClass937>());
				}
				hashSet2.Remove(gclass937_0);
				if (hashSet2.Count == 0)
				{
					hashSet.Add(text);
				}
			}
			PErkava.Proxy.EMJCLLSWGGV(hashSet);
		}

		[CompilerGenerated]
		private static bool bool_0;

		public static readonly ConcurrentDictionary<IntPtr, GClass932> concurrentDictionary_0;

		[CompilerGenerated]
		private static GClass933 gclass933_0;

		[CompilerGenerated]
		private static ConcurrentDictionary<int, IPErkavaBotController> concurrentDictionary_1;

		public static readonly HashSet<uint> hashSet_0;

		public static ConcurrentDictionary<IntPtr, bool> concurrentDictionary_2;

		public static readonly string[] string_0;

		[CompilerGenerated]
		private static List<GClass937> list_0;

		public static ConcurrentDictionary<string, GClass937> concurrentDictionary_3;

		public static ConcurrentDictionary<string, HashSet<GClass937>> concurrentDictionary_4;

		private static Interface0 Proxy;
	}
}
