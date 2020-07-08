using System;
using DarkorbitAPI;

public class GClass115 : GInterface4
{
	public void Run(GClass242 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass240 gclass240_ in e.Items)
		{
			value.Game.Hero.method_14(gclass240_);
		}
	}

	public GClass115()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}
}
