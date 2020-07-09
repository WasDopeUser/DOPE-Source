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

	public void method_0(GClass280 gclass280_0)
	{
		this.Connection.method_8(gclass280_0.bool_0, gclass280_0.string_0);
	}

	public void method_1(GClass261 gclass261_0)
	{
		this.Connection.method_17();
	}

	public void method_2(GClass278 gclass278_0)
	{
		ConnectionManager connection = this.Connection;
		if (connection.Game.Settings.IsClient)
		{
			connection.SendMessage(gclass278_0);
		}
	}

	public GClass95()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
