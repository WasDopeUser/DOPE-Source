using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass396 : GClass394, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1552;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass396(uint uint_1 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
	}

	public override int vmethod_0()
	{
		return 1552;
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
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1552);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(23428);
		binaryStream_0.smethod_7(21233);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public uint uint_0;
}
