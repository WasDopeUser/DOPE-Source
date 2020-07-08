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

	public void method_0(GClass219 gclass219_0)
	{
		HeroPet.CooldownType int_ = (HeroPet.CooldownType)gclass219_0.int_0;
		if (gclass219_0.State == 0)
		{
			this.Pet.Cooldowns.method_1(int_, (double)(gclass219_0.vector_0.FirstOrDefault<int>() * 1000));
			return;
		}
		this.Pet.Cooldowns.Clear(int_);
	}

	public void method_1(GClass223 gclass223_0)
	{
		this.Pet.method_19(gclass223_0);
	}

	public void method_2(GClass222 gclass222_0)
	{
		this.Pet.method_21(gclass222_0);
	}

	public GClass104()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}
}
