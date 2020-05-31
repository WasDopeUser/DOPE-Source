using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass316 : GClass314, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28835;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass316(GClass139 gclass139_1 = null)
	{
		Class13.NP5bWyNzLwONS();
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
		return 28835;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28835);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass139_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-16903);
	}

	public GClass139 gclass139_0;
}
