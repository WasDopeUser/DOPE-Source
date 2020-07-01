using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass405 : GClass401, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26146;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass405()
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 26146;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26146);
		base.imethod_1(binaryStream_0);
	}
}
