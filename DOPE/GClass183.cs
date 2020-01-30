using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass183 : GClass179, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25181;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 30;
		}
	}

	public GClass183(string string_2 = "", int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, string string_3 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_1 = "";
		base..ctor(string_2, int_4, int_5);
		this.int_3 = int_6;
		this.int_2 = int_7;
		this.string_1 = string_3;
	}

	public override int vmethod_0()
	{
		return 25181;
	}

	public override int vmethod_1()
	{
		return 30;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25181);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
	}

	public string string_1;

	public int int_2;

	public int int_3;
}
