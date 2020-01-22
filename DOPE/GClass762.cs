using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass762 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2796;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass762(int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_13;
		this.int_6 = int_14;
		this.int_8 = int_15;
		this.int_0 = int_16;
		this.int_9 = int_17;
		this.int_2 = int_18;
		this.int_11 = int_19;
		this.int_3 = int_20;
		this.int_5 = int_21;
		this.int_10 = int_22;
		this.int_4 = int_23;
		this.int_12 = int_24;
		this.int_7 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 2796;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 3) | this.int_4 << 29);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 13 | U.smethod_0(this.int_5, 19));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 2 | U.smethod_0(this.int_6, 30));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 4) | this.int_7 << 28);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 9 | U.smethod_0(this.int_8, 23));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 13 | U.smethod_0(this.int_9, 19));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 2) | this.int_10 << 30);
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 13) | this.int_11 << 19);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (U.smethod_0(this.int_12, 14) | this.int_12 << 18);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2796);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		binaryStream_0.smethod_4(this.int_4 << 3 | U.smethod_0(this.int_4, 29));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 13) | this.int_5 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 2) | this.int_6 << 30);
		binaryStream_0.smethod_4(this.int_7 << 4 | U.smethod_0(this.int_7, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 9) | this.int_8 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 13) | this.int_9 << 19);
		binaryStream_0.smethod_4(this.int_10 << 2 | U.smethod_0(this.int_10, 30));
		binaryStream_0.smethod_4(this.int_11 << 13 | U.smethod_0(this.int_11, 19));
		binaryStream_0.smethod_4(this.int_12 << 14 | U.smethod_0(this.int_12, 18));
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
