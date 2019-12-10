using System;
using System.Numerics;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass8 : GInterface4
{
	public void Run(GClass221 e)
	{
		Hero hero = ConnectionManager.Instance.Value.Game.Hero;
		hero.Speed = e.Unknown;
		hero.method_7();
		if (hero.MovementDestination != null)
		{
			Vector2 value = hero.MovementDestination.Value;
			hero.method_4((int)value.X, (int)value.Y, hero.Speed);
		}
	}

	public GClass8()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
