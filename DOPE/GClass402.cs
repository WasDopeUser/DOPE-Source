using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass402 : GClass401, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29134;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass402(GClass704 gclass704_1 = null, GClass636 gclass636_1 = null, GClass541 gclass541_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass704_1 == null)
		{
			this.gclass704_0 = new GClass704(0, 0, 0, 0.0);
		}
		else
		{
			this.gclass704_0 = gclass704_1;
		}
		if (gclass636_1 == null)
		{
			this.gclass636_0 = new GClass636(null);
		}
		else
		{
			this.gclass636_0 = gclass636_1;
		}
		if (gclass541_1 == null)
		{
			this.gclass541_0 = new GClass541("", 0.0, null);
			return;
		}
		this.gclass541_0 = gclass541_1;
	}

	public override int vmethod_0()
	{
		return 29134;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass541_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass541);
		this.gclass541_0.imethod_1(binaryStream_0);
		this.gclass636_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass636);
		this.gclass636_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass704_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass704);
		this.gclass704_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29134);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass541_0.imethod_2(binaryStream_0);
		this.gclass636_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-4006);
		this.gclass704_0.imethod_2(binaryStream_0);
	}

	public GClass541 gclass541_0;

	public GClass636 gclass636_0;

	public GClass704 gclass704_0;
}
