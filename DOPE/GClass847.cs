using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;

public class GClass847 : GClass846
{
	public GClass836 Module { get; private set; }

	public GClass847(GClass824 gclass824_1, GClass836 gclass836_1)
	{
		Class13.igxcIukzfpare();
		base..ctor(gclass824_1);
		this.Module = gclass836_1;
	}

	public override bool vmethod_27()
	{
		return !base.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(GClass847.<>c.<>c_0.method_0));
	}

	public override int vmethod_51()
	{
		return int.MaxValue;
	}

	protected override bool vmethod_52(Ship ship_0, Ship ship_1)
	{
		int num = this.vmethod_9(ship_0 as NpcShip);
		int num2 = this.vmethod_9(ship_1 as NpcShip);
		return num < num2 || base.vmethod_52(ship_0, ship_1);
	}

	public override bool vmethod_50(NpcShip npcShip_0)
	{
		return false;
	}

	protected override IEnumerable<Vector2> vmethod_23()
	{
		GClass847.<GetRoamTargets>d__11 <GetRoamTargets>d__ = new GClass847.<GetRoamTargets>d__11(-2);
		<GetRoamTargets>d__.<>4__this = this;
		return <GetRoamTargets>d__;
	}

	public override int vmethod_42(NpcShip npcShip_0)
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
			int val = base.vmethod_42(npcShip_0);
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
		return base.vmethod_42(npcShip_0);
	}

	public GClass847.GEnum11 State { get; protected set; }

	public GClass847.GEnum11 method_40()
	{
		if (!base.Map.Gates.Any<KeyValuePair<int, Gate>>())
		{
			return (GClass847.GEnum11)2;
		}
		int num = base.C.Hero.Group.method_10().Count<GroupManager.GroupMember>() + 1;
		MapProfile mapProfile = base.C.MapProfile;
		if (((mapProfile != null) ? mapProfile.QZ_GroupSize : 2) > num)
		{
			return (GClass847.GEnum11)0;
		}
		return (GClass847.GEnum11)1;
	}

	public override bool vmethod_53(NpcShip npcShip_0)
	{
		return this.vmethod_12(npcShip_0);
	}

	protected override bool vmethod_55()
	{
		return false;
	}

	protected override float vmethod_35(Vector2 vector2_1)
	{
		float num = Math.Max(10000f - vector2_1.X, 0f) / 3f;
		return base.vmethod_35(vector2_1) - num;
	}

	public override void Update()
	{
		base.Update();
		this.State = this.method_40();
	}

	public override IEnumerable<string> vmethod_49()
	{
		GClass847.<GetStatusText>d__22 <GetStatusText>d__ = new GClass847.<GetStatusText>d__22(-2);
		<GetStatusText>d__.<>4__this = this;
		return <GetStatusText>d__;
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable<Vector2> method_41()
	{
		return base.vmethod_23();
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable<string> method_42()
	{
		return base.vmethod_49();
	}

	[CompilerGenerated]
	private GClass836 gclass836_0;

	[CompilerGenerated]
	private GClass847.GEnum11 genum11_0;

	public enum GEnum11
	{

	}
}
