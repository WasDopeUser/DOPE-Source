using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.UI.Models;

public class GClass906 : GClass904
{
	public GClass906(GClass889 gclass889_1)
	{
		Class13.xnk8ImWzpOt04();
		this.float_1 = 100f;
		base..ctor(gclass889_1);
		this.float_0 = (float)base.C.Game.Random.NextDouble() * 2f;
		this.float_1 = (float)base.C.Game.Random.Next(100, 300);
	}

	public override bool vmethod_10(NpcShip npcShip_1)
	{
		GClass186 gclass;
		if (npcShip_1.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
		{
			return false;
		}
		NpcUtils.NpcType type = npcShip_1.Type;
		if (((type != null) ? type.Class : null) == NpcUtils.N_EMFreighter)
		{
			return false;
		}
		SelectedNpcModel selectedNpcModel = this.vmethod_5(npcShip_1);
		return selectedNpcModel == null || selectedNpcModel.Enabled;
	}

	public override bool vmethod_26()
	{
		if (base.vmethod_26())
		{
			MapProfile mapProfile = base.C.MapProfile;
			return mapProfile != null && mapProfile.MinHp > 0;
		}
		return false;
	}

	public override Vector2? vmethod_21(bool bool_3)
	{
		Vector2 position = base.Hero.Position;
		if (this.method_23() == null)
		{
			return null;
		}
		return this.vmethod_39(position, this.method_23().Position, 1275f, null, 0.4f);
	}

	public override bool vmethod_6(NpcShip npcShip_1)
	{
		SelectedNpcModel selectedNpcModel = this.vmethod_5(npcShip_1);
		if (selectedNpcModel == null || selectedNpcModel.IgnoreOwnership)
		{
			return true;
		}
		if (base.method_0() == GroupAttackMode.Assist)
		{
			int? num = (npcShip_1 != null) ? new int?(npcShip_1.Id) : null;
			int num2 = base.method_12();
			return num.GetValueOrDefault() == num2 & num != null;
		}
		return false;
	}

	public override Vector2? vmethod_20(Vector2 vector2_2, out Gate gate_0, bool bool_3 = false, bool bool_4 = true)
	{
		gate_0 = base.Map.Gates.FirstOrDefault<KeyValuePair<int, Gate>>().Value;
		Gate gate = gate_0;
		if (gate == null)
		{
			return null;
		}
		return new Vector2?(gate.Position);
	}

	public override bool vmethod_16()
	{
		return false;
	}

	public override bool vmethod_15()
	{
		return base.vmethod_15() && (!base.C.method_76() || base.Hero.HpPercentage < 40f);
	}

	public override bool vmethod_4(bool bool_3 = false, bool bool_4 = false)
	{
		Vector2 heroPosition = base.C.HeroPosition;
		Ship ship = base.C.Map.method_5<Ship>(heroPosition, new Func<Ship, bool>(GClass906.<>c.<>c_0.method_0), null, 0);
		return (ship == null || Vector2.Distance(heroPosition, ship.Position) >= 1000f) && (!base.Hero.LastTookDamage.smethod_0(5000) || !bool_3) && (Vector2.Distance(this.method_24(), heroPosition) <= 1400f && this.method_23() != null);
	}

	public override bool vmethod_8(NpcShip npcShip_1)
	{
		return this.method_23() != null && Vector2.Distance(this.method_24(), npcShip_1.Position) < 1500f && base.vmethod_8(npcShip_1);
	}

	public override bool vmethod_13(Collectible collectible_0)
	{
		return (this.method_23() == null || Vector2.Distance(this.method_24(), collectible_0.Position) < 2250f) && base.vmethod_13(collectible_0);
	}

	public override bool vmethod_12(NpcShip npcShip_1)
	{
		return false;
	}

	public override bool vmethod_19(GClass891 gclass891_0)
	{
		return gclass891_0 is GClass898;
	}

	public override bool vmethod_14(Ship ship_0, Collectible collectible_0)
	{
		return this.vmethod_13(collectible_0);
	}

	protected override float vmethod_35(Vector2 vector2_2)
	{
		float num = base.vmethod_35(vector2_2);
		if (Vector2.Distance(this.method_24(), vector2_2) <= 1500f)
		{
			num -= 150f;
		}
		else
		{
			num -= 101500f;
		}
		return num;
	}

	public override int vmethod_48()
	{
		MapProfile mapProfile = base.C.MapProfile;
		if (mapProfile != null && mapProfile.ReviveAtPortal && !base.C.IsStopping && this.method_26().smethod_0(60000))
		{
			return 3;
		}
		return 1;
	}

	protected override IEnumerable<Vector2> vmethod_23()
	{
		IEnumerator<Vector2> enumerator = this.method_28().GetEnumerator();
		for (;;)
		{
			try
			{
				IL_52:
				if (!enumerator.MoveNext())
				{
					break;
				}
				goto IL_94;
				IL_4A:
				goto IL_52;
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			break;
			IL_94:
			Vector2 vector = enumerator.Current;
			yield return vector;
			goto IL_4A;
		}
		enumerator = null;
		yield return GClass872.smethod_8(this.method_24(), this.float_1, this.float_0);
		yield break;
		yield break;
	}

	public override int vmethod_9(NpcShip npcShip_1)
	{
		int num = base.vmethod_9(npcShip_1);
		if (num >= 0)
		{
			if (npcShip_1.LastAttackedHero.smethod_0(5000))
			{
				num++;
			}
			MapProfile mapProfile = base.C.MapProfile;
			if (mapProfile != null && mapProfile.Escort_PreferFreeNPCs && (npcShip_1.LeashedBy <= 0 || base.Hero.Group.method_1(npcShip_1.LeashedBy)))
			{
				num += 3;
			}
		}
		return num;
	}

	[CompilerGenerated]
	public NpcShip method_23()
	{
		return this.npcShip_0;
	}

	[CompilerGenerated]
	public void GiGwXsjKoOm(NpcShip npcShip_1)
	{
		this.npcShip_0 = npcShip_1;
	}

	[CompilerGenerated]
	public Vector2 method_24()
	{
		return this.vector2_1;
	}

	[CompilerGenerated]
	public void method_25(Vector2 vector2_2)
	{
		this.vector2_1 = vector2_2;
	}

	public override bool vmethod_1(Ship ship_0, out Ship ship_1)
	{
		GClass906.<>c__DisplayClass29_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass906_0 = this;
		CS$<>8__locals1.ship_0 = ship_0;
		ship_1 = null;
		if (CS$<>8__locals1.ship_0 == null)
		{
			return false;
		}
		if (this.method_23() != null && Vector2.Distance(CS$<>8__locals1.ship_0.Position, this.method_24()) <= 1600f)
		{
			return base.vmethod_1(CS$<>8__locals1.ship_0, out ship_1);
		}
		this.method_29(1.0, ref CS$<>8__locals1);
		return true;
	}

	public override Gate vmethod_25(int int_1)
	{
		if (MapUtils.smethod_2(int_1) == MapGroup.PayloadEscort)
		{
			return null;
		}
		return base.Map.Gates.FirstOrDefault<KeyValuePair<int, Gate>>().Value;
	}

	public override IEnumerable<string> vmethod_50()
	{
		IEnumerator<string> enumerator = this.method_30().GetEnumerator();
		for (;;)
		{
			try
			{
				IL_52:
				if (!enumerator.MoveNext())
				{
					break;
				}
				goto IL_A2;
				IL_4A:
				goto IL_52;
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			break;
			IL_A2:
			string text = enumerator.Current;
			yield return text;
			goto IL_4A;
		}
		enumerator = null;
		string format = "Payload HP: {0:0.0}%";
		NpcShip npcShip = this.method_23();
		yield return string.Format(format, (npcShip != null) ? npcShip.HpPercentage : 0f);
		DateTimeOffset now = DateTimeOffset.Now;
		yield break;
		yield break;
	}

	public override bool vmethod_27()
	{
		return this.method_23() != null;
	}

	[CompilerGenerated]
	public DateTimeOffset method_26()
	{
		return this.dateTimeOffset_0;
	}

	[CompilerGenerated]
	public void method_27(DateTimeOffset dateTimeOffset_1)
	{
		this.dateTimeOffset_0 = dateTimeOffset_1;
	}

	public override void Update()
	{
		base.Update();
		this.GiGwXsjKoOm(base.Map.method_7<NpcShip>(base.Hero.Position, new Func<NpcShip, bool>(GClass906.<>c.<>c_0.method_1), null, 0).FirstOrDefault<ValueTuple<NpcShip, float, int>>().Item1);
		if (this.method_23() != null)
		{
			this.method_27(DateTimeOffset.Now);
		}
		NpcShip npcShip = this.method_23();
		this.method_25((npcShip != null) ? npcShip.Position : base.Map.Center);
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable<Vector2> method_28()
	{
		return base.vmethod_23();
	}

	[CompilerGenerated]
	private void method_29(double double_0, ref GClass906.<>c__DisplayClass29_0 <>c__DisplayClass29_0_0)
	{
		base.C.NpcLockout.method_1(<>c__DisplayClass29_0_0.ship_0.Id, double_0 * 10000.0);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerable<string> method_30()
	{
		return base.vmethod_50();
	}

	private float float_0;

	private float float_1;

	[CompilerGenerated]
	private NpcShip npcShip_0;

	[CompilerGenerated]
	private Vector2 vector2_1;

	[CompilerGenerated]
	private DateTimeOffset dateTimeOffset_0;
}
