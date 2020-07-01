using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass620 : GClass617, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -5011;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass620(string string_0 = "", int int_0 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(string_0);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return -5011;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 10 | U.smethod_0(this.Value, 22));
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-5011);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Value, 10) | this.Value << 22);
	}

	public int Value;
}
