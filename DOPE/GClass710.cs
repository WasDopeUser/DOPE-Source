using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass710 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21177;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass710(GClass201 gclass201_1 = null, GClass473 gclass473_1 = null, double double_1 = 0.0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass473_1 == null)
		{
			this.gclass473_0 = new GClass473(0U);
		}
		else
		{
			this.gclass473_0 = gclass473_1;
		}
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 21177;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.gclass473_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass473);
		this.gclass473_0.imethod_1(binaryStream_0);
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21177);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_9(this.double_0);
		this.gclass473_0.imethod_2(binaryStream_0);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(5955);
	}

	public double double_0;

	public GClass473 gclass473_0;

	public GClass201 gclass201_0;
}
