using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass108 : GInterface4
{
	public void Run(GClass218 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.Shield = e.int_0;
		hero.ShieldMax = e.int_1;
		hero.LastStatUpdate = DateTimeOffset.Now;
	}

	public GClass108()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
