using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass368 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12490;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass368(int int_13 = 0, int int_14 = 0, int int_15 = 0, uint uint_1 = 0U, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, string string_1 = "", int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.int_11 = int_13;
		this.int_3 = int_14;
		this.int_0 = int_15;
		this.uint_0 = uint_1;
		this.int_7 = int_16;
		this.int_12 = int_17;
		this.int_2 = int_18;
		this.int_6 = int_19;
		this.int_9 = int_20;
		this.string_0 = string_1;
		this.int_5 = int_21;
		this.int_4 = int_22;
		this.int_10 = int_23;
		this.int_8 = int_24;
		this.int_1 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 12490;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 16 | U.smethod_0(this.int_4, 16));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 16 | U.smethod_0(this.int_6, 16));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 3 | U.smethod_0(this.int_7, 29));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 2) | this.int_8 << 30);
		binaryStream_0.smethod_1();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 15) | this.int_9 << 17);
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 14) | this.int_10 << 18);
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 1) | this.int_11 << 31);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 14 | U.smethod_0(this.int_12, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(12490);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		binaryStream_0.smethod_3(U.smethod_0(this.int_4, 16) | this.int_4 << 16);
		binaryStream_0.smethod_3(U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		binaryStream_0.smethod_3(U.smethod_0(this.int_6, 16) | this.int_6 << 16);
		binaryStream_0.smethod_3(U.smethod_0(this.int_7, 3) | this.int_7 << 29);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.int_8 << 2 | U.smethod_0(this.int_8, 30));
		binaryStream_0.smethod_6(-24652);
		binaryStream_0.smethod_3(this.int_9 << 15 | U.smethod_0(this.int_9, 17));
		binaryStream_0.smethod_3(this.int_10 << 14 | U.smethod_0(this.int_10, 18));
		binaryStream_0.smethod_3(this.int_11 << 1 | U.smethod_0(this.int_11, 31));
		binaryStream_0.smethod_3(U.smethod_0(this.int_12, 14) | this.int_12 << 18);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public uint uint_0;

	public string string_0;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int int_12;
}
