using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass830 : GClass829, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -30968;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass830(double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(double_3, double_4, double_5);
		this.int_0 = int_5;
		this.int_1 = int_3;
		this.int_2 = int_4;
	}

	public override int vmethod_0()
	{
		return -30968;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-30968);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
	}

	public int int_0;

	public int int_1;

	public int int_2;
}
