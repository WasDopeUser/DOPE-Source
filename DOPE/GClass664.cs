using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass664 : GClass661, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21488;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass664(string string_1 = "", double double_1 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(string_1);
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 21488;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21488);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_7(32301);
	}

	public double double_0;
}
