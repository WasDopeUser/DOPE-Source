using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass624 : GClass622, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21314;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass624()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 21314;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21314);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(28435);
	}
}
