using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass176 : GInterface0
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

	public GClass176(GClass174 gclass174_1 = null, GClass562 gclass562_1 = null, GClass436 gclass436_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass436_1 == null)
		{
			this.gclass436_0 = new GClass436(false);
		}
		else
		{
			this.gclass436_0 = gclass436_1;
		}
		if (gclass174_1 == null)
		{
			this.gclass174_0 = new GClass174(null);
		}
		else
		{
			this.gclass174_0 = gclass174_1;
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

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass436_0 = (GClass436)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass436_0 != null)
		{
			this.gclass436_0.imethod_1(binaryStream_0);
		}
		this.gclass174_0 = (GClass174)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass174_0 != null)
		{
			this.gclass174_0.imethod_1(binaryStream_0);
		}
		this.gclass562_0 = (GClass562)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass562_0 != null)
		{
			this.gclass562_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29971);
		if (this.gclass436_0 != null)
		{
			this.gclass436_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass174_0 != null)
		{
			this.gclass174_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass562_0 != null)
		{
			this.gclass562_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass436 gclass436_0;

	public GClass174 gclass174_0;

	public GClass562 gclass562_0;
}
