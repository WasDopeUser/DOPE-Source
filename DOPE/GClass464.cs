using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass464 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16625;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass464(GClass763 gclass763_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass763_1 == null)
		{
			this.gclass763_0 = new GClass763(0U);
		}
		else
		{
			this.gclass763_0 = gclass763_1;
		}
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 16625;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_9();
		binaryStream_0.smethod_1();
		this.gclass763_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass763);
		this.gclass763_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.double_1 = (double)binaryStream_0.smethod_9();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16625);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_8(this.double_0);
		binaryStream_0.smethod_6(-23774);
		this.gclass763_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-25495);
		binaryStream_0.smethod_8(this.double_1);
	}

	public double double_0;

	public GClass763 gclass763_0;

	public double double_1;
}
