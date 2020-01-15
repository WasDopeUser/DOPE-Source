using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DarkorbitAPI.Structures.Pathing;
using DOPE.UI.Models;

public class GClass837 : GClass836
{
	public GClass837(GClass822 gclass822_1)
	{
		Class13.nIxas2ezryi9b();
		this.list_0 = new List<Rectangle>();
		base..ctor(gclass822_1);
		this.list_0.Add(GClass837.rectangle_0);
	}

	public override bool vmethod_10(NpcShip npcShip_0)
	{
		GClass186 gclass;
		if (npcShip_0.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
		{
			return false;
		}
		SelectedNpcModel selectedNpcModel = this.vmethod_5(npcShip_0);
		return selectedNpcModel == null || selectedNpcModel.Enabled;
	}

	public override List<Rectangle> vmethod_17()
	{
		Point pt = base.Hero.Position.smethod_3();
		if (GClass837.rectangle_0.Contains(pt))
		{
			this.list_0[0] = GClass837.rectangle_0;
		}
		else if (GClass837.rectangle_1.Contains(pt))
		{
			this.list_0[0] = GClass837.rectangle_1;
		}
		else if (GClass837.rectangle_2.Contains(pt))
		{
			this.list_0[0] = GClass837.rectangle_2;
		}
		else
		{
			this.list_0[0] = GClass837.rectangle_3;
		}
		return this.list_0;
	}

	public override Vector2? vmethod_20(bool bool_2)
	{
		GClass837.<>c__DisplayClass9_0 CS$<>8__locals1 = new GClass837.<>c__DisplayClass9_0();
		CS$<>8__locals1.gclass837_0 = this;
		CS$<>8__locals1.vector2_0 = base.Hero.Position;
		CS$<>8__locals1.vector2_1 = (this.vmethod_39(CS$<>8__locals1.vector2_0, 2250) ?? this.vmethod_17()[0].smethod_4());
		CS$<>8__locals1.float_0 = Math.Min(Vector2.Distance(base.Hero.Position, CS$<>8__locals1.vector2_1) + 500f, 2500f);
		CS$<>8__locals1.pathSequence_0 = null;
		Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), 0);
		if (CS$<>8__locals1.pathSequence_0 != null)
		{
			base.Map.Grid.method_15(CS$<>8__locals1.pathSequence_0);
		}
		PathSequence pathSequence_ = CS$<>8__locals1.pathSequence_0;
		return new Vector2?((pathSequence_ != null) ? pathSequence_.Destination : base.C.Game.Security.method_5(base.Map, this.vmethod_17()));
	}

	public override Vector2? vmethod_19(Vector2 vector2_1, out Gate gate_0, bool bool_2 = false, bool bool_3 = true)
	{
		gate_0 = null;
		return null;
	}

	public override bool vmethod_16()
	{
		return false;
	}

	public override bool vmethod_4(bool bool_2 = false, bool bool_3 = false)
	{
		Vector2 heroPosition = base.C.HeroPosition;
		Ship ship = base.C.Map.method_5<Ship>(heroPosition, new Func<Ship, bool>(GClass837.<>c.<>c_0.method_0), null, 0);
		return ship == null || Vector2.Distance(heroPosition, ship.Position) >= 2000f;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass837()
	{
		Class13.nIxas2ezryi9b();
		GClass837.size_0 = new Size(MapUtils.LargeMapSize.Width / 2, MapUtils.LargeMapSize.Height / 2);
		GClass837.rectangle_0 = new Rectangle(new Point(0, 0), GClass837.size_0);
		GClass837.rectangle_1 = new Rectangle(new Point(GClass837.size_0.Width, 0), GClass837.size_0);
		GClass837.rectangle_2 = new Rectangle(new Point(0, GClass837.size_0.Height), GClass837.size_0);
		GClass837.rectangle_3 = new Rectangle(new Point(GClass837.size_0.Width, GClass837.size_0.Height), GClass837.size_0);
	}

	private readonly List<Rectangle> list_0;

	public static Size size_0;

	public static Rectangle rectangle_0;

	public static Rectangle rectangle_1;

	public static Rectangle rectangle_2;

	public static Rectangle rectangle_3;
}
