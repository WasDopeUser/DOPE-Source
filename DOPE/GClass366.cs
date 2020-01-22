using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass366 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11994;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass366(int int_12 = 0, int int_13 = 0, int int_14 = 0, uint uint_1 = 0U, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, string string_1 = "", int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.int_2 = int_12;
		this.int_1 = int_13;
		this.int_7 = int_14;
		this.uint_0 = uint_1;
		this.int_4 = int_15;
		this.qNeublmnry = int_16;
		this.int_9 = int_17;
		this.int_11 = int_18;
		this.int_3 = int_19;
		this.string_0 = string_1;
		this.int_5 = int_20;
		this.int_6 = int_21;
		this.int_8 = int_22;
		this.int_0 = int_23;
		this.int_10 = int_24;
	}

	public virtual int vmethod_0()
	{
		return 11994;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		this.qNeublmnry = binaryStream_0.smethod_0();
		this.qNeublmnry = (U.smethod_0(this.qNeublmnry, 7) | this.qNeublmnry << 25);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 9) | this.int_4 << 23);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 5 | U.smethod_0(this.int_5, 27));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 16) | this.int_6 << 16);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 2) | this.int_7 << 30);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 9 | U.smethod_0(this.int_8, 23));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 15) | this.int_9 << 17);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 6 | U.smethod_0(this.int_10, 26));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 6) | this.int_11 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11994);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.smethod_4(this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		binaryStream_0.smethod_4(this.qNeublmnry << 7 | U.smethod_0(this.qNeublmnry, 25));
		binaryStream_0.smethod_4(this.int_4 << 9 | U.smethod_0(this.int_4, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 5) | this.int_5 << 27);
		binaryStream_0.smethod_4(this.int_6 << 16 | U.smethod_0(this.int_6, 16));
		binaryStream_0.smethod_4(this.int_7 << 2 | U.smethod_0(this.int_7, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 9) | this.int_8 << 23);
		binaryStream_0.smethod_4(this.int_9 << 15 | U.smethod_0(this.int_9, 17));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_10, 6) | this.int_10 << 26);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.int_11 << 6 | U.smethod_0(this.int_11, 26));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int qNeublmnry;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public string string_0;

	public int int_10;

	public uint uint_0;

	public int int_11;
}
