using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass368 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6017;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass368(int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, string string_1 = "", int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0, int int_26 = 0)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
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
		this.string_0 = string_1;
		this.int_9 = int_22;
		this.int_10 = int_23;
		this.int_11 = int_24;
		this.int_12 = int_25;
		this.kYlQyCluj2 = int_26;
	}

	public virtual int vmethod_0()
	{
		return 6017;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.int_3 = (int)binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 16) | this.int_4 << 16);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 11) | this.int_6 << 21);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 11 | U.smethod_0(this.int_7, 21));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 13 | U.smethod_0(this.int_8, 19));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 16 | U.smethod_0(this.int_9, 16));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 3) | this.int_10 << 29);
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 6) | this.int_11 << 26);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (U.smethod_0(this.int_12, 4) | this.int_12 << 28);
		this.kYlQyCluj2 = binaryStream_0.smethod_0();
		this.kYlQyCluj2 = (this.kYlQyCluj2 << 1 | U.smethod_0(this.kYlQyCluj2, 31));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6017);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_7(this.int_3);
		binaryStream_0.smethod_4(this.int_4 << 16 | U.smethod_0(this.int_4, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		binaryStream_0.smethod_4(this.int_6 << 11 | U.smethod_0(this.int_6, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 11) | this.int_7 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 13) | this.int_8 << 19);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 16) | this.int_9 << 16);
		binaryStream_0.smethod_4(this.int_10 << 3 | U.smethod_0(this.int_10, 29));
		binaryStream_0.smethod_4(this.int_11 << 6 | U.smethod_0(this.int_11, 26));
		binaryStream_0.smethod_4(this.int_12 << 4 | U.smethod_0(this.int_12, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.kYlQyCluj2, 1) | this.kYlQyCluj2 << 31);
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

	public string string_0;

	public int int_9;

	public int int_10;

	public int int_11;

	public int int_12;

	public int kYlQyCluj2;
}
