using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass590 : GClass586, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30508;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass590(string string_0 = "", double double_0 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(string_0);
		this.Value = double_0;
	}

	public override int vmethod_0()
	{
		return 30508;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.ReadDouble();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30508);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.Value);
	}

	public double Value;
}
