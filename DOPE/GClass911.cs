using System;
using System.Collections.Generic;
using System.Drawing;
using DOPE.Common.Models.Bot;

public class GClass911 : GClass908
{
	public GClass911(GClass890 gclass890_1)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(gclass890_1);
	}

	public override bool vmethod_15(GClass892 gclass892_0)
	{
		return gclass892_0 is GClass894;
	}

	public override List<Rectangle> vmethod_13()
	{
		return GClass911.list_0;
	}

	public override BotState vmethod_14()
	{
		return BotState.TradePalladium;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass911()
	{
		Class13.F93tSdiz1aNIA();
		GClass911.list_0 = new List<Rectangle>
		{
			new Rectangle(9950, 6550, 200, 300)
		};
	}

	public static List<Rectangle> list_0;
}
