using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass289 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 69;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass289(GClass432 gclass432_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass432_1 == null)
		{
			this.gclass432_0 = new GClass432(0);
			return;
		}
		this.gclass432_0 = gclass432_1;
	}

	public virtual int vmethod_0()
	{
		return 69;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass432_0 = (GClass432)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass432_0 != null)
		{
			this.gclass432_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(69);
		if (this.gclass432_0 != null)
		{
			this.gclass432_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass432 gclass432_0;
}
