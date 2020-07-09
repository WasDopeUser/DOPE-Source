using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass475 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2017;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass475(GClass491 gclass491_0 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass491_0 == null)
		{
			this.tEmGaGxrnq = new GClass491(0, null, null, null, null, "", "");
			return;
		}
		this.tEmGaGxrnq = gclass491_0;
	}

	public virtual int vmethod_0()
	{
		return 2017;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.tEmGaGxrnq = (GClass491)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.tEmGaGxrnq != null)
		{
			this.tEmGaGxrnq.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2017);
		if (this.tEmGaGxrnq != null)
		{
			this.tEmGaGxrnq.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass491 tEmGaGxrnq;
}
