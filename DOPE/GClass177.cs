using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass177 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16290;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass177(GClass175 gclass175_1 = null, GClass542 gclass542_1 = null, GClass431 gclass431_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass175_1 == null)
		{
			this.gclass175_0 = new GClass175(null);
		}
		else
		{
			this.gclass175_0 = gclass175_1;
		}
		if (gclass542_1 == null)
		{
			this.gclass542_0 = new GClass542(false, false, false, false);
		}
		else
		{
			this.gclass542_0 = gclass542_1;
		}
		if (gclass431_1 == null)
		{
			this.gclass431_0 = new GClass431(false);
			return;
		}
		this.gclass431_0 = gclass431_1;
	}

	public virtual int vmethod_0()
	{
		return 16290;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass175_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass175);
		this.gclass175_0.imethod_1(binaryStream_0);
		this.gclass542_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass542);
		this.gclass542_0.imethod_1(binaryStream_0);
		this.gclass431_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass431);
		this.gclass431_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16290);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass175_0.imethod_2(binaryStream_0);
		this.gclass542_0.imethod_2(binaryStream_0);
		this.gclass431_0.imethod_2(binaryStream_0);
	}

	public GClass175 gclass175_0;

	public GClass542 gclass542_0;

	public GClass431 gclass431_0;
}
