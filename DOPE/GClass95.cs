using System;
using DarkorbitAPI;

public class GClass95 : GInterface4
{
	public ConnectionManager Connection
	{
		get
		{
			return ConnectionManager.Instance.Value;
		}
	}

	public void method_0(GClass279 gclass279_0)
	{
		this.Connection.method_8(gclass279_0.bool_0, gclass279_0.string_0);
	}

	public void method_1(GClass260 gclass260_0)
	{
		this.Connection.method_17();
	}

	public void method_2(GClass277 gclass277_0)
	{
		ConnectionManager connection = this.Connection;
		if (connection.Game.Settings.IsClient)
		{
			connection.SendMessage(gclass277_0);
		}
	}

	public GClass95()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}
}
