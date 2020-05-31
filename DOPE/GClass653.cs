using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass653 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1113;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass653(GClass647 gclass647_1 = null, string string_1 = "", GClass597 gclass597_1 = null, GClass489 gclass489_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		if (gclass647_1 == null)
		{
			this.gclass647_0 = new GClass647(0U);
		}
		else
		{
			this.gclass647_0 = gclass647_1;
		}
		this.string_0 = string_1;
		if (gclass597_1 == null)
		{
			this.gclass597_0 = new GClass597(0U);
		}
		else
		{
			this.gclass597_0 = gclass597_1;
		}
		if (gclass489_1 == null)
		{
			this.gclass489_0 = new GClass489(false, 0);
			return;
		}
		this.gclass489_0 = gclass489_1;
	}

	public virtual int vmethod_0()
	{
		return 1113;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass597_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass597);
		this.gclass597_0.HrqIugnatr8(binaryStream_0);
		this.gclass489_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass489);
		this.gclass489_0.HrqIugnatr8(binaryStream_0);
		this.gclass647_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass647);
		this.gclass647_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1113);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass597_0.imethod_1(binaryStream_0);
		this.gclass489_0.imethod_1(binaryStream_0);
		this.gclass647_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(17809);
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass597 gclass597_0;

	public GClass489 gclass489_0;

	public GClass647 gclass647_0;

	public string string_0;
}
