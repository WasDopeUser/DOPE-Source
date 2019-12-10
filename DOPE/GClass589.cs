using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass589 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12159;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass589(GClass247 gclass247_1 = null, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass247_1 == null)
		{
			this.gclass247_0 = new GClass247(0U);
		}
		else
		{
			this.gclass247_0 = gclass247_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 12159;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass247_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass247);
		this.gclass247_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(12159);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass247_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-24686);
		binaryStream_0.fUeiimuocMk(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
	}

	public GClass247 gclass247_0;

	public int int_0;
}
