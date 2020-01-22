using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass587 : GClass585, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4382;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass587(string string_0 = "", int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor(string_0);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 4382;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 5 | U.smethod_0(this.Value, 27));
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4382);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Value, 5) | this.Value << 27);
		binaryStream_0.smethod_7(-9864);
	}

	public int Value;
}
