using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass608 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29504;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass608(int int_0 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 29504;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 12 | U.smethod_0(this.MapId, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(29504);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(8051);
		binaryStream_0.smethod_3(U.smethod_0(this.MapId, 12) | this.MapId << 20);
	}

	public int MapId;
}
