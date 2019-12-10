using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass753 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26299;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass753(int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_13;
		this.int_9 = int_14;
		this.int_12 = int_15;
		this.int_8 = int_16;
		this.int_7 = int_17;
		this.int_11 = int_18;
		this.int_3 = int_19;
		this.int_2 = int_20;
		this.int_5 = int_21;
		this.int_1 = int_22;
		this.int_4 = int_23;
		this.int_10 = int_24;
		this.int_6 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 26299;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 2 | U.smethod_0(this.int_4, 30));
		binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 7 | U.smethod_0(this.int_5, 25));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 15) | this.int_6 << 17);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 2) | this.int_7 << 30);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 4 | U.smethod_0(this.int_8, 28));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 9 | U.smethod_0(this.int_9, 23));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 3 | U.smethod_0(this.int_10, 29));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 12) | this.int_11 << 20);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 13 | U.smethod_0(this.int_12, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(26299);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.fUeiimuocMk(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.fUeiimuocMk(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 2) | this.int_4 << 30);
		binaryStream_0.smethod_5(7963);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 7) | this.int_5 << 25);
		binaryStream_0.fUeiimuocMk(this.int_6 << 15 | U.smethod_0(this.int_6, 17));
		binaryStream_0.fUeiimuocMk(this.int_7 << 2 | U.smethod_0(this.int_7, 30));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_8, 4) | this.int_8 << 28);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_9, 9) | this.int_9 << 23);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_10, 3) | this.int_10 << 29);
		binaryStream_0.fUeiimuocMk(this.int_11 << 12 | U.smethod_0(this.int_11, 20));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_12, 13) | this.int_12 << 19);
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
