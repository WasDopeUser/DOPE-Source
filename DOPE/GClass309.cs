using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass309 : GClass307, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10468;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass309(GClass139 gclass139_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0U);
			return;
		}
		this.gclass139_0 = gclass139_1;
	}

	public override int vmethod_0()
	{
		return 10468;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10468);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(21192);
		this.gclass139_0.imethod_2(binaryStream_0);
	}

	public GClass139 gclass139_0;
}
