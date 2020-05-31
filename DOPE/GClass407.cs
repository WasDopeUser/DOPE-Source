using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass407 : GClass403, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9057;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass407()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 9057;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9057);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(2108);
	}
}
