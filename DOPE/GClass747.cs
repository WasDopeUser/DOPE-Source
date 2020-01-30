using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass747 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10352;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass747(int int_6 = 0, GClass201 gclass201_1 = null, uint uint_1 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_1 = int_6;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.uint_0 = uint_1;
		this.int_4 = int_7;
		this.int_2 = int_8;
		this.int_5 = int_9;
		this.int_3 = int_10;
		this.int_0 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 10352;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 6) | this.int_4 << 26);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 13 | U.smethod_0(this.int_5, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10352);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_7(22416);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_7(-12776);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.smethod_4(this.int_4 << 6 | U.smethod_0(this.int_4, 26));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 13) | this.int_5 << 19);
	}

	public int int_0;

	public int int_1;

	public uint uint_0;

	public GClass201 gclass201_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;
}
