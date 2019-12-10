using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass532 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28189;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass532(GClass191 gclass191_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
		}
		else
		{
			this.gclass191_0 = gclass191_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 28189;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(28189);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
	}

	public int int_0;

	public GClass191 gclass191_0;

	public int int_1;
}
