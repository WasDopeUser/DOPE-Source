using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass281 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3692;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass281(int int_9 = 0, GClass201 gclass201_2 = null, GClass201 gclass201_3 = null, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_6 = int_9;
		if (gclass201_2 == null)
		{
			this.gclass201_1 = new GClass201(0U);
		}
		else
		{
			this.gclass201_1 = gclass201_2;
		}
		if (gclass201_3 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_3;
		}
		this.int_3 = int_10;
		this.int_1 = int_11;
		this.int_0 = int_12;
		this.int_8 = int_13;
		this.int_7 = int_14;
		this.int_4 = int_15;
		this.int_5 = int_16;
		this.int_2 = int_17;
	}

	public virtual int vmethod_0()
	{
		return 3692;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.gclass201_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_1.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 14) | this.int_3 << 18);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 10) | this.int_4 << 22);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 4) | this.int_5 << 28);
		binaryStream_0.smethod_1();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 7) | this.int_6 << 25);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 10 | U.smethod_0(this.int_7, 22));
		binaryStream_0.smethod_1();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 13) | this.int_8 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3692);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass201_0.imethod_2(binaryStream_0);
		this.gclass201_1.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_4(this.int_3 << 14 | U.smethod_0(this.int_3, 18));
		binaryStream_0.smethod_4(this.int_4 << 10 | U.smethod_0(this.int_4, 22));
		binaryStream_0.smethod_4(this.int_5 << 4 | U.smethod_0(this.int_5, 28));
		binaryStream_0.smethod_7(432);
		binaryStream_0.smethod_4(this.int_6 << 7 | U.smethod_0(this.int_6, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 10) | this.int_7 << 22);
		binaryStream_0.smethod_7(-23032);
		binaryStream_0.smethod_4(this.int_8 << 13 | U.smethod_0(this.int_8, 19));
	}

	public GClass201 gclass201_0;

	public GClass201 gclass201_1;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;
}
