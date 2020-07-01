using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass824 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 56;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass824(int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_13;
		this.int_1 = int_14;
		this.int_2 = int_15;
		this.int_3 = int_16;
		this.int_4 = int_17;
		this.int_5 = int_18;
		this.int_6 = int_19;
		this.int_7 = int_20;
		this.int_8 = int_21;
		this.int_9 = int_22;
		this.int_10 = int_23;
		this.int_11 = int_24;
		this.int_12 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 56;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 10) | this.int_4 << 22);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 2 | U.smethod_0(this.int_5, 30));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 16 | U.smethod_0(this.int_6, 16));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 3 | U.smethod_0(this.int_7, 29));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 8) | this.int_8 << 24);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 11 | U.smethod_0(this.int_9, 21));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 16 | U.smethod_0(this.int_10, 16));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 1) | this.int_11 << 31);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 4 | U.smethod_0(this.int_12, 28));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(56);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		binaryStream_0.smethod_4(this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		binaryStream_0.smethod_4(this.int_4 << 10 | U.smethod_0(this.int_4, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 2) | this.int_5 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 16) | this.int_6 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 3) | this.int_7 << 29);
		binaryStream_0.smethod_4(this.int_8 << 8 | U.smethod_0(this.int_8, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 11) | this.int_9 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_10, 16) | this.int_10 << 16);
		binaryStream_0.smethod_4(this.int_11 << 1 | U.smethod_0(this.int_11, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_12, 4) | this.int_12 << 28);
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
