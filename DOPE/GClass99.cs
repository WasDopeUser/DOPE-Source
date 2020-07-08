using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass99 : GInterface4
{
	public void Run(GClass215 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.HpMax = e.int_1;
		hero.Hp = e.int_0;
		hero.LastStatUpdate = DateTime.Now;
	}

	public GClass99()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}
}
