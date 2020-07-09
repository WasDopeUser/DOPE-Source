using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass571 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25375;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass571(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_17;
		this.int_1 = int_16;
		this.int_2 = int_12;
		this.int_3 = int_11;
		this.int_4 = int_15;
		this.int_5 = int_14;
		this.int_6 = int_18;
		this.int_7 = int_19;
		this.int_8 = int_10;
		this.int_9 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 25375;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 13) | this.int_3 << 19);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 7 | U.smethod_0(this.int_5, 25));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 4) | this.int_6 << 28);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 9 | U.smethod_0(this.int_7, 23));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 1 | U.smethod_0(this.int_8, 31));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 11) | this.int_9 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25375);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_4(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_4(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_4(this.int_3 << 13 | U.smethod_0(this.int_3, 19));
		binaryStream_0.smethod_4(this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 7) | this.int_5 << 25);
		binaryStream_0.smethod_4(this.int_6 << 4 | U.smethod_0(this.int_6, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 9) | this.int_7 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 1) | this.int_8 << 31);
		binaryStream_0.smethod_4(this.int_9 << 11 | U.smethod_0(this.int_9, 21));
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
}
