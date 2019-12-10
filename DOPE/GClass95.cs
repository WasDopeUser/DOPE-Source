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

	public void method_0(GClass266 gclass266_0)
	{
		this.Connection.method_8(gclass266_0.bool_0, gclass266_0.int_0, gclass266_0.int_1, gclass266_0.int_2);
	}

	public void method_1(GClass248 gclass248_0)
	{
		this.Connection.method_19();
	}

	public void method_2(GClass240 gclass240_0)
	{
		this.Connection.method_9(gclass240_0.byteArray_0.Memory.ToArray(), (uint)gclass240_0.int_0);
	}

	public void method_3(GClass206 gclass206_0)
	{
		ConnectionManager connection = this.Connection;
		connection.method_13(gclass206_0.byteArray_0.Memory.ToArray());
		connection.method_12();
		connection.method_16();
		connection.IsAuthenticated = true;
		connection.method_3();
	}

	public void method_4(GClass264 gclass264_0)
	{
		ConnectionManager connection = this.Connection;
		if (connection.Game.Settings.IsClient)
		{
			connection.SendMessage(gclass264_0);
		}
	}

	public GClass95()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
