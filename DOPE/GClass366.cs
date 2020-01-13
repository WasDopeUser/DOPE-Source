using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass366 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5072;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass366(int int_13 = 0, int int_14 = 0, int int_15 = 0, uint uint_1 = 0U, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, string string_1 = "", int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		this.int_8 = int_13;
		this.int_1 = int_14;
		this.int_2 = int_15;
		this.uint_0 = uint_1;
		this.int_12 = int_16;
		this.int_4 = int_17;
		this.int_3 = int_18;
		this.int_11 = int_19;
		this.int_7 = int_20;
		this.string_0 = string_1;
		this.int_5 = int_21;
		this.int_0 = int_22;
		this.int_6 = int_23;
		this.int_9 = int_24;
		this.int_10 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 5072;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 14) | this.int_3 << 18);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 8 | U.smethod_0(this.int_5, 24));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 11 | U.smethod_0(this.int_6, 21));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 6) | this.int_7 << 26);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 14) | this.int_8 << 18);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 12 | U.smethod_0(this.int_9, 20));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 10 | U.smethod_0(this.int_10, 22));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (this.int_11 << 6 | U.smethod_0(this.int_11, 26));
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 16 | U.smethod_0(this.int_12, 16));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5072);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.smethod_4(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		binaryStream_0.smethod_7(-20271);
		binaryStream_0.smethod_4(this.int_3 << 14 | U.smethod_0(this.int_3, 18));
		binaryStream_0.smethod_4(this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 8) | this.int_5 << 24);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 11) | this.int_6 << 21);
		binaryStream_0.smethod_4(this.int_7 << 6 | U.smethod_0(this.int_7, 26));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_8 << 14 | U.smethod_0(this.int_8, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 12) | this.int_9 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_10, 10) | this.int_10 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_11, 6) | this.int_11 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_12, 16) | this.int_12 << 16);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public string string_0;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int int_12;

	public uint uint_0;
}
