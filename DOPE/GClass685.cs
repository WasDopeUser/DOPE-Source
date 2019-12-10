using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass685 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18498;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass685(GClass504 gclass504_1 = null, GClass587 gclass587_1 = null, GClass377 gclass377_1 = null, GClass691 gclass691_1 = null, GClass268 gclass268_1 = null, GClass402 gclass402_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass504_1 == null)
		{
			this.gclass504_0 = new GClass504(false, 0, 0, 0, false, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass504_0 = gclass504_1;
		}
		if (gclass587_1 == null)
		{
			this.gclass587_0 = new GClass587(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false);
		}
		else
		{
			this.gclass587_0 = gclass587_1;
		}
		if (gclass377_1 == null)
		{
			this.gclass377_0 = new GClass377(false, 0, 0, 0, false);
		}
		else
		{
			this.gclass377_0 = gclass377_1;
		}
		if (gclass691_1 == null)
		{
			this.gclass691_0 = new GClass691(0, "", false);
		}
		else
		{
			this.gclass691_0 = gclass691_1;
		}
		if (gclass268_1 == null)
		{
			this.gclass268_0 = new GClass268(false, false, false, false, false, false, false, false, false, false);
		}
		else
		{
			this.gclass268_0 = gclass268_1;
		}
		if (gclass402_1 == null)
		{
			this.gclass402_0 = new GClass402(false, false, false, false, false, false);
			return;
		}
		this.gclass402_0 = gclass402_1;
	}

	public virtual int vmethod_0()
	{
		return 18498;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass691_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass691);
		this.gclass691_0.imethod_1(binaryStream_0);
		this.gclass268_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass268);
		this.gclass268_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass402_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass402);
		this.gclass402_0.imethod_1(binaryStream_0);
		this.gclass587_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass587);
		this.gclass587_0.imethod_1(binaryStream_0);
		this.gclass377_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass377);
		this.gclass377_0.imethod_1(binaryStream_0);
		this.gclass504_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass504);
		this.gclass504_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(18498);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass691_0.imethod_2(binaryStream_0);
		this.gclass268_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(26826);
		this.gclass402_0.imethod_2(binaryStream_0);
		this.gclass587_0.imethod_2(binaryStream_0);
		this.gclass377_0.imethod_2(binaryStream_0);
		this.gclass504_0.imethod_2(binaryStream_0);
	}

	public GClass691 gclass691_0;

	public GClass268 gclass268_0;

	public GClass402 gclass402_0;

	public GClass587 gclass587_0;

	public GClass377 gclass377_0;

	public GClass504 gclass504_0;
}
