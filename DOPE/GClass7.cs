using System;
using DarkorbitAPI;

public class GClass7 : GInterface4
{
	public void Run(GClass219 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		value.Game.Hero.Clear();
		value.SendMessage(new GClass154());
	}

	public GClass7()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
