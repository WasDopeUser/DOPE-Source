using System;
using System.Numerics;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass8 : GInterface4
{
	public void Run(GClass231 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.method_7();
		hero.Speed = e.GjmBmjIwIs;
		if (hero.MovementDestination != null)
		{
			Vector2 value = hero.MovementDestination.Value;
			hero.method_4((int)value.X, (int)value.Y, hero.Speed);
		}
	}

	public GClass8()
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
	}
}
