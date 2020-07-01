using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass619 : GClass617, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -32349;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass619(string string_0 = "", string string_1 = "")
	{
		Class13.F93tSdiz1aNIA();
		this.Value = "";
		base..ctor(string_0);
		this.Value = string_1;
	}

	public override int vmethod_0()
	{
		return -32349;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.Value = binaryStream_0.smethod_2();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-32349);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.Value);
	}

	public string Value;
}
