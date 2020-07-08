using System;
using DarkorbitAPI;

public class GClass112 : GInterface4
{
	public void Run(GClass233 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass248 gclass in e.vector_1)
		{
			foreach (GClass249 gclass2 in gclass.Items)
			{
				value.Game.Hero.method_11(new GClass232(gclass2.gclass177_0, null, gclass2.gclass276_0.double_0, gclass2.gclass276_0.double_1));
				value.Game.Hero.method_12(gclass2.Status);
			}
		}
	}

	public GClass112()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}
}
