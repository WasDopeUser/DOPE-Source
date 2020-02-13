using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass363 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29186;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass363(int int_1 = 0, int int_2 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 29186;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 3) | this.MapId << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(29186);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_6(-14688);
		binaryStream_0.smethod_6(30803);
		binaryStream_0.smethod_3(this.MapId << 3 | U.smethod_0(this.MapId, 29));
	}

	public int int_0;

	public int MapId;
}
