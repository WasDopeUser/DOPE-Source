using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass302 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16950;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass302(int int_6 = 0, uint uint_1 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_6;
		this.uint_0 = uint_1;
		this.int_3 = int_7;
		this.int_2 = int_8;
		this.int_4 = int_9;
		this.int_1 = int_10;
		this.int_5 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 16950;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 11) | this.int_5 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(16950);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_5(-22122);
		binaryStream_0.smethod_5(14374);
		binaryStream_0.fUeiimuocMk(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.fUeiimuocMk(this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		binaryStream_0.fUeiimuocMk(this.int_4 << 7 | U.smethod_0(this.int_4, 25));
		binaryStream_0.fUeiimuocMk(this.int_5 << 11 | U.smethod_0(this.int_5, 21));
	}

	public int int_0;

	public int int_1;

	public uint uint_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;
}
