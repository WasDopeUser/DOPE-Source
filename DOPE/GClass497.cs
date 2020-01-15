using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass497 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19909;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass497(int int_0 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 19909;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 16) | this.MapId << 16);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19909);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.MapId << 16 | U.smethod_0(this.MapId, 16));
		binaryStream_0.smethod_7(-16545);
	}

	public int MapId;
}
