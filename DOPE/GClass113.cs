using System;
using DarkorbitAPI;

public class GClass113 : GInterface4
{
	public void Run(GClass237 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		value.Game.NextMapId = e.MapId;
		value.Game.LastJumped = DateTime.Now;
	}

	public GClass113()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}
}
