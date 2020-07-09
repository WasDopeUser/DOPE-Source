using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass242 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -11531;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass242(GClass241 gclass241_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass241_1 == null)
		{
			this.gclass241_0 = new GClass241(0.0, "", 0.0, 0, false, 0.0, null);
			return;
		}
		this.gclass241_0 = gclass241_1;
	}

	public virtual int vmethod_0()
	{
		return -11531;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass241_0 = (GClass241)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass241_0 != null)
		{
			this.gclass241_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-11531);
		if (this.gclass241_0 != null)
		{
			this.gclass241_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass241 gclass241_0;
}
