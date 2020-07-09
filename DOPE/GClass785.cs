using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass785 : GClass784, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5591;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass785(double double_1 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 5591;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5591);
		base.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double double_0;
}
