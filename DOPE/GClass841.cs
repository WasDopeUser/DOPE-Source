using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.Structures;

public class GClass841 : GClass840
{
	public GClass841(GClass824 gclass824_1)
	{
		Class13.igxcIukzfpare();
		base..ctor(gclass824_1);
	}

	public override Vector2? vmethod_22()
	{
		if (base.C.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(GClass841.<>c.<>c_0.method_0)).Value != null)
		{
			return new Vector2?(new Vector2(10150f, 6700f));
		}
		return null;
	}
}
