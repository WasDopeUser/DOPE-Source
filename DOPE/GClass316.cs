using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass316 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7134;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass316(int int_6 = 0, uint uint_1 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_5 = int_6;
		this.uint_0 = uint_1;
		this.int_0 = int_7;
		this.int_4 = int_8;
		this.int_3 = int_9;
		this.int_1 = int_10;
		this.int_2 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 7134;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 10 | U.smethod_0(this.int_5, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7134);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_4(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_4(this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 10) | this.int_5 << 22);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public uint uint_0;

	public int int_4;

	public int int_5;
}
