using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass655 : GClass653, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1854;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass655(GClass201 gclass201_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
			return;
		}
		this.gclass201_0 = gclass201_1;
	}

	public override int vmethod_0()
	{
		return 1854;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1854);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass201_0.imethod_2(binaryStream_0);
	}

	public GClass201 gclass201_0;
}
