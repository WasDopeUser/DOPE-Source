using System;
using System.Collections.Generic;
using System.Drawing;
using DOPE.Common.Models.Bot;

public class GClass842 : GClass839
{
	public GClass842(GClass823 gclass823_1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(gclass823_1);
	}

	public override bool vmethod_19(GClass825 gclass825_0)
	{
		return gclass825_0 is GClass827;
	}

	public override List<Rectangle> vmethod_17()
	{
		return GClass842.list_0;
	}

	public override BotState vmethod_18()
	{
		return BotState.TradePalladium;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass842()
	{
		Class13.Gj4N3WdzaR1LY();
		GClass842.list_0 = new List<Rectangle>
		{
			new Rectangle(9950, 6550, 200, 300)
		};
	}

	public static List<Rectangle> list_0;
}
