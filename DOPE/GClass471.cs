using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass471 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6241;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass471(GClass630 gclass630_1 = null, string string_1 = "", GClass580 gclass580_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		if (gclass630_1 == null)
		{
			this.gclass630_0 = new GClass630(0U);
		}
		else
		{
			this.gclass630_0 = gclass630_1;
		}
		this.string_0 = string_1;
		if (gclass580_0 == null)
		{
			this.jccginOptl = new GClass580(0U);
			return;
		}
		this.jccginOptl = gclass580_0;
	}

	public virtual int vmethod_0()
	{
		return 6241;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.jccginOptl = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass580);
		this.jccginOptl.imethod_1(binaryStream_0);
		this.gclass630_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass630);
		this.gclass630_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6241);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		this.jccginOptl.imethod_2(binaryStream_0);
		this.gclass630_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(31679);
	}

	public string string_0;

	public GClass580 jccginOptl;

	public GClass630 gclass630_0;
}
