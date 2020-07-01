using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass787 : GClass784, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -5714;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass787(double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.double_0 = double_3;
		this.double_1 = double_2;
	}

	public override int vmethod_0()
	{
		return -5714;
	}

	public override int vmethod_1()
	{
		return 16;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-5714);
		base.imethod_1(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public double double_0;

	public double double_1;
}
