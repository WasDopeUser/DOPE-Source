using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass181 : GClass180, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32411;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass181(string string_2 = "", int int_2 = 0, int int_3 = 0, string string_3 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_1 = "";
		base..ctor(string_2, int_2, int_3);
		this.string_1 = string_3;
	}

	public override int vmethod_0()
	{
		return 32411;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32411);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public string string_1;
}
