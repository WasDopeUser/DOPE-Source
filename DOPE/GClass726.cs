using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass726 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19441;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass726(GClass202 gclass202_1 = null, GClass480 gclass480_1 = null, double double_1 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
		}
		else
		{
			this.gclass202_0 = gclass202_1;
		}
		if (gclass480_1 == null)
		{
			this.gclass480_0 = new GClass480(0U);
		}
		else
		{
			this.gclass480_0 = gclass480_1;
		}
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 19441;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass480_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass480);
		this.gclass480_0.HrqIugnatr8(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19441);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass480_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_9(this.double_0);
		this.gclass202_0.imethod_1(binaryStream_0);
	}

	public GClass480 gclass480_0;

	public double double_0;

	public GClass202 gclass202_0;
}
