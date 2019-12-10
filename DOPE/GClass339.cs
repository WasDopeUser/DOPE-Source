using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass339 : GClass338, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12201;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass339(GClass420 gclass420_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass420_1 == null)
		{
			this.gclass420_0 = new GClass420(0U, "", null, null);
			return;
		}
		this.gclass420_0 = gclass420_1;
	}

	public override int vmethod_0()
	{
		return 12201;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass420_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass420);
		this.gclass420_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(12201);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass420_0.imethod_2(binaryStream_0);
	}

	public GClass420 gclass420_0;
}
