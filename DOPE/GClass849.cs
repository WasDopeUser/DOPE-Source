using System;

public class GClass849 : GClass847
{
	public GClass849(GClass823 gclass823_1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(gclass823_1, "GgInfoProvider");
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
