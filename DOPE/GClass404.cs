using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass404 : GClass401, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6736;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass404(int int_1 = 0, GClass363 gclass363_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_1;
		if (gclass363_1 == null)
		{
			this.gclass363_0 = new GClass363(false);
			return;
		}
		this.gclass363_0 = gclass363_1;
	}

	public override int vmethod_0()
	{
		return 6736;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass363_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass363);
		this.gclass363_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6736);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_7(-22673);
		binaryStream_0.smethod_7(-9344);
		this.gclass363_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass363 gclass363_0;
}
