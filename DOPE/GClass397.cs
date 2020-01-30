using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass397 : GClass395, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14841;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass397(GClass590 gclass590_2 = null, GClass590 gclass590_3 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass590_2 == null)
		{
			this.gclass590_0 = new GClass590("", 0.0);
		}
		else
		{
			this.gclass590_0 = gclass590_2;
		}
		if (gclass590_3 == null)
		{
			this.gclass590_1 = new GClass590("", 0.0);
			return;
		}
		this.gclass590_1 = gclass590_3;
	}

	public override int vmethod_0()
	{
		return 14841;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass590_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass590);
		this.gclass590_0.imethod_1(binaryStream_0);
		this.gclass590_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass590);
		this.gclass590_1.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14841);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass590_0.imethod_2(binaryStream_0);
		this.gclass590_1.imethod_2(binaryStream_0);
	}

	public GClass590 gclass590_0;

	public GClass590 gclass590_1;
}
