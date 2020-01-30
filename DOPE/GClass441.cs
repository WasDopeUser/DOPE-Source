using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass441 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 485;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass441(uint uint_1 = 0U, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_3 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.int_1 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 485;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 3) | this.int_3 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(485);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-32629);
		binaryStream_0.smethod_7(-2570);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		binaryStream_0.smethod_4(this.int_3 << 3 | U.smethod_0(this.int_3, 29));
	}

	public int int_0;

	public uint uint_0;

	public int int_1;

	public int int_2;

	public int int_3;
}
