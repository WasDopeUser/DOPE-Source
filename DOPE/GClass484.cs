using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass484 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7002;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 32;
		}
	}

	public GClass484(int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_8;
		this.int_1 = int_9;
		this.int_2 = int_10;
		this.int_3 = int_11;
		this.int_4 = int_12;
		this.int_5 = int_13;
		this.int_6 = int_14;
		this.int_7 = int_15;
	}

	public virtual int vmethod_0()
	{
		return 7002;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 7 | U.smethod_0(this.int_4, 25));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 13) | this.int_6 << 19);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 4 | U.smethod_0(this.int_7, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7002);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		binaryStream_0.smethod_4(this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		binaryStream_0.smethod_4(this.int_6 << 13 | U.smethod_0(this.int_6, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 4) | this.int_7 << 28);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;
}
