using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass267 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29112;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass267(int int_9 = 0, GClass191 gclass191_2 = null, GClass191 gclass191_3 = null, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_8 = int_9;
		if (gclass191_2 == null)
		{
			this.gclass191_1 = new GClass191(0U);
		}
		else
		{
			this.gclass191_1 = gclass191_2;
		}
		if (gclass191_3 == null)
		{
			this.gclass191_0 = new GClass191(0U);
		}
		else
		{
			this.gclass191_0 = gclass191_3;
		}
		this.int_4 = int_10;
		this.int_1 = int_11;
		this.int_5 = int_12;
		this.int_6 = int_13;
		this.int_0 = int_14;
		this.int_3 = int_15;
		this.int_7 = int_16;
		this.int_2 = int_17;
	}

	public virtual int vmethod_0()
	{
		return 29112;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 4) | this.int_4 << 28);
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.gclass191_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_1.imethod_1(binaryStream_0);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 16) | this.int_6 << 16);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 2) | this.int_7 << 30);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 2) | this.int_8 << 30);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(29112);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.fUeiimuocMk(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		binaryStream_0.fUeiimuocMk(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_5(9706);
		binaryStream_0.fUeiimuocMk(this.int_4 << 4 | U.smethod_0(this.int_4, 28));
		this.gclass191_0.imethod_2(binaryStream_0);
		this.gclass191_1.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		binaryStream_0.fUeiimuocMk(this.int_6 << 16 | U.smethod_0(this.int_6, 16));
		binaryStream_0.fUeiimuocMk(this.int_7 << 2 | U.smethod_0(this.int_7, 30));
		binaryStream_0.fUeiimuocMk(this.int_8 << 2 | U.smethod_0(this.int_8, 30));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public GClass191 gclass191_0;

	public GClass191 gclass191_1;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;
}
