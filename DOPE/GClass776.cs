using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass776 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10384;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass776(int int_0 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 10384;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 10 | U.smethod_0(this.MapId, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(10384);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.MapId, 10) | this.MapId << 22);
	}

	public int MapId;
}
