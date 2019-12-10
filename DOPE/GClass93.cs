using System;
using System.Runtime.CompilerServices;
using System.Threading;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass93
{
	public GClass91 Socket { get; private set; }

	public event GClass91.GClass92.GDelegate6 Disconnected;

	public event GClass91.GClass92.GDelegate5 Connected;

	[CompilerGenerated]
	public int method_0()
	{
		return this.int_0;
	}

	[CompilerGenerated]
	private void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	public string Host { get; private set; }

	public bool BdaNsdwBbq()
	{
		GClass91 socket = this.Socket;
		return socket != null && socket.method_0();
	}

	[CompilerGenerated]
	public bool method_2()
	{
		return this.bool_0;
	}

	[CompilerGenerated]
	private void method_3(bool bool_2)
	{
		this.bool_0 = bool_2;
	}

	[CompilerGenerated]
	public GClass84<GClass778> method_4()
	{
		return this.gclass84_0;
	}

	[CompilerGenerated]
	private void method_5(GClass84<GClass778> gclass84_1)
	{
		this.gclass84_0 = gclass84_1;
	}

	public ConnectionManager Connection { get; private set; }

	public GClass93(ConnectionManager connectionManager_1)
	{
		Class8.xDph7tozmh5WD();
		this.object_0 = new object();
		this.bool_1 = true;
		base..ctor();
		this.Connection = connectionManager_1;
		this.method_5(new GClass84<GClass778>(connectionManager_1));
		this.method_4().method_1(new Action<GInterface0>(GClass82.smethod_3));
		GClass82.smethod_2();
	}

	public void method_6()
	{
		this.method_3(true);
	}

	public void method_7(string string_1, int int_1)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.Host = string_1;
			this.method_1(int_1);
			this.method_8();
		}
	}

	private void method_8()
	{
		if (this.Socket != null && this.Socket.method_0())
		{
			this.method_14();
			this.Disconnect(ErrorReason.ConnectionOverridden, null, false);
		}
		this.Socket = null;
		try
		{
			this.Socket = new GClass91();
			this.method_13();
			this.method_9();
			this.Socket.method_7(this.Host, this.method_0(), true);
		}
		catch (Exception)
		{
			GClass91 socket = this.Socket;
			if (socket != null)
			{
				socket.method_10();
			}
		}
	}

	private void method_9()
	{
		this.Socket.Connected += this.method_12;
		this.Socket.method_1(new GClass91.GClass92.GDelegate7(this.method_11));
		this.Socket.Disconnected += this.method_10;
	}

	private void method_10(GClass91 gclass91_1, ErrorReason errorReason_0, Exception exception_0)
	{
		if (!this.bool_1)
		{
			this.Disconnect(errorReason_0, exception_0, true);
		}
		this.bool_1 = true;
		GClass91.GClass92.GDelegate6 disconnected = this.Disconnected;
		if (disconnected == null)
		{
			return;
		}
		disconnected(gclass91_1, errorReason_0, exception_0);
	}

	private void method_11(GClass91 gclass91_1, BinaryStream binaryStream_0, byte[] byte_0, int int_1)
	{
		if (!this.method_2())
		{
			this.method_4().method_12(binaryStream_0, byte_0, int_1);
		}
	}

	private void method_12(GClass91 gclass91_1)
	{
		this.bool_1 = false;
		if (!ConnectionManager.Instance.IsValueCreated)
		{
			ConnectionManager.Instance.Value = this.Connection;
		}
		if (!GameManager.Instance.IsValueCreated)
		{
			ThreadLocal<GameManager> instance = GameManager.Instance;
			ConnectionManager connection = this.Connection;
			instance.Value = ((connection != null) ? connection.Game : null);
		}
		GClass91.GClass92.GDelegate5 connected = this.Connected;
		if (connected == null)
		{
			return;
		}
		connected(gclass91_1);
	}

	private void method_13()
	{
		this.method_4().method_9(this.Socket, new GClass779());
	}

	public void Disconnect(ErrorReason reason, Exception ex = null, bool fromEvent = false)
	{
		if (this.bool_1)
		{
			return;
		}
		this.bool_1 = true;
		this.method_14();
		GClass91 socket = this.Socket;
		if (socket != null)
		{
			socket.method_10();
		}
		if (!fromEvent)
		{
			GClass91.GClass92.GDelegate6 disconnected = this.Disconnected;
			if (disconnected == null)
			{
				return;
			}
			disconnected(this.Socket, reason, ex);
		}
	}

	private void method_14()
	{
		this.Socket.Connected -= this.method_12;
		this.Socket.method_2(new GClass91.GClass92.GDelegate7(this.method_11));
		this.Socket.Disconnected -= this.method_10;
	}

	public void method_15(GInterface0 ginterface0_0)
	{
		if (this.BdaNsdwBbq())
		{
			this.method_4().SendMessage(ginterface0_0);
		}
	}

	[CompilerGenerated]
	private GClass91 gclass91_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private GClass84<GClass778> gclass84_0;

	[CompilerGenerated]
	private ConnectionManager connectionManager_0;

	private readonly object object_0;

	private volatile bool bool_1;
}
