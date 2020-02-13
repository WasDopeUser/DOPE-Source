using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass177 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30655;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass177(GClass175 gclass175_1 = null, GClass544 gclass544_1 = null, GClass432 gclass432_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass175_1 == null)
		{
			this.gclass175_0 = new GClass175(null);
		}
		else
		{
			this.gclass175_0 = gclass175_1;
		}
		if (gclass544_1 == null)
		{
			this.gclass544_0 = new GClass544(false, false, false, false);
		}
		else
		{
			this.gclass544_0 = gclass544_1;
		}
		if (gclass432_1 == null)
		{
			this.gclass432_0 = new GClass432(false);
			return;
		}
		this.gclass432_0 = gclass432_1;
	}

	public virtual int vmethod_0()
	{
		return 30655;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass175_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass175);
		this.gclass175_0.imethod_1(binaryStream_0);
		this.gclass544_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass544);
		this.gclass544_0.imethod_1(binaryStream_0);
		this.gclass432_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass432);
		this.gclass432_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30655);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass175_0.imethod_2(binaryStream_0);
		this.gclass544_0.imethod_2(binaryStream_0);
		this.gclass432_0.imethod_2(binaryStream_0);
	}

	public GClass175 gclass175_0;

	public GClass544 gclass544_0;

	public GClass432 gclass432_0;
}
