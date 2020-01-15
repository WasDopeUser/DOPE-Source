using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass514 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31557;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass514(GClass498 gclass498_1 = null, GClass453 gclass453_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass498_1 == null)
		{
			this.gclass498_0 = new GClass498(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass498_0 = gclass498_1;
		}
		if (gclass453_1 == null)
		{
			this.gclass453_0 = new GClass453(0, null, 0U, 0U, 0.0, false, null, null);
			return;
		}
		this.gclass453_0 = gclass453_1;
	}

	public virtual int vmethod_0()
	{
		return 31557;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass498_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass498);
		this.gclass498_0.imethod_1(binaryStream_0);
		this.gclass453_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass453);
		this.gclass453_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31557);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass498_0.imethod_2(binaryStream_0);
		this.gclass453_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(17651);
	}

	public GClass498 gclass498_0;

	public GClass453 gclass453_0;
}
