using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass642 : GClass640, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5704;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass642(GClass191 gclass191_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
			return;
		}
		this.gclass191_0 = gclass191_1;
	}

	public override int vmethod_0()
	{
		return 5704;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5704);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(8251);
		binaryStream_0.smethod_5(-13849);
	}

	public GClass191 gclass191_0;
}
