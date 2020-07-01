using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.Structures;

public class GClass909 : GClass908
{
	public GClass909(GClass890 gclass890_1)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(gclass890_1);
	}

	public override Vector2? vmethod_18()
	{
		if (base.C.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(GClass909.<>c.<>c_0.method_0)).Value != null)
		{
			return new Vector2?(new Vector2(10150f, 6700f));
		}
		return null;
	}
}
