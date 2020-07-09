using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass105 : GInterface4
{
	public void Run(GClass222 e)
	{
		HeroPet pet = ConnectionManager.Instance.Value.Game.Hero.Pet;
		pet.Hp = e.int_0;
		pet.HpMax = e.int_1;
		pet.IsRepairNeeded = (pet.Hp == 0);
	}

	public GClass105()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
