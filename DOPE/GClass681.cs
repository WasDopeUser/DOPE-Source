using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass681 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18181;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass681(GClass761 gclass761_1 = null, string string_1 = "")
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		base..ctor();
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0U);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 18181;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18181);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		this.gclass761_0.imethod_2(binaryStream_0);
	}

	public string string_0;

	public GClass761 gclass761_0;
}
