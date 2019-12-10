using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass259 : GClass257, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31710;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass259(string string_1 = "", string string_2 = "")
	{
		Class8.xDph7tozmh5WD();
		this.Value = "";
		base..ctor(string_1);
		this.Value = string_2;
	}

	public override int vmethod_0()
	{
		return 31710;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(31710);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-32204);
		binaryStream_0.smethod_3(this.Value);
	}

	public string Value;
}
