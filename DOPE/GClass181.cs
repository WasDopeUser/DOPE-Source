using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass181 : GClass179, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7614;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass181(string string_1 = "", int int_2 = 0, int int_3 = 0, GClass261 gclass261_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor(string_1, int_2, int_3);
		if (gclass261_1 == null)
		{
			this.gclass261_0 = new GClass261(0U);
			return;
		}
		this.gclass261_0 = gclass261_1;
	}

	public override int vmethod_0()
	{
		return 7614;
	}

	public override int vmethod_1()
	{
		return 20;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass261_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass261);
		this.gclass261_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7614);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass261_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-28036);
	}

	public GClass261 gclass261_0;
}
