using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass406 : GClass403, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21800;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass406(int int_1 = 0, GClass365 gclass365_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
		if (gclass365_1 == null)
		{
			this.gclass365_0 = new GClass365(false);
			return;
		}
		this.gclass365_0 = gclass365_1;
	}

	public override int vmethod_0()
	{
		return 21800;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.gclass365_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass365);
		this.gclass365_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21800);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.gclass365_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass365 gclass365_0;
}
