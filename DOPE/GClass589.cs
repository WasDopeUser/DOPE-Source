using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass589 : GClass587, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19865;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass589(string string_0 = "", int int_0 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor(string_0);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 19865;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (U.smethod_0(this.Value, 5) | this.Value << 27);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(19865);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Value << 5 | U.smethod_0(this.Value, 27));
		binaryStream_0.smethod_6(26397);
		binaryStream_0.smethod_6(-32488);
	}

	public int Value;
}
