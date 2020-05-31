using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass670 : GClass667, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32236;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass670(int int_0 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 32236;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 8 | U.smethod_0(this.Value, 24));
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32236);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Value, 8) | this.Value << 24);
	}

	public int Value;
}
