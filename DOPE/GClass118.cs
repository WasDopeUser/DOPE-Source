using System;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;

public class GClass118 : GInterface4
{
	public void Run(GClass257 e)
	{
		HeroPet pet = ConnectionManager.Instance.Value.Game.Hero.Pet;
		PetMode mode = (PetMode)e.gclass258_0.Mode;
		pet.Modes[mode] = new HeroPet.PetModeData(e, mode);
	}

	public GClass118()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}
}
