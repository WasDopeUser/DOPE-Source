using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass389 : GClass387, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14225;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass389(uint uint_1 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
	}

	public override int vmethod_0()
	{
		return 14225;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14225);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public uint uint_0;
}
