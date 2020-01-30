using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass167 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5019;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass167(GClass260 gclass260_1 = null, GClass241 gclass241_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass260_1 == null)
		{
			this.gclass260_0 = new GClass260(0U);
		}
		else
		{
			this.gclass260_0 = gclass260_1;
		}
		if (gclass241_1 == null)
		{
			this.gclass241_0 = new GClass241(0, 0, "", "", 0);
			return;
		}
		this.gclass241_0 = gclass241_1;
	}

	public virtual int vmethod_0()
	{
		return 5019;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass241_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass241);
		this.gclass241_0.imethod_1(binaryStream_0);
		this.gclass260_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass260);
		this.gclass260_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5019);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20509);
		this.gclass241_0.imethod_2(binaryStream_0);
		this.gclass260_0.imethod_2(binaryStream_0);
	}

	public GClass241 gclass241_0;

	public GClass260 gclass260_0;
}
