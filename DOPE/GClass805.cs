using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass805 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -4720;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass805(GClass579 gclass579_1 = null, int int_1 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass579_1 == null)
		{
			this.gclass579_0 = new GClass579(null, 0);
		}
		else
		{
			this.gclass579_0 = gclass579_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -4720;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass579_0 = (GClass579)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass579_0 != null)
		{
			this.gclass579_0.imethod_1(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-4720);
		if (this.gclass579_0 != null)
		{
			this.gclass579_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
	}

	public GClass579 gclass579_0;

	public int int_0;
}
