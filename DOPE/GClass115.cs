using System;
using DarkorbitAPI;

public class GClass115 : GInterface4
{
	public void Run(GClass246 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass244 gclass244_ in e.Items)
		{
			value.Game.Hero.method_14(gclass244_);
		}
	}

	public GClass115()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}
}
