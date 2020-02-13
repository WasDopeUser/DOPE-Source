using System;
using System.Collections.Generic;
using System.Drawing;
using DOPE.Common.Models.Bot;

public class GClass843 : GClass840
{
	public GClass843(GClass824 gclass824_1)
	{
		Class13.igxcIukzfpare();
		base..ctor(gclass824_1);
	}

	public override bool vmethod_19(GClass826 gclass826_0)
	{
		return gclass826_0 is GClass828;
	}

	public override List<Rectangle> vmethod_17()
	{
		return GClass843.list_0;
	}

	public override BotState vmethod_18()
	{
		return BotState.TradePalladium;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass843()
	{
		Class13.igxcIukzfpare();
		GClass843.list_0 = new List<Rectangle>
		{
			new Rectangle(9950, 6550, 200, 300)
		};
	}

	public static List<Rectangle> list_0;
}
