using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass603 : GClass602, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29907;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass603(string string_0 = "", string string_1 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.Value = "";
		base..ctor(string_0);
		this.Value = string_1;
	}

	public override int vmethod_0()
	{
		return 29907;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.Value = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29907);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Value);
		binaryStream_0.smethod_7(-10941);
	}

	public string Value;
}
