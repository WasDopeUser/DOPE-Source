using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass201 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9999;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass201(int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 9999;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9999);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(this.int_0);
	}

	public int int_0;
}
