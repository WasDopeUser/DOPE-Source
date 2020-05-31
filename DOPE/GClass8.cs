using System;
using System.Numerics;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass8 : GInterface4
{
	public void Run(GClass234 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.method_6();
		hero.Speed = e.Unknown;
		if (hero.MovementDestination != null)
		{
			Vector2 value = hero.MovementDestination.Value;
			hero.method_3((int)value.X, (int)value.Y, hero.Speed);
		}
	}

	public GClass8()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}
}
