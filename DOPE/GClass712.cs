using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass712 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5630;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass712(GClass201 gclass201_1 = null, GClass474 gclass474_1 = null, double double_1 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass474_1 == null)
		{
			this.gclass474_0 = new GClass474(0U);
		}
		else
		{
			this.gclass474_0 = gclass474_1;
		}
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 5630;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_9();
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass474_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass474);
		this.gclass474_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5630);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_8(this.double_0);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(166);
		this.gclass474_0.imethod_2(binaryStream_0);
	}

	public double double_0;

	public GClass201 gclass201_0;

	public GClass474 gclass474_0;
}
