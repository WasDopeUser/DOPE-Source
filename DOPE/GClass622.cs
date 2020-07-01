using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass622 : GClass617, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7161;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass622(string string_0 = "", double double_0 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(string_0);
		this.Value = double_0;
	}

	public override int vmethod_0()
	{
		return 7161;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.Value = binaryStream_0.ReadDouble();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7161);
		base.imethod_1(binaryStream_0);
		binaryStream_0.WriteDouble(this.Value);
	}

	public double Value;
}
