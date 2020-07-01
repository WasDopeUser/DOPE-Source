using System;
using DarkorbitAPI;

public class GClass113 : GInterface4
{
	public void Run(GClass234 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		value.Game.NextMapId = e.MapId;
		value.Game.LastJumped = DateTime.Now;
	}

	public GClass113()
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
	}
}
