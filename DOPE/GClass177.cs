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

	public GClass177(GClass175 gclass175_1 = null, GClass562 gclass562_1 = null, GClass436 gclass436_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass436_1 == null)
		{
			this.gclass436_0 = new GClass436(false);
		}
		else
		{
			this.gclass436_0 = gclass436_1;
		}
		if (gclass175_1 == null)
		{
			this.gclass175_0 = new GClass175(null);
		}
		else
		{
			this.gclass175_0 = gclass175_1;
		}
		if (gclass562_1 == null)
		{
			this.gclass562_0 = new GClass562(false, false, false, false);
			return;
		}
		this.gclass562_0 = gclass562_1;
	}

	public virtual int vmethod_0()
	{
		return 29971;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass436_0 = (GClass436)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass436_0 != null)
		{
			this.gclass436_0.imethod_0(binaryStream_0);
		}
		this.gclass175_0 = (GClass175)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass175_0 != null)
		{
			this.gclass175_0.imethod_0(binaryStream_0);
		}
		this.gclass562_0 = (GClass562)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass562_0 != null)
		{
			this.gclass562_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29971);
		if (this.gclass436_0 != null)
		{
			this.gclass436_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass175_0 != null)
		{
			this.gclass175_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass562_0 != null)
		{
			this.gclass562_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass436 gclass436_0;

	public GClass175 gclass175_0;

	public GClass562 gclass562_0;
}
