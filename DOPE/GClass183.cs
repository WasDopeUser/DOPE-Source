using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass183 : GClass179, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9877;
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
		Class13.igxcIukzfpare();
		this.string_1 = "";
		base..ctor(string_2, int_4, int_5);
		this.int_3 = int_6;
		this.int_2 = int_7;
		this.string_1 = string_3;
	}

	public override int vmethod_0()
	{
		return 9877;
	}

	public override int vmethod_1()
	{
		return 30;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		this.string_1 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9877);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-9664);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_3(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
	}

	public int int_2;

	public string string_1;

	public int int_3;
}
