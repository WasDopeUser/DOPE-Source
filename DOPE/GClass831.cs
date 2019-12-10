using System;

public class GClass831 : GClass829
{
	public GClass831(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(gclass810_1, "GgInfoProvider");
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
