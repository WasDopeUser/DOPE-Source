using System;
using System.Collections.Generic;
using System.Drawing;
using DOPE.Common.Models.Bot;

public class GClass825 : GClass822
{
	public GClass825(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(gclass810_1);
	}

	public override bool vmethod_15(GClass812 gclass812_0)
	{
		return gclass812_0 is GClass814;
	}

	public override List<Rectangle> vmethod_13()
	{
		return GClass825.list_0;
	}

	public override BotState vmethod_14()
	{
		return BotState.TradePalladium;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass825()
	{
		Class8.xDph7tozmh5WD();
		GClass825.list_0 = new List<Rectangle>
		{
			new Rectangle(9950, 6550, 200, 300)
		};
	}

	public static List<Rectangle> list_0;
}
