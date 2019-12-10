using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass700 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9517;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass700(GClass191 gclass191_1 = null, GClass459 gclass459_1 = null, double double_1 = 0.0)
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
		if (gclass459_1 == null)
		{
			this.gclass459_0 = new GClass459(0U);
		}
		else
		{
			this.gclass459_0 = gclass459_1;
		}
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 9517;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_8();
		binaryStream_0.smethod_1();
		this.gclass459_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass459);
		this.gclass459_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(9517);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.smethod_5(-31473);
		this.gclass459_0.imethod_2(binaryStream_0);
	}

	public GClass191 gclass191_0;

	public double double_0;

	public GClass459 gclass459_0;
}
