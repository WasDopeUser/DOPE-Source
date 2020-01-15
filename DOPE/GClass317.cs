using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass317 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3428;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass317(string string_2 = "", string string_3 = "", GClass334 gclass334_1 = null)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass334_1 == null)
		{
			this.gclass334_0 = new GClass334(0U);
			return;
		}
		this.gclass334_0 = gclass334_1;
	}

	public virtual int vmethod_0()
	{
		return 3428;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass334_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass334);
		this.gclass334_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3428);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass334_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(5028);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(-23835);
	}

	public GClass334 gclass334_0;

	public string string_0;

	public string string_1;
}
