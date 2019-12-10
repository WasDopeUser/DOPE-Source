using System;
using System.Linq;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass103 : GInterface4
{
	public HeroPet Pet
	{
		get
		{
			return ConnectionManager.Instance.Value.Game.Hero.Pet;
		}
	}

	public void method_0(GClass212 gclass212_0)
	{
		HeroPet.CooldownType int_ = (HeroPet.CooldownType)gclass212_0.int_0;
		if (gclass212_0.State == 0U)
		{
			this.Pet.Cooldowns.method_1(int_, (double)(gclass212_0.vector_0.FirstOrDefault<int>() * 1000));
			return;
		}
		this.Pet.Cooldowns.Clear(int_);
	}

	public GClass103()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
