using System;

public class GClass918 : GClass916
{
	public GClass918(GClass890 gclass890_1)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(gclass890_1, "GgInfoProvider");
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
