using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass272 : GClass271, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32411;
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
		Class13.Gj4N3WdzaR1LY();
		base..ctor(string_1);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 32411;
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
		this.Value = (this.Value << 3 | U.smethod_0(this.Value, 29));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32411);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-16115);
		binaryStream_0.smethod_4(U.smethod_0(this.Value, 3) | this.Value << 29);
	}

	public int Value;
}
