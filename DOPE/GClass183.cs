using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass183 : GClass179, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6240;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass183(string string_2 = "", int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, string string_3 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.string_1 = "";
		base..ctor(string_2, int_4, int_5);
		this.int_2 = int_7;
		this.string_1 = string_3;
		this.int_3 = int_6;
	}

	public override int vmethod_0()
	{
		return 6240;
	}

	public override int vmethod_1()
	{
		return 10;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		this.string_1 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 16 | U.smethod_0(this.int_3, 16));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6240);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 16) | this.int_3 << 16);
	}

	public int int_2;

	public string string_1;

	public int int_3;
}
