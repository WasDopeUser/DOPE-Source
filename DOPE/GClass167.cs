using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass167 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 255;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass167(GClass259 gclass259_1 = null, GClass239 gclass239_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass259_1 == null)
		{
			this.gclass259_0 = new GClass259(0);
		}
		else
		{
			this.gclass259_0 = gclass259_1;
		}
		if (gclass239_1 == null)
		{
			this.gclass239_0 = new GClass239(0, 0, "", "", 0);
			return;
		}
		this.gclass239_0 = gclass239_1;
	}

	public virtual int vmethod_0()
	{
		return 255;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass259_0 = (GClass259)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_1(binaryStream_0);
		}
		this.gclass239_0 = (GClass239)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass239_0 != null)
		{
			this.gclass239_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(255);
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass239_0 != null)
		{
			this.gclass239_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass259 gclass259_0;

	public GClass239 gclass239_0;
}
