using System;
using DarkorbitAPI;

public class GClass112 : GInterface4
{
	public void Run(GClass225 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		value.Game.NextMapId = e.int_1;
		value.Game.LastJumped = DateTime.Now;
	}

	public GClass112()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
