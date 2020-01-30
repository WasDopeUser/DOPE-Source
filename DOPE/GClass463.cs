using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass463 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32439;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass463(int int_1 = 0, int int_2 = 0, bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 32439;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 16 | U.smethod_0(this.MapId, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32439);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-30739);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 16) | this.MapId << 16);
	}

	public int int_0;

	public bool bool_0;

	public int MapId;
}
