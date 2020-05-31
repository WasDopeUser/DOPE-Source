using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass564 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2043;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass564(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_1 = int_10;
		this.int_3 = int_11;
		this.int_7 = int_12;
		this.int_4 = int_13;
		this.int_5 = int_14;
		this.int_2 = int_15;
		this.int_6 = int_16;
		this.int_9 = int_17;
		this.int_0 = int_18;
		this.int_8 = int_19;
	}

	public virtual int vmethod_0()
	{
		return 2043;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 6) | this.int_4 << 26);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 5 | U.smethod_0(this.int_6, 27));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 4) | this.int_7 << 28);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 10) | this.int_8 << 22);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 7 | U.smethod_0(this.int_9, 25));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2043);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.smethod_4(this.int_4 << 6 | U.smethod_0(this.int_4, 26));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 5) | this.int_6 << 27);
		binaryStream_0.smethod_4(this.int_7 << 4 | U.smethod_0(this.int_7, 28));
		binaryStream_0.smethod_7(-27406);
		binaryStream_0.smethod_7(-10614);
		binaryStream_0.smethod_4(this.int_8 << 10 | U.smethod_0(this.int_8, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 7) | this.int_9 << 25);
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
