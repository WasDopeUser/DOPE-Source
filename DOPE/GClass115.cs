using System;
using DarkorbitAPI;

public class GClass115 : GInterface4
{
	public void Run(GClass245 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass243 gclass243_ in e.Items)
		{
			value.Game.Hero.method_15(gclass243_);
		}
	}

	public GClass115()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}
}
