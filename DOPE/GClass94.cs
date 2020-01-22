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
			hashSet.Add((int)gclass.gclass261_0.uint_0);
			ResourceType uint_ = (ResourceType)gclass.gclass261_0.uint_0;
			if (uint_ != ResourceType.XENOMIT)
			{
				num -= (int)gclass.Count;
			}
			hero.method_20("resource_" + uint_.ToString().ToLower(), gclass.Count);
		}
		for (int i = 0; i <= 8; i++)
		{
			ResourceType resourceType = (ResourceType)i;
			if (!hashSet.Contains(i))
			{
				hero.method_20("resource_" + resourceType.ToString().ToLower(), 0.0);
			}
		}
		hero.FreeCargo = num;
	}

	public GClass94()
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
	}
}
