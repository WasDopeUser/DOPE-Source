using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass386 : GClass383, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28797;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass386(string string_1 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
	}

	public override int vmethod_0()
	{
		return 28797;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28797);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-21304);
		binaryStream_0.smethod_7(-13920);
		binaryStream_0.smethod_3(this.string_0);
	}

	public string string_0;
}
