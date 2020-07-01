using System;
using System.Collections.Generic;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;

public class GClass94 : GInterface4
{
	public void Run(GClass136 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		int num = hero.CargoCapacity;
		HashSet<int> hashSet = new HashSet<int>();
		foreach (GClass135 gclass in e.vector_0)
		{
			hashSet.Add(gclass.gclass259_0.int_0);
			ResourceType int_ = (ResourceType)gclass.gclass259_0.int_0;
			if (int_ != ResourceType.XENOMIT)
			{
				num -= (int)gclass.Count;
			}
			hero.method_24("resource_" + int_.ToString().ToLower(), gclass.Count);
		}
		for (int i = 0; i <= 8; i++)
		{
			ResourceType resourceType = (ResourceType)i;
			if (!hashSet.Contains(i))
			{
				hero.method_24("resource_" + resourceType.ToString().ToLower(), 0.0);
			}
		}
		hero.FreeCargo = num;
	}

	public GClass94()
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
	}
}
