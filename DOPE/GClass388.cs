using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass388 : GClass387, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27206;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass388(GClass693 gclass693_0 = null, GClass624 gclass624_1 = null, GClass528 gclass528_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass693_0 == null)
		{
			this.UofGppJeab = new GClass693(0, 0, 0, 0.0);
		}
		else
		{
			this.UofGppJeab = gclass693_0;
		}
		if (gclass624_1 == null)
		{
			this.gclass624_0 = new GClass624(null);
		}
		else
		{
			this.gclass624_0 = gclass624_1;
		}
		if (gclass528_1 == null)
		{
			this.gclass528_0 = new GClass528("", 0.0, null);
			return;
		}
		this.gclass528_0 = gclass528_1;
	}

	public override int vmethod_0()
	{
		return 27206;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass528_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass528);
		this.gclass528_0.imethod_1(binaryStream_0);
		this.gclass624_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass624);
		this.gclass624_0.imethod_1(binaryStream_0);
		this.UofGppJeab = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass693);
		this.UofGppJeab.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27206);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-23982);
		this.gclass528_0.imethod_2(binaryStream_0);
		this.gclass624_0.imethod_2(binaryStream_0);
		this.UofGppJeab.imethod_2(binaryStream_0);
	}

	public GClass528 gclass528_0;

	public GClass624 gclass624_0;

	public GClass693 UofGppJeab;
}
