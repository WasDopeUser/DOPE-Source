using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass587 : GClass586, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16521;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass587(string string_0 = "", string string_1 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.Value = "";
		base..ctor(string_0);
		this.Value = string_1;
	}

	public override int vmethod_0()
	{
		return 16521;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16521);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Value);
		binaryStream_0.smethod_7(-24021);
	}

	public string Value;
}
