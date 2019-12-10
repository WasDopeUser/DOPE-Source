using System;
using DarkorbitAPI;

public class GClass114 : GInterface4
{
	public void Run(GClass232 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass230 gclass230_ in e.Items)
		{
			value.Game.Hero.method_14(gclass230_);
		}
	}

	public GClass114()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
