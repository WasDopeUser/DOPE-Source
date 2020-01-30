using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;

public class GClass846 : GClass845
{
	public GClass835 Module { get; private set; }

	public GClass846(GClass823 gclass823_1, GClass835 gclass835_1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(gclass823_1);
		this.Module = gclass835_1;
	}

	public override bool vmethod_27()
	{
		return !base.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(GClass846.<>c.<>c_0.method_0));
	}

	public override int vmethod_50()
	{
		return int.MaxValue;
	}

	protected override bool vmethod_51(Ship ship_0, Ship ship_1)
	{
		int num = this.vmethod_9(ship_0 as NpcShip);
		int num2 = this.vmethod_9(ship_1 as NpcShip);
		return num < num2 || base.vmethod_51(ship_0, ship_1);
	}

	public override bool vmethod_49(NpcShip npcShip_0)
	{
		return false;
	}

	protected override IEnumerable<Vector2> vmethod_23()
	{
		GClass846.<GetRoamTargets>d__11 <GetRoamTargets>d__ = new GClass846.<GetRoamTargets>d__11(-2);
		<GetRoamTargets>d__.<>4__this = this;
		return <GetRoamTargets>d__;
	}

	public override int vmethod_41(NpcShip npcShip_0)
	{
		NpcUtils.NpcClass npcClass;
		if (npcShip_0 == null)
		{
			npcClass = null;
		}
		else
		{
			NpcUtils.NpcType type = npcShip_0.Type;
			npcClass = ((type != null) ? type.Class : null);
		}
		if (npcClass == NpcUtils.N_GygerimOverlord)
		{
			int val = base.vmethod_41(npcShip_0);
			int num = Math.Max(550, val);
			int num2 = Math.Max(200, num - 150);
			int num3 = num - num2;
			float num4;
			if (base.Hero.ShieldMax > 1000)
			{
				num4 = (base.Hero.HpPercentage + base.Hero.ShieldPercentage) / 200f;
			}
			else
			{
				num4 = base.Hero.HpPercentage / 100f;
			}
			float num5 = 1f - num4;
			return (int)((float)num - (float)num3 * num5);
		}
		return base.vmethod_41(npcShip_0);
	}

	public GClass846.GEnum11 State { get; protected set; }

	public GClass846.GEnum11 method_41()
	{
		if (!base.Map.Gates.Any<KeyValuePair<int, Gate>>())
		{
			return (GClass846.GEnum11)2;
		}
		int num = base.C.Hero.Group.method_11().Count<GroupManager.GroupMember>() + 1;
		MapProfile mapProfile = base.C.MapProfile;
		if (((mapProfile != null) ? mapProfile.QZ_GroupSize : 2) > num)
		{
			return (GClass846.GEnum11)0;
		}
		return (GClass846.GEnum11)1;
	}

	public override bool vmethod_52(NpcShip npcShip_0)
	{
		return this.vmethod_12(npcShip_0);
	}

	protected override bool vmethod_54()
	{
		return false;
	}

	protected override float vmethod_34(Vector2 vector2_1)
	{
		float num = Math.Max(10000f - vector2_1.X, 0f) / 3f;
		return base.vmethod_34(vector2_1) - num;
	}

	public override void Update()
	{
		base.Update();
		this.State = this.method_41();
	}

	public override IEnumerable<string> vmethod_48()
	{
		GClass846.<GetStatusText>d__22 <GetStatusText>d__ = new GClass846.<GetStatusText>d__22(-2);
		<GetStatusText>d__.<>4__this = this;
		return <GetStatusText>d__;
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable<Vector2> method_42()
	{
		return base.vmethod_23();
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable<string> method_43()
	{
		return base.vmethod_48();
	}

	[CompilerGenerated]
	private GClass835 gclass835_0;

	[CompilerGenerated]
	private GClass846.GEnum11 genum11_0;

	public enum GEnum11
	{

	}
}
