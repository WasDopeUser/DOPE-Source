using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass272 : GClass271, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30384;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass272(string string_1 = "", int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor(string_1);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 30384;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 5 | U.smethod_0(this.Value, 27));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30384);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(14409);
		binaryStream_0.smethod_4(U.smethod_0(this.Value, 5) | this.Value << 27);
	}

	public int Value;
}
