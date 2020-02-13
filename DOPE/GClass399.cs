using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass399 : GClass397, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16408;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass399(GClass591 gclass591_2 = null, GClass591 gclass591_3 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass591_2 == null)
		{
			this.gclass591_0 = new GClass591("", 0.0);
		}
		else
		{
			this.gclass591_0 = gclass591_2;
		}
		if (gclass591_3 == null)
		{
			this.gclass591_1 = new GClass591("", 0.0);
			return;
		}
		this.gclass591_1 = gclass591_3;
	}

	public override int vmethod_0()
	{
		return 16408;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass591_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass591);
		this.gclass591_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass591_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass591);
		this.gclass591_1.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16408);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass591_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(16705);
		this.gclass591_1.imethod_2(binaryStream_0);
	}

	public GClass591 gclass591_0;

	public GClass591 gclass591_1;
}
