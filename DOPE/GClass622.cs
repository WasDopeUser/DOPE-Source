using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass622 : GClass621, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9043;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass622(double double_1 = 0.0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 9043;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9043);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(2997);
	}

	public double double_0;
}
