using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass383 : GClass381, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1821;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass383(GClass577 gclass577_2 = null, GClass577 gclass577_3 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass577_2 == null)
		{
			this.gclass577_0 = new GClass577("", 0.0);
		}
		else
		{
			this.gclass577_0 = gclass577_2;
		}
		if (gclass577_3 == null)
		{
			this.gclass577_1 = new GClass577("", 0.0);
			return;
		}
		this.gclass577_1 = gclass577_3;
	}

	public override int vmethod_0()
	{
		return 1821;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass577_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass577);
		this.gclass577_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass577_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass577);
		this.gclass577_1.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(1821);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass577_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-26677);
		this.gclass577_1.imethod_2(binaryStream_0);
	}

	public GClass577 gclass577_0;

	public GClass577 gclass577_1;
}
