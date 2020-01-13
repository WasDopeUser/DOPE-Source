using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass109 : GInterface4
{
	public void Run(GClass230 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.Shield = e.int_0;
		hero.ShieldMax = e.eiaBfDdiqn;
		hero.LastStatUpdate = DateTimeOffset.Now;
	}

	public GClass109()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}
}
