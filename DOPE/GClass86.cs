using System;
using System.Collections.Generic;

public class GClass86
{
	public static bool smethod_0(Type type_0, out int int_0)
	{
		int_0 = 0;
		GInterface0 ginterface = GClass85.smethod_0(type_0) as GInterface0;
		if (ginterface != null)
		{
			int_0 = (int)ginterface.Id;
			return true;
		}
		return false;
	}

	static GClass86()
	{
		Class13.NP5bWyNzLwONS();
		GClass86.dictionary_0 = new Dictionary<int, Type>();
		foreach (Type type in typeof(GClass86).Assembly.GetTypes())
		{
			if (typeof(GInterface0).IsAssignableFrom(type))
			{
				GInterface0 ginterface = GClass85.smethod_0(type) as GInterface0;
				if (ginterface != null)
				{
					GClass86.dictionary_0[(int)ginterface.Id] = type;
				}
			}
		}
	}

	public static GInterface0 smethod_1(uint uint_0)
	{
		return GClass86.smethod_2((int)uint_0);
	}

	public static GInterface0 smethod_2(int int_0)
	{
		Type type_;
		if (!GClass86.dictionary_0.TryGetValue(int_0, out type_))
		{
			return null;
		}
		return (GInterface0)GClass85.smethod_0(type_);
	}

	public GClass86()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	public static readonly Dictionary<int, Type> dictionary_0;
}
