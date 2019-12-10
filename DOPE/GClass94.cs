using System;
using System.Collections.Generic;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;

public class GClass94 : GInterface4
{
	public void Run(GClass132 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		int num = hero.CargoCapacity;
		HashSet<int> hashSet = new HashSet<int>();
		foreach (GClass131 gclass in e.vector_0)
		{
			hashSet.Add((int)gclass.gclass247_0.uint_0);
			ResourceType uint_ = (ResourceType)gclass.gclass247_0.uint_0;
			if (uint_ != ResourceType.XENOMIT)
			{
				num -= (int)gclass.Count;
			}
			hero.method_23("resource_" + uint_.ToString().ToLower(), gclass.Count);
		}
		for (int i = 0; i <= 8; i++)
		{
			ResourceType resourceType = (ResourceType)i;
			if (!hashSet.Contains(i))
			{
				hero.method_23("resource_" + resourceType.ToString().ToLower(), 0.0);
			}
		}
		hero.FreeCargo = num;
	}

	public GClass94()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
