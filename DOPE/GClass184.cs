using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass184 : GClass180, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11721;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 30;
		}
	}

	public GClass184(string string_2 = "", int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, string string_3 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_1 = "";
		base..ctor(string_2, int_4, int_5);
		this.int_3 = int_6;
		this.int_2 = int_7;
		this.string_1 = string_3;
	}

	public override int vmethod_0()
	{
		return 11721;
	}

	public override int vmethod_1()
	{
		return 30;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11721);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(31137);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_4(this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		binaryStream_0.smethod_3(this.string_1);
	}

	public int int_2;

	public int int_3;

	public string string_1;
}
