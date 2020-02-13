using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass380 : GClass377, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20078;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass380(string string_1 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
	}

	public override int vmethod_0()
	{
		return 20078;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(20078);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-5083);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_6(6517);
	}

	public string string_0;
}
