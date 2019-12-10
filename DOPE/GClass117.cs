using System;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;

public class GClass117 : GInterface4
{
	public void Run(GClass243 e)
	{
		ConnectionManager.Instance.Value.Game.Hero.Pet.Modes[(PetMode)e.gclass244_0.Mode] = e;
	}

	public GClass117()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
