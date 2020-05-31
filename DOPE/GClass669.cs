using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass669 : GClass667, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 894;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass669(GClass202 gclass202_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
			return;
		}
		this.gclass202_0 = gclass202_1;
	}

	public override int vmethod_0()
	{
		return 894;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(894);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass202_0.imethod_1(binaryStream_0);
	}

	public GClass202 gclass202_0;
}
