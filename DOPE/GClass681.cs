using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass681 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6580;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass681(GClass762 gclass762_1 = null, string string_1 = "", int int_0 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		if (gclass762_1 == null)
		{
			this.gclass762_0 = new GClass762(0U);
		}
		else
		{
			this.gclass762_0 = gclass762_1;
		}
		this.string_0 = string_1;
		this.wsBgyssNyn = int_0;
	}

	public virtual int vmethod_0()
	{
		return 6580;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass762_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass762);
		this.gclass762_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.wsBgyssNyn = binaryStream_0.smethod_0();
		this.wsBgyssNyn = (this.wsBgyssNyn << 16 | U.smethod_0(this.wsBgyssNyn, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6580);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass762_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-26208);
		binaryStream_0.smethod_7(-5560);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.wsBgyssNyn, 16) | this.wsBgyssNyn << 16);
	}

	public GClass762 gclass762_0;

	public string string_0;

	public int wsBgyssNyn;
}
