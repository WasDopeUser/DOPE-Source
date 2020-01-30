using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass580 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1206;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass580(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_1 = int_5;
		this.int_0 = int_6;
		this.int_2 = int_7;
		this.int_3 = int_8;
		this.int_4 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 1206;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 5) | this.int_4 << 27);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1206);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.smethod_4(this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		binaryStream_0.smethod_4(this.int_4 << 5 | U.smethod_0(this.int_4, 27));
		binaryStream_0.smethod_7(-24398);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
