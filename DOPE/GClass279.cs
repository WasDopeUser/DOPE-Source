using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass279 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1053;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass279(GClass188 gclass188_1 = null, GClass135 gclass135_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass188_1 == null)
		{
			this.gclass188_0 = new GClass188(0U);
		}
		else
		{
			this.gclass188_0 = gclass188_1;
		}
		if (gclass135_1 == null)
		{
			this.gclass135_0 = new GClass135(null, 0.0);
			return;
		}
		this.gclass135_0 = gclass135_1;
	}

	public virtual int vmethod_0()
	{
		return 1053;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass135_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass135);
		this.gclass135_0.HrqIugnatr8(binaryStream_0);
		this.gclass188_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass188);
		this.gclass188_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1053);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3713);
		this.gclass135_0.imethod_1(binaryStream_0);
		this.gclass188_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(15892);
	}

	public GClass135 gclass135_0;

	public GClass188 gclass188_0;
}
