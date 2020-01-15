using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.Structures;

public class GClass839 : GClass838
{
	public GClass839(GClass822 gclass822_1)
	{
		Class13.nIxas2ezryi9b();
		base..ctor(gclass822_1);
	}

	public override Vector2? vmethod_21()
	{
		if (base.C.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(GClass839.<>c.<>c_0.method_0)).Value != null)
		{
			return new Vector2?(new Vector2(10150f, 6700f));
		}
		return null;
	}
}
