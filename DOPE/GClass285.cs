using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass285 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18048;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass285(string string_1 = "", GClass179 gclass179_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass179_1 == null)
		{
			this.gclass179_0 = new GClass179(0, 0U, 0, "", 0, false);
			return;
		}
		this.gclass179_0 = gclass179_1;
	}

	public virtual int vmethod_0()
	{
		return 18048;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass179_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass179);
		this.gclass179_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(18048);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass179_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(2681);
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass179 gclass179_0;

	public string string_0;
}
