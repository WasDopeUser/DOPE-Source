using System;
using DarkorbitAPI;

public class GClass112 : GInterface4
{
	public void Run(GClass237 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass252 gclass in e.vector_1)
		{
			foreach (GClass253 gclass2 in gclass.Items)
			{
				value.Game.Hero.method_11(new GClass236(gclass2.gclass178_0, null, gclass2.gclass281_0.cYhjMitRnR, gclass2.gclass281_0.double_0));
				value.Game.Hero.method_12(gclass2.Status);
			}
		}
	}

	public GClass112()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}
}
