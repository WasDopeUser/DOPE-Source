using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass365 : GClass364, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16782;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 48;
		}
	}

	public GClass365(string string_1 = "", int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, double double_1 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor(string_1, int_5, int_6, int_7, int_8);
		this.int_3 = int_9;
		this.int_4 = int_10;
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 16782;
	}

	public override int vmethod_1()
	{
		return 48;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 3 | U.smethod_0(this.int_4, 29));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16782);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 3) | this.int_4 << 29);
	}

	public int int_3;

	public double double_0;

	public int int_4;
}
