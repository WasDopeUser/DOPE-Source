using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass339 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28354;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass339(GClass467 gclass467_1 = null, GClass491 gclass491_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass467_1 == null)
		{
			this.gclass467_0 = new GClass467(0U);
		}
		else
		{
			this.gclass467_0 = gclass467_1;
		}
		if (gclass491_1 == null)
		{
			this.gclass491_0 = new GClass491(0, null, null, null, null, "", "");
			return;
		}
		this.gclass491_0 = gclass491_1;
	}

	public virtual int vmethod_0()
	{
		return 28354;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass467_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass467);
		this.gclass467_0.HrqIugnatr8(binaryStream_0);
		this.gclass491_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass491);
		this.gclass491_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28354);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16643);
		this.gclass467_0.imethod_1(binaryStream_0);
		this.gclass491_0.imethod_1(binaryStream_0);
	}

	public GClass467 gclass467_0;

	public GClass491 gclass491_0;
}
