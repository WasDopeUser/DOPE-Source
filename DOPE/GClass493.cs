using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass493 : GClass488, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26352;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass493()
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 26352;
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
		binaryStream_0.smethod_7(26352);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(7642);
	}
}
