using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass357 : GClass356, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24239;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass357(GClass435 gclass435_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass435_1 == null)
		{
			this.gclass435_0 = new GClass435(0U, "", null, null);
			return;
		}
		this.gclass435_0 = gclass435_1;
	}

	public override int vmethod_0()
	{
		return 24239;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass435_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass435);
		this.gclass435_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24239);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass435_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(3251);
		binaryStream_0.smethod_6(1471);
	}

	public GClass435 gclass435_0;
}
