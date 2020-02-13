using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass660 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11359;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass660(uint uint_1 = 0U, int int_0 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 11359;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 5) | this.MapId << 27);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11359);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(25035);
		binaryStream_0.smethod_3(this.MapId << 5 | U.smethod_0(this.MapId, 27));
	}

	public uint uint_0;

	public int MapId;
}
