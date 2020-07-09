using System;
using System.Numerics;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass8 : GInterface4
{
	public void Run(GClass232 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.method_7();
		hero.Speed = e.int_0;
		if (hero.MovementDestination != null)
		{
			Vector2 value = hero.MovementDestination.Value;
			hero.method_4((int)value.X, (int)value.Y, hero.Speed);
		}
	}

	public GClass8()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
