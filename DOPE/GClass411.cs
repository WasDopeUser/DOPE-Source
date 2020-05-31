using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass411 : GClass409, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30860;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass411(uint uint_0 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.SsZfihgdlW = uint_0;
	}

	public override int vmethod_0()
	{
		return 30860;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.SsZfihgdlW = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30860);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(this.SsZfihgdlW);
	}

	public uint SsZfihgdlW;
}
