using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass173 : GClass172, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19389;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass173(string string_2 = "", int int_2 = 0, int int_3 = 0, string string_3 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_1 = "";
		base..ctor(string_2, int_2, int_3);
		this.string_1 = string_3;
	}

	public override int vmethod_0()
	{
		return 19389;
	}

	public override int vmethod_1()
	{
		return 22;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(19389);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_5(5854);
	}

	public string string_1;
}
