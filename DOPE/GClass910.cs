using System;
using System.Collections.Generic;
using System.Drawing;
using DOPE.Common.Models.Bot;

public class GClass910 : GClass907
{
	public GClass910(GClass889 gclass889_1)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor(gclass889_1);
	}

	public override bool vmethod_19(GClass891 gclass891_0)
	{
		return gclass891_0 is GClass893;
	}

	public override List<Rectangle> vmethod_17()
	{
		return GClass910.list_0;
	}

	public override BotState vmethod_18()
	{
		return BotState.TradePalladium;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass910()
	{
		Class13.xnk8ImWzpOt04();
		GClass910.list_0 = new List<Rectangle>
		{
			new Rectangle(9950, 6550, 200, 300)
		};
	}

	public static List<Rectangle> list_0;
}
