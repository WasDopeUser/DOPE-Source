using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass777 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27613;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass777(int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_13;
		this.int_11 = int_14;
		this.int_7 = int_15;
		this.int_9 = int_16;
		this.int_2 = int_17;
		this.int_6 = int_18;
		this.int_5 = int_19;
		this.int_4 = int_20;
		this.int_10 = int_21;
		this.int_12 = int_22;
		this.int_8 = int_23;
		this.int_3 = int_24;
		this.int_1 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 27613;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 1 | U.smethod_0(this.int_4, 31));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 5 | U.smethod_0(this.int_5, 27));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 12 | U.smethod_0(this.int_6, 20));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 8 | U.smethod_0(this.int_7, 24));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 9) | this.int_8 << 23);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 12 | U.smethod_0(this.int_9, 20));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 6 | U.smethod_0(this.int_10, 26));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 5) | this.int_11 << 27);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (U.smethod_0(this.int_12, 1) | this.int_12 << 31);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27613);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 1) | this.int_4 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 5) | this.int_5 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 12) | this.int_6 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 8) | this.int_7 << 24);
		binaryStream_0.smethod_4(this.int_8 << 9 | U.smethod_0(this.int_8, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 12) | this.int_9 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_10, 6) | this.int_10 << 26);
		binaryStream_0.smethod_4(this.int_11 << 5 | U.smethod_0(this.int_11, 27));
		binaryStream_0.smethod_4(this.int_12 << 1 | U.smethod_0(this.int_12, 31));
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
