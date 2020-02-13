using System;
using DarkorbitAPI;

public class GClass112 : GInterface4
{
	public void Run(GClass236 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass251 gclass in e.vector_0)
		{
			foreach (GClass252 gclass2 in gclass.Items)
			{
				value.Game.Hero.method_12(new GClass235(gclass2.gclass178_0, null, gclass2.gclass277_0.double_0, gclass2.gclass277_0.double_1));
				value.Game.Hero.method_13(gclass2.Status);
			}
		}
	}

	public GClass112()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}
}
