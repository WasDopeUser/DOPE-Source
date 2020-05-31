using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass478 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7815;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass478(GClass647 gclass647_1 = null, string string_1 = "", GClass597 gclass597_1 = null)
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
			return;
		}
		this.gclass597_0 = gclass597_1;
	}

	public virtual int vmethod_0()
	{
		return 7815;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass647_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass647);
		this.gclass647_0.HrqIugnatr8(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass597_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass597);
		this.gclass597_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7815);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass647_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass597_0.imethod_1(binaryStream_0);
	}

	public GClass647 gclass647_0;

	public string string_0;

	public GClass597 gclass597_0;
}
