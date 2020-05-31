using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass285 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23643;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass285(int int_9 = 0, GClass202 gclass202_2 = null, GClass202 gclass202_3 = null, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_5 = int_9;
		if (gclass202_2 == null)
		{
			this.gclass202_0 = new GClass202(0U);
		}
		else
		{
			this.gclass202_0 = gclass202_2;
		}
		if (gclass202_3 == null)
		{
			this.gclass202_1 = new GClass202(0U);
		}
		else
		{
			this.gclass202_1 = gclass202_3;
		}
		this.int_1 = int_10;
		this.int_3 = int_11;
		this.int_8 = int_12;
		this.int_4 = int_13;
		this.int_0 = int_14;
		this.int_7 = int_15;
		this.int_6 = int_16;
		this.int_2 = int_17;
	}

	public virtual int vmethod_0()
	{
		return 23643;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 5 | U.smethod_0(this.int_6, 27));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 11) | this.int_7 << 21);
		binaryStream_0.smethod_1();
		this.gclass202_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_1.HrqIugnatr8(binaryStream_0);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 7 | U.smethod_0(this.int_8, 25));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23643);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		this.gclass202_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		binaryStream_0.smethod_4(this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		binaryStream_0.smethod_4(this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 5) | this.int_6 << 27);
		binaryStream_0.smethod_4(this.int_7 << 11 | U.smethod_0(this.int_7, 21));
		binaryStream_0.smethod_7(-24166);
		this.gclass202_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 7) | this.int_8 << 25);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass202 gclass202_0;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public GClass202 gclass202_1;

	public int int_8;
}
