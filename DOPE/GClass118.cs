using System;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;

public class GClass118 : GInterface4
{
	public void Run(GClass256 e)
	{
		HeroPet pet = ConnectionManager.Instance.Value.Game.Hero.Pet;
		PetMode mode = (PetMode)e.gclass257_0.Mode;
		pet.Modes[mode] = new HeroPet.PetModeData(e, mode);
	}

	public GClass118()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
