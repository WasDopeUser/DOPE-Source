using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass405 : GClass403, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12740;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass405(GClass606 gclass606_2 = null, GClass606 gclass606_3 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass606_2 == null)
		{
			this.gclass606_1 = new GClass606("", 0.0);
		}
		else
		{
			this.gclass606_1 = gclass606_2;
		}
		if (gclass606_3 == null)
		{
			this.gclass606_0 = new GClass606("", 0.0);
			return;
		}
		this.gclass606_0 = gclass606_3;
	}

	public override int vmethod_0()
	{
		return 12740;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.gclass606_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass606);
		this.gclass606_0.HrqIugnatr8(binaryStream_0);
		this.gclass606_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass606);
		this.gclass606_1.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12740);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass606_0.imethod_1(binaryStream_0);
		this.gclass606_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-29874);
		binaryStream_0.smethod_7(-32134);
	}

	public GClass606 gclass606_0;

	public GClass606 gclass606_1;
}
