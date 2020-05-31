using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass374 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9378;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass374(int int_13 = 0, int int_14 = 0, int int_15 = 0, uint uint_1 = 0U, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, string string_1 = "", int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.int_8 = int_13;
		this.int_1 = int_14;
		this.int_9 = int_15;
		this.uint_0 = uint_1;
		this.int_0 = int_16;
		this.int_7 = int_17;
		this.int_5 = int_18;
		this.int_2 = int_19;
		this.int_6 = int_20;
		this.string_0 = string_1;
		this.int_10 = int_21;
		this.int_12 = int_22;
		this.int_3 = int_23;
		this.int_4 = int_24;
		this.int_11 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 9378;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 15 | U.smethod_0(this.int_6, 17));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 14 | U.smethod_0(this.int_7, 18));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 1 | U.smethod_0(this.int_8, 31));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 14) | this.int_9 << 18);
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 16 | U.smethod_0(this.int_10, 16));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (this.int_11 << 1 | U.smethod_0(this.int_11, 31));
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 2 | U.smethod_0(this.int_12, 30));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9378);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		binaryStream_0.smethod_4(this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 15) | this.int_6 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 14) | this.int_7 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 1) | this.int_8 << 31);
		binaryStream_0.smethod_4(this.int_9 << 14 | U.smethod_0(this.int_9, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_10, 16) | this.int_10 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_11, 1) | this.int_11 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_12, 2) | this.int_12 << 30);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-5613);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int int_12;

	public uint uint_0;
}
