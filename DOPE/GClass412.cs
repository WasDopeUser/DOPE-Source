using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass412 : GClass409, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14383;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass412(int int_1 = 0, GClass371 gclass371_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_1;
		if (gclass371_1 == null)
		{
			this.gclass371_0 = new GClass371(false);
			return;
		}
		this.gclass371_0 = gclass371_1;
	}

	public override int vmethod_0()
	{
		return 14383;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.gclass371_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass371);
		this.gclass371_0.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14383);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass371_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_7(6843);
	}

	public GClass371 gclass371_0;

	public int int_0;
}
