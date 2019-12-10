using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass536 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1924;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass536(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_4 = int_10;
		this.int_0 = int_11;
		this.int_6 = int_12;
		this.int_5 = int_13;
		this.int_8 = int_14;
		this.int_7 = int_15;
		this.int_9 = int_16;
		this.int_1 = int_17;
		this.int_2 = int_18;
		this.int_3 = int_19;
	}

	public virtual int vmethod_0()
	{
		return 1924;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 14 | U.smethod_0(this.int_3, 18));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 7 | U.smethod_0(this.int_4, 25));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 9) | this.int_6 << 23);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 14 | U.smethod_0(this.int_7, 18));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 12) | this.int_8 << 20);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 6 | U.smethod_0(this.int_9, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(1924);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(9572);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.fUeiimuocMk(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_5(3373);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 14) | this.int_3 << 18);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		binaryStream_0.fUeiimuocMk(this.int_6 << 9 | U.smethod_0(this.int_6, 23));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_7, 14) | this.int_7 << 18);
		binaryStream_0.fUeiimuocMk(this.int_8 << 12 | U.smethod_0(this.int_8, 20));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_9, 6) | this.int_9 << 26);
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
