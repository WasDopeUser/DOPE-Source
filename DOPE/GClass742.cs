using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass742 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11925;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass742(GClass554 gclass554_1 = null, uint uint_1 = 0U)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass554_1 == null)
		{
			this.gclass554_0 = new GClass554(null, 0U);
		}
		else
		{
			this.gclass554_0 = gclass554_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 11925;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass554_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass554);
		this.gclass554_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11925);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-14520);
		this.gclass554_0.imethod_2(binaryStream_0);
	}

	public uint uint_0;

	public GClass554 gclass554_0;
}
