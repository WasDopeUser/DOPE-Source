using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass470 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16686;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass470(GClass776 gclass776_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass776_1 == null)
		{
			this.gclass776_0 = new GClass776(0U);
		}
		else
		{
			this.gclass776_0 = gclass776_1;
		}
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 16686;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.gclass776_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass776);
		this.gclass776_0.HrqIugnatr8(binaryStream_0);
		this.double_1 = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16686);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5187);
		binaryStream_0.smethod_9(this.double_0);
		this.gclass776_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_9(this.double_1);
		binaryStream_0.smethod_7(16659);
	}

	public double double_0;

	public GClass776 gclass776_0;

	public double double_1;
}
