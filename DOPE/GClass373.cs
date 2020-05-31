using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass373 : GClass372, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30944;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 48;
		}
	}

	public GClass373(string string_1 = "", int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, double double_1 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(string_1, int_6, int_7, int_8, int_9);
		this.int_5 = int_10;
		this.int_4 = int_11;
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 30944;
	}

	public override int vmethod_1()
	{
		return 48;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 7 | U.smethod_0(this.int_4, 25));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 16 | U.smethod_0(this.int_5, 16));
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30944);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(19518);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 16) | this.int_5 << 16);
		binaryStream_0.smethod_9(this.double_0);
	}

	public int int_4;

	public int int_5;

	public double double_0;
}
