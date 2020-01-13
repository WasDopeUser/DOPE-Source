using System;
using DarkorbitAPI;

public class GClass112 : GInterface4
{
	public void Run(GClass236 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass251 gclass in e.vector_1)
		{
			foreach (GClass252 gclass2 in gclass.Items)
			{
				value.Game.Hero.method_11(new GClass235(gclass2.gclass178_0, null, gclass2.gclass277_0.LxgYoPoDrH, gclass2.gclass277_0.double_0));
				value.Game.Hero.method_12(gclass2.Status);
			}
		}
	}

	public GClass112()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}
}
