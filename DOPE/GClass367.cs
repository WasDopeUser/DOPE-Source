using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass367 : GClass366, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -25490;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass367(string string_1 = "", int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, double double_1 = 0.0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor(string_1, int_6, int_7, int_8, int_9);
		this.int_4 = int_10;
		this.int_5 = int_11;
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return -25490;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 4) | this.int_4 << 28);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 11 | U.smethod_0(this.int_5, 21));
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-25490);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_4 << 4 | U.smethod_0(this.int_4, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 11) | this.int_5 << 21);
		binaryStream_0.smethod_9(this.double_0);
	}

	public int int_4;

	public int int_5;

	public double double_0;
}
