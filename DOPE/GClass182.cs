using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass182 : GClass180, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 147;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass182(string string_1 = "", int int_2 = 0, int int_3 = 0, GClass259 gclass259_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(string_1, int_2, int_3);
		if (gclass259_1 == null)
		{
			this.gclass259_0 = new GClass259(0);
			return;
		}
		this.gclass259_0 = gclass259_1;
	}

	public override int vmethod_0()
	{
		return 147;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.gclass259_0 = (GClass259)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_0(binaryStream_0);
		}
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(147);
		base.imethod_1(binaryStream_0);
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass259 gclass259_0;
}
