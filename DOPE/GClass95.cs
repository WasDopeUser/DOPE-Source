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
		this.Connection.method_8(gclass280_0.bool_0, gclass280_0.int_0, gclass280_0.int_1, gclass280_0.int_2);
	}

	public void method_1(GClass262 gclass262_0)
	{
		this.Connection.method_17();
	}

	public void method_2(GClass254 gclass254_0)
	{
		this.Connection.method_9(gclass254_0.byteArray_0.Memory.ToArray(), (uint)gclass254_0.int_0);
	}

	public void method_3(GClass216 gclass216_0)
	{
		ConnectionManager connection = this.Connection;
		connection.method_13(gclass216_0.byteArray_0.Memory.ToArray());
		connection.method_12();
		connection.method_16();
		connection.IsAuthenticated = true;
		connection.method_3();
	}

	public void method_4(GClass278 gclass278_0)
	{
		ConnectionManager connection = this.Connection;
		if (connection.Game.Settings.IsClient)
		{
			connection.SendMessage(gclass278_0);
		}
	}

	public GClass95()
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
	}
}
