using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass411 : GClass403, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29411;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass411(double double_1 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 29411;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.double_0 = (double)binaryStream_0.smethod_9();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(29411);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-16560);
		binaryStream_0.smethod_8(this.double_0);
	}

	public double double_0;
}
