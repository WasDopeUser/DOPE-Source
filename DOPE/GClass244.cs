using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass244 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24365;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass244(GClass243 gclass243_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass243_1 == null)
		{
			this.gclass243_0 = new GClass243(0.0, "", 0.0, 0, false, 0.0, null);
			return;
		}
		this.gclass243_0 = gclass243_1;
	}

	public virtual int vmethod_0()
	{
		return 24365;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass243_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass243);
		this.gclass243_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24365);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-26752);
		this.gclass243_0.imethod_2(binaryStream_0);
	}

	public GClass243 gclass243_0;
}
