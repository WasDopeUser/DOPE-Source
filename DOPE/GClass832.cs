using System;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.UI.Models;

public class GClass832 : GClass831
{
	public GClass832(GClass822 gclass822_1, TargetMap targetMap_1)
	{
		Class13.nIxas2ezryi9b();
		base..ctor(gclass822_1, targetMap_1);
	}

	protected override bool vmethod_0()
	{
		return true;
	}

	public override bool vmethod_1()
	{
		return false;
	}

	public override SelectedNpcModel vmethod_2(Ship ship_0)
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
