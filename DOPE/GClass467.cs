using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass467 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1910;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass467(GClass483 gclass483_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass483_1 == null)
		{
			this.gclass483_0 = new GClass483(0, null, null, null, null, "", "");
			return;
		}
		this.gclass483_0 = gclass483_1;
	}

	public virtual int vmethod_0()
	{
		return 1910;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass483_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass483);
		this.gclass483_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1910);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass483_0.imethod_2(binaryStream_0);
	}

	public GClass483 gclass483_0;
}
