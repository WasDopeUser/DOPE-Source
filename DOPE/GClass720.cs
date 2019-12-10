using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass720 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32342;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass720(uint uint_1 = 0U, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_1;
		this.WhZfSivevu = int_9;
		this.int_1 = int_10;
		this.int_2 = int_11;
		this.int_4 = int_12;
		this.int_5 = int_13;
		this.int_7 = int_14;
		this.int_8 = int_15;
		this.int_3 = int_16;
		this.int_0 = int_17;
		this.int_6 = int_18;
	}

	public virtual int vmethod_0()
	{
		return 32342;
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
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 2) | this.int_4 << 30);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 7) | this.int_5 << 25);
		binaryStream_0.smethod_1();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 6) | this.int_6 << 26);
		this.WhZfSivevu = binaryStream_0.smethod_0();
		this.WhZfSivevu = (U.smethod_0(this.WhZfSivevu, 8) | this.WhZfSivevu << 24);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 5) | this.int_7 << 27);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 12 | U.smethod_0(this.int_8, 20));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(32342);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.fUeiimuocMk(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		binaryStream_0.fUeiimuocMk(this.int_4 << 2 | U.smethod_0(this.int_4, 30));
		binaryStream_0.fUeiimuocMk(this.int_5 << 7 | U.smethod_0(this.int_5, 25));
		binaryStream_0.smethod_5(-2054);
		binaryStream_0.fUeiimuocMk(this.int_6 << 6 | U.smethod_0(this.int_6, 26));
		binaryStream_0.fUeiimuocMk(this.WhZfSivevu << 8 | U.smethod_0(this.WhZfSivevu, 24));
		binaryStream_0.fUeiimuocMk(this.int_7 << 5 | U.smethod_0(this.int_7, 27));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_8, 12) | this.int_8 << 20);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int WhZfSivevu;

	public int int_7;

	public int int_8;

	public uint uint_0;
}
