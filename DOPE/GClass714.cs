using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass714 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27364;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass714(GClass776 gclass776_1 = null, string string_1 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		if (gclass776_1 == null)
		{
			this.gclass776_0 = new GClass776(0U);
		}
		else
		{
			this.gclass776_0 = gclass776_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 27364;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass776_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass776);
		this.gclass776_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27364);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(21315);
		this.gclass776_0.imethod_1(binaryStream_0);
	}

	public string string_0;

	public GClass776 gclass776_0;
}
