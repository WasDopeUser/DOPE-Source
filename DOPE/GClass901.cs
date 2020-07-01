using System;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.UI.Models;

public class GClass901 : GClass900
{
	public GClass901(GClass890 gclass890_1, TargetMap targetMap_1)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(gclass890_1, targetMap_1);
	}

	protected override bool vmethod_0()
	{
		return true;
	}

	public override bool DtujfcuHyjq()
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
