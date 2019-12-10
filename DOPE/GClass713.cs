using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass713 : GClass712, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1351;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass713(double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 1351;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(1351);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(2062);
		binaryStream_0.smethod_5(20196);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double double_0;
}
