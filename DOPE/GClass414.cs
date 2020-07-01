using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass414 : GClass406, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29198;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass414(double double_1 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 29198;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29198);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_9(this.double_0);
	}

	public double double_0;
}
