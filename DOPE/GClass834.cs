using System;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.UI.Models;

public class GClass834 : GClass833
{
	public GClass834(GClass824 gclass824_1, TargetMap targetMap_1)
	{
		Class13.igxcIukzfpare();
		base..ctor(gclass824_1, targetMap_1);
	}

	protected override bool vmethod_0()
	{
		return true;
	}

	public override bool eypBpbBoFoK()
	{
		return false;
	}

	public override SelectedNpcModel vmethod_1(Ship ship_0)
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
