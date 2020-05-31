using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass417 : GClass409, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30069;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass417(double double_1 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 30069;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30069);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_7(-16860);
	}

	public double double_0;
}
