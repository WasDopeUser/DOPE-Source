using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass182 : GClass180, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18284;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass182(string string_1 = "", int int_2 = 0, int int_3 = 0, GClass265 gclass265_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(string_1, int_2, int_3);
		if (gclass265_1 == null)
		{
			this.gclass265_0 = new GClass265(0U);
			return;
		}
		this.gclass265_0 = gclass265_1;
	}

	public override int vmethod_0()
	{
		return 18284;
	}

	public override int vmethod_1()
	{
		return 20;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.gclass265_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass265);
		this.gclass265_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18284);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass265_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(30308);
	}

	public GClass265 gclass265_0;
}
