using System;
using System.Collections.Generic;
using System.Drawing;
using DOPE.Common.Models.Bot;

public class GClass841 : GClass838
{
	public GClass841(GClass822 gclass822_1)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor(gclass822_1);
	}

	public override bool vmethod_19(GClass824 gclass824_0)
	{
		return gclass824_0 is GClass826;
	}

	public override List<Rectangle> vmethod_17()
	{
		return GClass841.list_0;
	}

	public override BotState vmethod_18()
	{
		return BotState.TradePalladium;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass841()
	{
		Class13.tMHx78BzgCM8j();
		GClass841.list_0 = new List<Rectangle>
		{
			new Rectangle(9950, 6550, 200, 300)
		};
	}

	public static List<Rectangle> list_0;
}
