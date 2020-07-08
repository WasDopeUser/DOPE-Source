using System;

public class GClass917 : GClass915
{
	public GClass917(GClass889 gclass889_1)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor(gclass889_1, "GgInfoProvider");
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
