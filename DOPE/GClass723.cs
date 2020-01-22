using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass723 : GClass722, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27314;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass723(double double_1 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 27314;
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
		binaryStream_0.smethod_7(27314);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(-862);
	}

	public double double_0;
}
