using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass109 : GInterface4
{
	public void Run(GClass230 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.Shield = e.int_1;
		hero.ShieldMax = e.int_0;
		hero.LastStatUpdate = DateTimeOffset.Now;
	}

	public GClass109()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}
}
