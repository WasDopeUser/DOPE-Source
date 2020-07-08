using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Ace.Networking.Memory;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using Newtonsoft.Json;
using NLog;
using Syroot.BinaryData;

public class GClass84<BFxmo3X16jkv2qxH5n3> : GInterface5 where BFxmo3X16jkv2qxH5n3 : GInterface7
{
	private Logger Log
	{
		get
		{
			return LogManager.GetLogger("Base-Net-Handlers");
		}
	}

	public ConnectionManager Connection { get; set; }

	public GClass84(ConnectionManager connectionManager_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.dictionary_0 = new Dictionary<int, GInterface0>();
		this.object_0 = new object();
		base..ctor();
		this.Connection = connectionManager_1;
		MemoryStream stream_ = new MemoryStream(this.byte_0 = new byte[131072]);
		this.binaryStream_0 = stream_.smethod_2(true);
		RecyclableMemoryStream stream = MemoryManager.Instance.GetStream();
		this.binaryStream_1 = stream.smethod_2(true);
	}

	public event GClass82.GDelegate4 MessageSent
	{
		[CompilerGenerated]
		add
		{
			GClass82.GDelegate4 gdelegate = this.gdelegate4_0;
			GClass82.GDelegate4 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass82.GDelegate4 value2 = (GClass82.GDelegate4)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass82.GDelegate4>(ref this.gdelegate4_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass82.GDelegate4 gdelegate = this.gdelegate4_0;
			GClass82.GDelegate4 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass82.GDelegate4 value2 = (GClass82.GDelegate4)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass82.GDelegate4>(ref this.gdelegate4_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	public event GClass82.GDelegate4 MessageReceived
	{
		[CompilerGenerated]
		add
		{
			GClass82.GDelegate4 gdelegate = this.gdelegate4_1;
			GClass82.GDelegate4 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass82.GDelegate4 value2 = (GClass82.GDelegate4)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass82.GDelegate4>(ref this.gdelegate4_1, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass82.GDelegate4 gdelegate = this.gdelegate4_1;
			GClass82.GDelegate4 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass82.GDelegate4 value2 = (GClass82.GDelegate4)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass82.GDelegate4>(ref this.gdelegate4_1, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	[CompilerGenerated]
	public Action<GInterface0> method_0()
	{
		return this.action_0;
	}

	[CompilerGenerated]
	public void method_1(Action<GInterface0> action_1)
	{
		this.action_0 = action_1;
	}

	public GClass91 Socket { get; private set; }

	[CompilerGenerated]
	public string method_2()
	{
		return this.string_0;
	}

	[CompilerGenerated]
	public void method_3(string string_1)
	{
		this.string_0 = string_1;
	}

	[CompilerGenerated]
	public BFxmo3X16jkv2qxH5n3 method_4()
	{
		return this.gparam_0;
	}

	[CompilerGenerated]
	private void method_5(BFxmo3X16jkv2qxH5n3 Ti8L3QXotEBXBqyaXTa)
	{
		this.gparam_0 = Ti8L3QXotEBXBqyaXTa;
	}

	[CompilerGenerated]
	public BinaryStream method_6()
	{
		return this.binaryStream_0;
	}

	[CompilerGenerated]
	public BinaryStream method_7()
	{
		return this.binaryStream_1;
	}

	private GInterface0 method_8(BinaryStream binaryStream_2, out short short_0)
	{
		short_0 = binaryStream_2.ReadInt16();
		GInterface0 ginterface;
		if (!this.dictionary_0.TryGetValue((int)short_0, out ginterface))
		{
			ginterface = GClass86.smethod_2((int)short_0);
			if (ginterface == null)
			{
				this.Log.Warn<string, short>("[{tag}] Unknown command with id {id}", this.method_2(), short_0);
			}
		}
		try
		{
			if (ginterface != null)
			{
				ginterface.imethod_1(binaryStream_2);
			}
		}
		catch (Exception)
		{
		}
		if (ginterface != null)
		{
			try
			{
				Logger logger = LogManager.GetLogger("Base-Net-In");
				if (logger.IsTraceEnabled)
				{
					logger.Trace("[{tag}] Received command {commandName} ({id}) -> {content}", new object[]
					{
						this.method_2(),
						ginterface.GetType().Name,
						ginterface.Id,
						JsonConvert.SerializeObject(ginterface)
					});
				}
				else if (logger.IsInfoEnabled)
				{
					logger.Info<string, string, short>("[{tag}] Received command {commandName} ({id})", this.method_2(), ginterface.GetType().Name, ginterface.Id);
				}
			}
			catch
			{
			}
		}
		return ginterface;
	}

	public void method_9(GClass91 gclass91_1, BFxmo3X16jkv2qxH5n3 t5N2fWXRlYInc734TKp)
	{
		this.method_11();
		this.Socket = gclass91_1;
		try
		{
			BFxmo3X16jkv2qxH5n3 bfxmo3X16jkv2qxH5n = this.method_4();
			if (bfxmo3X16jkv2qxH5n != null)
			{
				bfxmo3X16jkv2qxH5n.imethod_2();
			}
		}
		catch
		{
		}
		this.method_5(t5N2fWXRlYInc734TKp);
	}

	public void method_10(string string_1)
	{
		this.SendMessage(new GClass268(string_1));
	}

	public void SendMessage(GInterface0 ginterface0_0)
	{
		LogManager.GetLogger("Base-Net-Out").Info<string, string, short>("[{tag}] Sending command {commandName} ({id})", this.method_2(), ginterface0_0.GetType().Name, ginterface0_0.Id);
		object obj = this.object_0;
		lock (obj)
		{
			this.method_6().Position = 3L;
			ginterface0_0.imethod_2(this.method_6());
			int num = (int)(this.method_6().Position - 3L);
			this.method_6().Position = 0L;
			this.method_6().WriteByte((num & 16711680) >> 16);
			this.method_6().smethod_7(num & 65535);
			BFxmo3X16jkv2qxH5n3 bfxmo3X16jkv2qxH5n = this.method_4();
			if (bfxmo3X16jkv2qxH5n != null)
			{
				bfxmo3X16jkv2qxH5n.imethod_0(this.byte_0, 0, num + 3);
			}
			try
			{
				this.Socket.method_2().GetStream().Write(this.byte_0, 0, num + 3);
			}
			catch
			{
			}
		}
		GClass82.GDelegate4 gdelegate = this.gdelegate4_0;
		if (gdelegate == null)
		{
			return;
		}
		gdelegate(ginterface0_0);
	}

	public void Reset()
	{
	}

	private void method_11()
	{
		this.int_1 = 3;
		this.method_7().Position = 0L;
		this.TldYiHixaY = new Func<BinaryStream, int, bool>(this.method_14);
	}

	public void method_12(BinaryStream binaryStream_2, byte[] byte_1, int int_5)
	{
		this.int_2 = int_5;
		this.int_0 = 0;
		BFxmo3X16jkv2qxH5n3 bfxmo3X16jkv2qxH5n = this.method_4();
		bfxmo3X16jkv2qxH5n.imethod_1(byte_1, 0, int_5);
		while (this.TldYiHixaY(binaryStream_2, int_5))
		{
			this.method_7().Position = 0L;
		}
		binaryStream_2.Position = 0L;
	}

	private bool method_13(BinaryStream binaryStream_2, int int_5)
	{
		if (this.int_2 == 0)
		{
			return false;
		}
		if (this.int_1 > 0)
		{
			int num = Math.Min(this.int_1, this.int_2);
			GClass878.smethod_0(binaryStream_2, this.method_7(), num);
			this.int_1 -= num;
			this.int_2 -= num;
			this.int_0 += num;
		}
		return this.int_1 == 0;
	}

	private bool method_14(BinaryStream binaryStream_2, int int_5)
	{
		if (!this.method_13(binaryStream_2, int_5))
		{
			return false;
		}
		this.method_7().Position = 0L;
		int num = this.method_7().ReadByte();
		this.int_3 = (num << 16 | (int)this.method_7().ReadUInt16());
		this.int_1 = this.int_3;
		this.method_7().SetLength((long)this.int_3);
		this.TldYiHixaY = new Func<BinaryStream, int, bool>(this.method_15);
		return true;
	}

	private bool method_15(BinaryStream binaryStream_2, int int_5)
	{
		if (!this.method_13(binaryStream_2, int_5))
		{
			return false;
		}
		long position = this.method_7().Position;
		this.method_7().Position = 0L;
		short num;
		GInterface0 ginterface = this.method_8(this.method_7(), out num);
		ConnectionManager connection = this.Connection;
		if (connection != null)
		{
			connection.method_18();
		}
		if (ginterface != null)
		{
			try
			{
				Action<GInterface0> action = this.method_0();
				if (action != null)
				{
					action(ginterface);
				}
				GClass82.GDelegate4 gdelegate = this.gdelegate4_1;
				if (gdelegate != null)
				{
					gdelegate(ginterface);
				}
			}
			catch (Exception ex)
			{
				this.Log.Error(ex, "[{tag}] Error while executing command {commandName} {exception}", new object[]
				{
					this.method_2(),
					ginterface.GetType().FullName,
					ex
				});
			}
		}
		this.method_11();
		return true;
	}

	public readonly Dictionary<int, GInterface0> dictionary_0;

	private readonly byte[] byte_0;

	[CompilerGenerated]
	private ConnectionManager connectionManager_0;

	[CompilerGenerated]
	private GClass82.GDelegate4 gdelegate4_0;

	[CompilerGenerated]
	private GClass82.GDelegate4 gdelegate4_1;

	[CompilerGenerated]
	private Action<GInterface0> action_0;

	[CompilerGenerated]
	private GClass91 gclass91_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private BFxmo3X16jkv2qxH5n3 gparam_0;

	[CompilerGenerated]
	private readonly BinaryStream binaryStream_0;

	[CompilerGenerated]
	private readonly BinaryStream binaryStream_1;

	private object object_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private Func<BinaryStream, int, bool> TldYiHixaY;

	private int int_4;
}
