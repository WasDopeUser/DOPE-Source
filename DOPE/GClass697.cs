using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass697 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4057;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass697(GClass776 gclass776_1 = null, string string_1 = "")
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
		return 4057;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass776_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass776);
		this.gclass776_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4057);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		this.gclass776_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(10624);
	}

	public string string_0;

	public GClass776 gclass776_0;
}
