using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass764 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9862;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass764(int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_10 = int_13;
		this.int_12 = int_14;
		this.int_8 = int_15;
		this.int_0 = int_16;
		this.int_5 = int_17;
		this.int_9 = int_18;
		this.int_1 = int_19;
		this.int_2 = int_20;
		this.int_4 = int_21;
		this.int_7 = int_22;
		this.int_6 = int_23;
		this.int_11 = int_24;
		this.int_3 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 9862;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 14 | U.smethod_0(this.int_4, 18));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 7 | U.smethod_0(this.int_5, 25));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 12 | U.smethod_0(this.int_6, 20));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 1 | U.smethod_0(this.int_7, 31));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 7 | U.smethod_0(this.int_8, 25));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 16 | U.smethod_0(this.int_9, 16));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 8 | U.smethod_0(this.int_10, 24));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 1) | this.int_11 << 31);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (U.smethod_0(this.int_12, 5) | this.int_12 << 27);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9862);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_3(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.smethod_3(this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		binaryStream_0.smethod_3(this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		binaryStream_0.smethod_3(U.smethod_0(this.int_4, 14) | this.int_4 << 18);
		binaryStream_0.smethod_6(24798);
		binaryStream_0.smethod_6(2608);
		binaryStream_0.smethod_3(U.smethod_0(this.int_5, 7) | this.int_5 << 25);
		binaryStream_0.smethod_3(U.smethod_0(this.int_6, 12) | this.int_6 << 20);
		binaryStream_0.smethod_3(U.smethod_0(this.int_7, 1) | this.int_7 << 31);
		binaryStream_0.smethod_3(U.smethod_0(this.int_8, 7) | this.int_8 << 25);
		binaryStream_0.smethod_3(U.smethod_0(this.int_9, 16) | this.int_9 << 16);
		binaryStream_0.smethod_3(U.smethod_0(this.int_10, 8) | this.int_10 << 24);
		binaryStream_0.smethod_3(this.int_11 << 1 | U.smethod_0(this.int_11, 31));
		binaryStream_0.smethod_3(this.int_12 << 5 | U.smethod_0(this.int_12, 27));
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

	public int int_9;

	public int int_10;

	public int int_11;

	public int int_12;
}
