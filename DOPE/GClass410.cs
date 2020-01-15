using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass410 : GClass402, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17552;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass410(double double_1 = 0.0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 17552;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17552);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_7(23960);
		binaryStream_0.smethod_7(-9723);
	}

	public double double_0;
}
