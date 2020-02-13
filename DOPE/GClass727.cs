using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass727 : GClass724, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31359;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass727(double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public override int vmethod_0()
	{
		return 31359;
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
		binaryStream_0.smethod_6(31359);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_6(27691);
	}

	public double double_0;

	public double double_1;
}
