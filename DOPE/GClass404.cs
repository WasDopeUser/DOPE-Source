using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass404 : GClass403, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24530;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass404(GClass705 gclass705_1 = null, GClass637 gclass637_1 = null, GClass542 gclass542_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass705_1 == null)
		{
			this.gclass705_0 = new GClass705(0, 0, 0, 0.0);
		}
		else
		{
			this.gclass705_0 = gclass705_1;
		}
		if (gclass637_1 == null)
		{
			this.gclass637_0 = new GClass637(null);
		}
		else
		{
			this.gclass637_0 = gclass637_1;
		}
		if (gclass542_1 == null)
		{
			this.gclass542_0 = new GClass542("", 0.0, null);
			return;
		}
		this.gclass542_0 = gclass542_1;
	}

	public override int vmethod_0()
	{
		return 24530;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass637_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass637);
		this.gclass637_0.imethod_1(binaryStream_0);
		this.gclass705_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass705);
		this.gclass705_0.imethod_1(binaryStream_0);
		this.gclass542_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass542);
		this.gclass542_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24530);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-17323);
		this.gclass637_0.imethod_2(binaryStream_0);
		this.gclass705_0.imethod_2(binaryStream_0);
		this.gclass542_0.imethod_2(binaryStream_0);
	}

	public GClass637 gclass637_0;

	public GClass705 gclass705_0;

	public GClass542 gclass542_0;
}
