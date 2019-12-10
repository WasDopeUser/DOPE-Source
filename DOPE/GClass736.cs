using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass736 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27278;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass736(int int_6 = 0, GClass191 gclass191_1 = null, uint uint_1 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_2 = int_6;
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
		}
		else
		{
			this.gclass191_0 = gclass191_1;
		}
		this.uint_0 = uint_1;
		this.int_0 = int_7;
		this.int_4 = int_8;
		this.int_1 = int_9;
		this.int_5 = int_10;
		this.int_3 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 27278;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_1();
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 10 | U.smethod_0(this.int_4, 22));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 3 | U.smethod_0(this.int_5, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27278);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.fUeiimuocMk(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_5(481);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 10) | this.int_4 << 22);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 3) | this.int_5 << 29);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass191 gclass191_0;

	public uint uint_0;

	public int int_3;

	public int int_4;

	public int int_5;
}
