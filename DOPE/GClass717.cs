using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass717 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 883;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 32;
		}
	}

	public GClass717(int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_7 = int_8;
		this.int_4 = int_9;
		this.int_2 = int_10;
		this.int_6 = int_11;
		this.int_1 = int_12;
		this.int_5 = int_13;
		this.int_3 = int_14;
		this.int_0 = int_15;
	}

	public virtual int vmethod_0()
	{
		return 883;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 3 | U.smethod_0(this.int_4, 29));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 9 | U.smethod_0(this.int_5, 23));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 13) | this.int_6 << 19);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 1) | this.int_7 << 31);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(883);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.fUeiimuocMk(this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 3) | this.int_4 << 29);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 9) | this.int_5 << 23);
		binaryStream_0.fUeiimuocMk(this.int_6 << 13 | U.smethod_0(this.int_6, 19));
		binaryStream_0.fUeiimuocMk(this.int_7 << 1 | U.smethod_0(this.int_7, 31));
		binaryStream_0.smethod_5(-25417);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;
}
