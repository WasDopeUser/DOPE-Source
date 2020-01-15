using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass730 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1664;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass730(uint uint_1 = 0U, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_5 = int_10;
		this.int_6 = int_11;
		this.int_4 = int_12;
		this.int_0 = int_13;
		this.int_9 = int_14;
		this.int_2 = int_15;
		this.int_8 = int_16;
		this.int_1 = int_17;
		this.int_7 = int_18;
		this.int_3 = int_19;
	}

	public virtual int vmethod_0()
	{
		return 1664;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 1 | U.smethod_0(this.int_6, 31));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 3 | U.smethod_0(this.int_7, 29));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 3) | this.int_8 << 29);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 11) | this.int_9 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1664);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		binaryStream_0.smethod_4(this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 1) | this.int_6 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 3) | this.int_7 << 29);
		binaryStream_0.smethod_4(this.int_8 << 3 | U.smethod_0(this.int_8, 29));
		binaryStream_0.smethod_4(this.int_9 << 11 | U.smethod_0(this.int_9, 21));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public uint uint_0;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;
}
