using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass395 : GClass387, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 908;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass395(double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 908;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_8();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(908);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(this.double_0);
	}

	public double double_0;
}
