using System;

public class GClass850 : GClass848
{
	public GClass850(GClass824 gclass824_1)
	{
		Class13.igxcIukzfpare();
		base..ctor(gclass824_1, "GgInfoProvider");
	}

	public override int Cooldown
	{
		get
		{
			if (base.Context.Game.Web.GgInfo != null)
			{
				return 60000;
			}
			return 2000;
		}
	}

	public override void Execute()
	{
		base.Context.Game.Web.GetGalaxyGatesInfo();
	}

	public override bool vmethod_0()
	{
		return true;
	}
}
