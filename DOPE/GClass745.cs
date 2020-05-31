using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass745 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12617;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass745(uint uint_1 = 0U, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_6 = int_10;
		this.int_0 = int_11;
		this.int_2 = int_12;
		this.int_4 = int_13;
		this.int_5 = int_14;
		this.int_9 = int_15;
		this.int_8 = int_16;
		this.int_3 = int_17;
		this.int_1 = int_18;
		this.int_7 = int_19;
	}

	public virtual int vmethod_0()
	{
		return 12617;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 6 | U.smethod_0(this.int_4, 26));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 5 | U.smethod_0(this.int_6, 27));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 1) | this.int_7 << 31);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 6) | this.int_8 << 26);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 8) | this.int_9 << 24);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12617);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_4(this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 6) | this.int_4 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 5) | this.int_6 << 27);
		binaryStream_0.smethod_4(this.int_7 << 1 | U.smethod_0(this.int_7, 31));
		binaryStream_0.smethod_4(this.int_8 << 6 | U.smethod_0(this.int_8, 26));
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.int_9 << 8 | U.smethod_0(this.int_9, 24));
		binaryStream_0.smethod_7(3988);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public uint uint_0;

	public int int_9;
}
