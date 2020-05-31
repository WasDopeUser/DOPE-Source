using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass295 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 69;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass295(uint uint_1 = 0U, GClass265 gclass265_1 = null, string string_1 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass265_1 == null)
		{
			this.gclass265_0 = new GClass265(0U);
		}
		else
		{
			this.gclass265_0 = gclass265_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 69;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass265_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass265);
		this.gclass265_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(69);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass265_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-21604);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass265 gclass265_0;

	public uint uint_0;

	public string string_0;
}
