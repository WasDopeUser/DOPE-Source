using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.Structures;

public class GClass908 : GClass907
{
	public GClass908(GClass889 gclass889_1)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor(gclass889_1);
	}

	public override Vector2? vmethod_22()
	{
		if (base.C.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(GClass908.<>c.<>c_0.method_0)).Value != null)
		{
			return new Vector2?(new Vector2(10150f, 6700f));
		}
		return null;
	}
}
