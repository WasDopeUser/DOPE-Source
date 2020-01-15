using System;
using System.Numerics;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass8 : GInterface4
{
	public void Run(GClass233 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.Speed = e.Unknown;
		hero.method_6();
		if (hero.MovementDestination != null)
		{
			Vector2 value = hero.MovementDestination.Value;
			hero.method_3((int)value.X, (int)value.Y, hero.Speed);
		}
	}

	public GClass8()
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
	}
}
