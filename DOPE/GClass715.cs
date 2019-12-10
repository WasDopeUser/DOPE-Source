using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass715 : GClass712, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28270;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass715(double double_2 = 0.0, double double_3 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public override int vmethod_0()
	{
		return 28270;
	}

	public override int vmethod_1()
	{
		return 16;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(28270);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_5(18646);
	}

	public double double_0;

	public double double_1;
}
