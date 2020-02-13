using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass725 : GClass724, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24828;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass725(double double_1 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 24828;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24828);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double double_0;
}
