using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass98 : GInterface4
{
	public void Run(GClass208 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.HpMax = e.ViGneyvcs2;
		hero.Hp = e.int_1;
		hero.LastStatUpdate = DateTime.Now;
	}

	public GClass98()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
