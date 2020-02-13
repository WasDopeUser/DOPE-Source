using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass656 : GClass653, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7284;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass656(int int_0 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 7284;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (U.smethod_0(this.Value, 15) | this.Value << 17);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(7284);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Value << 15 | U.smethod_0(this.Value, 17));
		binaryStream_0.smethod_6(-8702);
		binaryStream_0.smethod_6(-20088);
	}

	public int Value;
}
