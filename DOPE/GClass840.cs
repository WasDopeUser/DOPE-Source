using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.Structures;

public class GClass840 : GClass839
{
	public GClass840(GClass823 gclass823_1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(gclass823_1);
	}

	public override Vector2? vmethod_22()
	{
		if (base.C.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(GClass840.<>c.<>c_0.method_0)).Value != null)
		{
			return new Vector2?(new Vector2(10150f, 6700f));
		}
		return null;
	}
}
