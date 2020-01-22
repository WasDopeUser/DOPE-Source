using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass589 : GClass585, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14915;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass589(string string_0 = "", double double_0 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor(string_0);
		this.Value = double_0;
	}

	public override int vmethod_0()
	{
		return 14915;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14915);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.Value);
		binaryStream_0.smethod_7(16876);
		binaryStream_0.smethod_7(28760);
	}

	public double Value;
}
