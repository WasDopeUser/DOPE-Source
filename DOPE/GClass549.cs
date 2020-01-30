using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass549 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7886;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass549(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_7 = int_10;
		this.int_0 = int_11;
		this.int_3 = int_12;
		this.int_6 = int_13;
		this.int_8 = int_14;
		this.int_1 = int_15;
		this.int_4 = int_16;
		this.int_9 = int_17;
		this.int_2 = int_18;
		this.int_5 = int_19;
	}

	public virtual int vmethod_0()
	{
		return 7886;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 13) | this.int_3 << 19);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 2) | this.int_5 << 30);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 14) | this.int_6 << 18);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 11 | U.smethod_0(this.int_7, 21));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 4 | U.smethod_0(this.int_8, 28));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 12) | this.int_9 << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7886);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		binaryStream_0.smethod_4(this.int_3 << 13 | U.smethod_0(this.int_3, 19));
		binaryStream_0.smethod_4(this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		binaryStream_0.smethod_4(this.int_5 << 2 | U.smethod_0(this.int_5, 30));
		binaryStream_0.smethod_4(this.int_6 << 14 | U.smethod_0(this.int_6, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 11) | this.int_7 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 4) | this.int_8 << 28);
		binaryStream_0.smethod_4(this.int_9 << 12 | U.smethod_0(this.int_9, 20));
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
