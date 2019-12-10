using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass104 : GInterface4
{
	public void Run(GClass214 e)
	{
		HeroPet pet = ConnectionManager.Instance.Value.Game.Hero.Pet;
		pet.Hp = e.opInfZiQoO;
		pet.HpMax = e.int_0;
		pet.IsRepairNeeded = (pet.Hp == 0);
	}

	public GClass104()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
