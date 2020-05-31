using System;
using System.Collections.Generic;
using System.Drawing;
using DOPE.Common.Models.Bot;

public class GClass860 : GClass857
{
	public GClass860(GClass839 gclass839_1)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(gclass839_1);
	}

	public override bool vmethod_19(GClass841 gclass841_0)
	{
		return gclass841_0 is GClass843;
	}

	public override List<Rectangle> vmethod_17()
	{
		return GClass860.list_0;
	}

	public override BotState vmethod_18()
	{
		return BotState.TradePalladium;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass860()
	{
		Class13.NP5bWyNzLwONS();
		GClass860.list_0 = new List<Rectangle>
		{
			new Rectangle(9950, 6550, 200, 300)
		};
	}

	public static List<Rectangle> list_0;
}
