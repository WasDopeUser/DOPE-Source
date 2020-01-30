using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass273 : GClass271, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25674;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass273(string string_1 = "", string string_2 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.Value = "";
		base..ctor(string_1);
		this.Value = string_2;
	}

	public override int vmethod_0()
	{
		return 25674;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25674);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Value);
	}

	public string Value;
}
