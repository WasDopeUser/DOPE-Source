using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass275 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 133;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass275(GClass188 gclass188_1 = null, GClass135 gclass135_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass188_1 == null)
		{
			this.gclass188_0 = new GClass188(0);
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
		return 133;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass188_0 = (GClass188)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass188_0 != null)
		{
			this.gclass188_0.imethod_1(binaryStream_0);
		}
		this.gclass135_0 = (GClass135)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass135_0 != null)
		{
			this.gclass135_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(133);
		if (this.gclass188_0 != null)
		{
			this.gclass188_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass135_0 != null)
		{
			this.gclass135_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass188 gclass188_0;

	public GClass135 gclass135_0;
}
