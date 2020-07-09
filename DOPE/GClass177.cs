using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass177 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29971;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass177(GClass175 gclass175_1 = null, GClass563 gclass563_1 = null, GClass437 gclass437_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass437_1 == null)
		{
			this.gclass437_0 = new GClass437(false);
		}
		else
		{
			this.gclass437_0 = gclass437_1;
		}
		if (gclass175_1 == null)
		{
			this.gclass175_0 = new GClass175(null);
		}
		else
		{
			this.gclass175_0 = gclass175_1;
		}
		if (gclass563_1 == null)
		{
			this.gclass563_0 = new GClass563(false, false, false, false);
			return;
		}
		this.gclass563_0 = gclass563_1;
	}

	public virtual int vmethod_0()
	{
		return 29971;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass437_0 = (GClass437)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass437_0 != null)
		{
			this.gclass437_0.imethod_1(binaryStream_0);
		}
		this.gclass175_0 = (GClass175)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass175_0 != null)
		{
			this.gclass175_0.imethod_1(binaryStream_0);
		}
		this.gclass563_0 = (GClass563)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass563_0 != null)
		{
			this.gclass563_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29971);
		if (this.gclass437_0 != null)
		{
			this.gclass437_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass175_0 != null)
		{
			this.gclass175_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass563_0 != null)
		{
			this.gclass563_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass437 gclass437_0;

	public GClass175 gclass175_0;

	public GClass563 gclass563_0;
}
