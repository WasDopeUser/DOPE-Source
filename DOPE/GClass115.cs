using System;
using DarkorbitAPI;

public class GClass115 : GInterface4
{
	public void Run(GClass243 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass241 gclass241_ in e.Items)
		{
			value.Game.Hero.method_15(gclass241_);
		}
	}

	public GClass115()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
