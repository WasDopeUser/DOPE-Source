using System;

public class GClass848 : GClass846
{
	public GClass848(GClass822 gclass822_1)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor(gclass822_1, "GgInfoProvider");
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
