using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass574 : GClass573, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9765;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass574(string string_0 = "", string string_1 = "")
	{
		Class8.xDph7tozmh5WD();
		this.Value = "";
		base..ctor(string_0);
		this.Value = string_1;
	}

	public override int vmethod_0()
	{
		return 9765;
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
		binaryStream_0.smethod_5(9765);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(17760);
		binaryStream_0.smethod_3(this.Value);
	}

	public string Value;
}
