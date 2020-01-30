using System;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.UI.Models;

public class GClass833 : GClass832
{
	public GClass833(GClass823 gclass823_1, TargetMap targetMap_1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(gclass823_1, targetMap_1);
	}

	protected override bool vmethod_0()
	{
		return true;
	}

	public override bool vmethod_1()
	{
		return false;
	}

	public override SelectedNpcModel snWlbuEwdg5(Ship ship_0)
	{
		if (ship_0 == null)
		{
			return null;
		}
		MapProfile mapProfile = base.MapProfile;
		if (mapProfile == null)
		{
			return null;
		}
		return mapProfile.GetModel(ship_0, base.C.Map, null, 0);
	}
}
