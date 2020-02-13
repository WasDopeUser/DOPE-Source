using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass491 : GClass490, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22337;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass491()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 22337;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(22337);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
	}
}
