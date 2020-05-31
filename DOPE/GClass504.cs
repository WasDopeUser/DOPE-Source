using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass504 : GClass500, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20662;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass504()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 20662;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20662);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(21948);
		binaryStream_0.smethod_7(-7461);
	}
}
