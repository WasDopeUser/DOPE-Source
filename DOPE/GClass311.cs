using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass311 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23580;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass311(GClass202 gclass202_2 = null, GClass202 gclass202_3 = null, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
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
		this.int_0 = int_4;
		this.int_3 = int_5;
		this.int_2 = int_6;
		this.int_1 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 23580;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		binaryStream_0.smethod_1();
		this.gclass202_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_1.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23580);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass202_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.smethod_7(20767);
		this.gclass202_1.imethod_1(binaryStream_0);
	}

	public GClass202 gclass202_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public GClass202 gclass202_1;
}
