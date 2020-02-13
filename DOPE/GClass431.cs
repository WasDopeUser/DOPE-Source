using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass431 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9422;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass431(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 9422;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 1) | this.MapId << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9422);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(6021);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		binaryStream_0.smethod_3(this.MapId << 1 | U.smethod_0(this.MapId, 31));
	}

	public int int_0;

	public int int_1;

	public int MapId;
}
