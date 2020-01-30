using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass355 : GClass354, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29161;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass355(GClass433 gclass433_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass433_1 == null)
		{
			this.gclass433_0 = new GClass433(0U, "", null, null);
			return;
		}
		this.gclass433_0 = gclass433_1;
	}

	public override int vmethod_0()
	{
		return 29161;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass433_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass433);
		this.gclass433_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29161);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(2166);
		binaryStream_0.smethod_7(-1580);
		this.gclass433_0.imethod_2(binaryStream_0);
	}

	public GClass433 gclass433_0;
}
