using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass415 : GClass409, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 737;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass415()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 737;
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
		binaryStream_0.smethod_7(737);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(24067);
	}
}
