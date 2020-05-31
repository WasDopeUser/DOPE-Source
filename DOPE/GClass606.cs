using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass606 : GClass602, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3439;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass606(string string_0 = "", double double_0 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(string_0);
		this.Value = double_0;
	}

	public override int vmethod_0()
	{
		return 3439;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.Value = binaryStream_0.ReadDouble();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3439);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(21582);
		binaryStream_0.WriteDouble(this.Value);
	}

	public double Value;
}
