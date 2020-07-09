using System;
using System.Linq;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass104 : GInterface4
{
	public HeroPet Pet
	{
		get
		{
			return ConnectionManager.Instance.Value.Game.Hero.Pet;
		}
	}

	public void method_0(GClass220 gclass220_0)
	{
		HeroPet.CooldownType int_ = (HeroPet.CooldownType)gclass220_0.int_0;
		if (gclass220_0.State == 0)
		{
			this.Pet.Cooldowns.method_1(int_, (double)(gclass220_0.vector_0.FirstOrDefault<int>() * 1000));
			return;
		}
		this.Pet.Cooldowns.Clear(int_);
	}

	public void method_1(GClass224 gclass224_0)
	{
		this.Pet.method_20(gclass224_0);
	}

	public void method_2(GClass223 gclass223_0)
	{
		this.Pet.method_22(gclass223_0);
	}

	public GClass104()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
