using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass550 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30284;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass550(int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.jXpyofyQp1 = int_9;
		this.int_4 = int_10;
		this.int_0 = int_11;
		this.int_5 = int_12;
		this.int_1 = int_13;
		this.int_7 = int_14;
		this.int_2 = int_15;
		this.int_6 = int_16;
		this.int_3 = int_17;
		this.int_8 = int_18;
	}

	public virtual int vmethod_0()
	{
		return 30284;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.jXpyofyQp1 = binaryStream_0.smethod_0();
		this.jXpyofyQp1 = (this.jXpyofyQp1 << 14 | U.smethod_0(this.jXpyofyQp1, 18));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 2) | this.int_4 << 30);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 2) | this.int_5 << 30);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 2) | this.int_6 << 30);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 16) | this.int_7 << 16);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 13) | this.int_8 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30284);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_3(U.smethod_0(this.jXpyofyQp1, 14) | this.jXpyofyQp1 << 18);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		binaryStream_0.smethod_3(this.int_4 << 2 | U.smethod_0(this.int_4, 30));
		binaryStream_0.smethod_3(this.int_5 << 2 | U.smethod_0(this.int_5, 30));
		binaryStream_0.smethod_3(this.int_6 << 2 | U.smethod_0(this.int_6, 30));
		binaryStream_0.smethod_3(this.int_7 << 16 | U.smethod_0(this.int_7, 16));
		binaryStream_0.smethod_3(this.int_8 << 13 | U.smethod_0(this.int_8, 19));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int jXpyofyQp1;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;
}
