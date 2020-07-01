using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass543 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 136;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass543(GClass188 gclass188_1 = null, GClass135 gclass135_1 = null)
	{
		Class13.F93tSdiz1aNIA();
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
		return 136;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass188_0 = (GClass188)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass188_0 != null)
		{
			this.gclass188_0.imethod_0(binaryStream_0);
		}
		this.gclass135_0 = (GClass135)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass135_0 != null)
		{
			this.gclass135_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(136);
		if (this.gclass188_0 != null)
		{
			this.gclass188_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass135_0 != null)
		{
			this.gclass135_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass188 gclass188_0;

	public GClass135 gclass135_0;
}
