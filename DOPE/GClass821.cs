using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;

public class GClass821 : GClass820
{
	public GClass821(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(gclass810_1);
	}

	public override bool vmethod_1(Ship ship_0, out Ship ship_1)
	{
		GClass821.<>c__DisplayClass1_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass821_0 = this;
		ship_1 = null;
		if (base.vmethod_1(ship_0, out ship_1))
		{
			return true;
		}
		CS$<>8__locals1.ship_0 = ship_0;
		if (CS$<>8__locals1.ship_0 == null)
		{
			return false;
		}
		Vector2 position = CS$<>8__locals1.ship_0.Position;
		Vector2 heroPosition = base.C.HeroPosition;
		NpcShip npcShip = CS$<>8__locals1.ship_0 as NpcShip;
		if (npcShip == null)
		{
			this.method_1(1.0, ref CS$<>8__locals1);
			return true;
		}
		if ((!base.C.IsAttacking || base.C.AttackingId != CS$<>8__locals1.ship_0.Id) && CS$<>8__locals1.ship_0 == base.C.Map.SelectedShip && !this.klqPvzeAqVH(npcShip) && (!this.vmethod_5(npcShip) || npcShip.ShieldPercentage < 99f))
		{
			this.method_1(2.0, ref CS$<>8__locals1);
			return true;
		}
		if (CS$<>8__locals1.ship_0.ShieldPercentage >= 98f && Vector2.Distance(position, heroPosition) > 3500f && CS$<>8__locals1.ship_0.HpMax - CS$<>8__locals1.ship_0.Hp <= 150000)
		{
			this.method_1(1.0, ref CS$<>8__locals1);
			return true;
		}
		return false;
	}

	[CompilerGenerated]
	private void method_1(double double_0, ref GClass821.<>c__DisplayClass1_0 <>c__DisplayClass1_0_0)
	{
		base.C.NpcLockout.method_1(<>c__DisplayClass1_0_0.ship_0.Id, double_0 * 10000.0);
	}
}
