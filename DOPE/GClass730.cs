using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass730 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11810;
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
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_7 = int_10;
		this.int_0 = int_11;
		this.int_1 = int_12;
		this.int_4 = int_13;
		this.int_2 = int_14;
		this.int_9 = int_15;
		this.int_3 = int_16;
		this.int_5 = int_17;
		this.int_6 = int_18;
		this.int_8 = int_19;
	}

	public virtual int vmethod_0()
	{
		return 11810;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 2) | this.int_3 << 30);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 6) | this.int_4 << 26);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 13) | this.int_6 << 19);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 5 | U.smethod_0(this.int_7, 27));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 6 | U.smethod_0(this.int_8, 26));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 8 | U.smethod_0(this.int_9, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11810);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_4(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		binaryStream_0.smethod_4(this.int_3 << 2 | U.smethod_0(this.int_3, 30));
		binaryStream_0.smethod_4(this.int_4 << 6 | U.smethod_0(this.int_4, 26));
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		binaryStream_0.smethod_4(this.int_6 << 13 | U.smethod_0(this.int_6, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 5) | this.int_7 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 6) | this.int_8 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 8) | this.int_9 << 24);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public uint uint_0;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;
}
