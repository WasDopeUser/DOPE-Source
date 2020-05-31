using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass604 : GClass602, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8998;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass604(string string_0 = "", int int_0 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(string_0);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 8998;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (U.smethod_0(this.Value, 1) | this.Value << 31);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8998);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.Value << 1 | U.smethod_0(this.Value, 31));
	}

	public int Value;
}
