using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass232 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30718;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass232(GClass489 gclass489_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass489_1 == null)
		{
			this.gclass489_0 = new GClass489();
			return;
		}
		this.gclass489_0 = gclass489_1;
	}

	public virtual int vmethod_0()
	{
		return 30718;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass489_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass489);
		this.gclass489_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30718);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass489_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(11120);
	}

	public GClass489 gclass489_0;
}
