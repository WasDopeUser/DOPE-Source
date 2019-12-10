using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass290 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18771;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass290(GClass191 gclass191_2 = null, GClass191 gclass191_3 = null, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
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
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.int_0 = int_6;
		this.int_3 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 18771;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.gclass191_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_1.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 8 | U.smethod_0(this.int_3, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(18771);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.gclass191_0.imethod_2(binaryStream_0);
		this.gclass191_1.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 8) | this.int_3 << 24);
	}

	public int int_0;

	public GClass191 gclass191_0;

	public GClass191 gclass191_1;

	public int int_1;

	public int int_2;

	public int int_3;
}
