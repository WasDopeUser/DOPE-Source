using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass233 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13575;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass233(GClass500 gclass500_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass500_1 == null)
		{
			this.gclass500_0 = new GClass500();
			return;
		}
		this.gclass500_0 = gclass500_1;
	}

	public virtual int vmethod_0()
	{
		return 13575;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass500_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13575);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9595);
		this.gclass500_0.imethod_1(binaryStream_0);
	}

	public GClass500 gclass500_0;
}
