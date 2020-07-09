using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass746 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4715;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass746(GClass848 gclass848_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass848_1 == null)
		{
			this.gclass848_0 = new GClass848(0);
			return;
		}
		this.gclass848_0 = gclass848_1;
	}

	public virtual int vmethod_0()
	{
		return 4715;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass848_0 = (GClass848)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass848_0 != null)
		{
			this.gclass848_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4715);
		if (this.gclass848_0 != null)
		{
			this.gclass848_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass848 gclass848_0;
}
