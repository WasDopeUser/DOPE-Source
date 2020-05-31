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

	public void method_0(GClass284 gclass284_0)
	{
		this.Connection.method_7(gclass284_0.bool_0, gclass284_0.int_0, gclass284_0.int_1, gclass284_0.int_2);
	}

	public void method_1(GClass266 gclass266_0)
	{
		this.Connection.method_16();
	}

	public void method_2(GClass255 gclass255_0)
	{
		this.Connection.method_8(gclass255_0.byteArray_0.Memory.ToArray(), (uint)gclass255_0.int_0);
	}

	public void method_3(GClass217 gclass217_0)
	{
		ConnectionManager connection = this.Connection;
		connection.method_12(gclass217_0.byteArray_0.Memory.ToArray());
		connection.method_11();
		connection.method_15();
		connection.IsAuthenticated = true;
		connection.method_3();
	}

	public void method_4(GClass282 gclass282_0)
	{
		ConnectionManager connection = this.Connection;
		if (connection.Game.Settings.IsClient)
		{
			connection.SendMessage(gclass282_0);
		}
	}

	public GClass95()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}
}
