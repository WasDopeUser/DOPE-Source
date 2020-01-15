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

	public void method_0(GClass222 gclass222_0)
	{
		HeroPet.CooldownType int_ = (HeroPet.CooldownType)gclass222_0.int_0;
		if (gclass222_0.State == 0U)
		{
			this.Pet.Cooldowns.method_1(int_, (double)(gclass222_0.GpbcoInvRv.FirstOrDefault<int>() * 1000));
			return;
		}
		this.Pet.Cooldowns.Clear(int_);
	}

	public void method_1(GClass226 gclass226_0)
	{
		this.Pet.method_19(gclass226_0);
	}

	public void method_2(GClass225 gclass225_0)
	{
		this.Pet.pIpVfbHlqe(gclass225_0);
	}

	public GClass104()
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
	}
}
