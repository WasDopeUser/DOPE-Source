﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DarkorbitAPI.Structures.Pathing;
using DOPE.UI.Models;

public class GClass906 : GClass905
{
	public GClass906(GClass890 gclass890_1)
	{
		Class13.lOBHd9Nzn7x2T();
		this.list_0 = new List<Rectangle>();
		base..ctor(gclass890_1);
		this.list_0.Add(GClass906.rectangle_0);
	}

	public override bool vmethod_9(NpcShip npcShip_0)
	{
		GClass187 gclass;
		if (npcShip_0.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
		{
			return false;
		}
		SelectedNpcModel selectedNpcModel = this.vmethod_4(npcShip_0);
		return selectedNpcModel == null || selectedNpcModel.Enabled;
	}

	public override List<Rectangle> vmethod_16()
	{
		Point pt = base.Hero.Position.smethod_3();
		if (GClass906.rectangle_0.Contains(pt))
		{
			this.list_0[0] = GClass906.rectangle_0;
		}
		else if (GClass906.rectangle_1.Contains(pt))
		{
			this.list_0[0] = GClass906.rectangle_1;
		}
		else if (GClass906.rectangle_2.Contains(pt))
		{
			this.list_0[0] = GClass906.rectangle_2;
		}
		else
		{
			this.list_0[0] = GClass906.rectangle_3;
		}
		return this.list_0;
	}

	public override Vector2? vmethod_20(bool bool_3)
	{
		GClass906.<>c__DisplayClass9_0 CS$<>8__locals1 = new GClass906.<>c__DisplayClass9_0();
		CS$<>8__locals1.gclass906_0 = this;
		CS$<>8__locals1.vector2_0 = base.Hero.Position;
		CS$<>8__locals1.vector2_1 = (this.vmethod_39(CS$<>8__locals1.vector2_0, 2250) ?? this.vmethod_16()[0].smethod_4());
		CS$<>8__locals1.float_0 = Math.Min(Vector2.Distance(base.Hero.Position, CS$<>8__locals1.vector2_1) + 500f, 2500f);
		CS$<>8__locals1.pathSequence_0 = null;
		Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), 0);
		if (CS$<>8__locals1.pathSequence_0 != null)
		{
			base.Map.Grid.method_14(CS$<>8__locals1.pathSequence_0);
		}
		PathSequence pathSequence_ = CS$<>8__locals1.pathSequence_0;
		return new Vector2?((pathSequence_ != null) ? pathSequence_.Destination : base.C.Game.Security.method_5(base.Map, this.vmethod_16()));
	}

	public override Vector2? vmethod_19(Vector2 vector2_1, out Gate gate_0, bool bool_3 = false, bool bool_4 = true)
	{
		gate_0 = null;
		return null;
	}

	public override bool vmethod_15()
	{
		return false;
	}

	public override bool vmethod_3(bool bool_3 = false, bool bool_4 = false)
	{
		Vector2 heroPosition = base.C.HeroPosition;
		Ship ship = base.C.Map.method_5<Ship>(heroPosition, new Func<Ship, bool>(GClass906.<>c.<>c_0.method_0), null, 0);
		return ship == null || Vector2.Distance(heroPosition, ship.Position) >= 2000f;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass906()
	{
		Class13.lOBHd9Nzn7x2T();
		GClass906.size_0 = new Size(MapUtils.LargeMapSize.Width / 2, MapUtils.LargeMapSize.Height / 2);
		GClass906.rectangle_0 = new Rectangle(new Point(0, 0), GClass906.size_0);
		GClass906.rectangle_1 = new Rectangle(new Point(GClass906.size_0.Width, 0), GClass906.size_0);
		GClass906.rectangle_2 = new Rectangle(new Point(0, GClass906.size_0.Height), GClass906.size_0);
		GClass906.rectangle_3 = new Rectangle(new Point(GClass906.size_0.Width, GClass906.size_0.Height), GClass906.size_0);
	}

	private readonly List<Rectangle> list_0;

	public static Size size_0;

	public static Rectangle rectangle_0;

	public static Rectangle rectangle_1;

	public static Rectangle rectangle_2;

	public static Rectangle rectangle_3;
}
