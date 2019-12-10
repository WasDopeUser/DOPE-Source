using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass295 : GClass293, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30748;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass295(GClass135 gclass135_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass135_1 == null)
		{
			this.gclass135_0 = new GClass135(0U);
			return;
		}
		this.gclass135_0 = gclass135_1;
	}

	public override int vmethod_0()
	{
		return 30748;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass135_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass135);
		this.gclass135_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(30748);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass135_0.imethod_2(binaryStream_0);
	}

	public GClass135 gclass135_0;
}
