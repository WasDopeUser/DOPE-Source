using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass365 : GClass364, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26549;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 48;
		}
	}

	public GClass365(string string_1 = "", int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, double double_0 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(string_1, int_5, int_6, int_7, int_8);
		this.JdwguWhuYb = int_9;
		this.int_4 = int_10;
		this.HqOgbVfiGB = double_0;
	}

	public override int vmethod_0()
	{
		return 26549;
	}

	public override int vmethod_1()
	{
		return 48;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 1 | U.smethod_0(this.int_4, 31));
		this.HqOgbVfiGB = (double)binaryStream_0.smethod_10();
		this.JdwguWhuYb = binaryStream_0.smethod_0();
		this.JdwguWhuYb = (this.JdwguWhuYb << 7 | U.smethod_0(this.JdwguWhuYb, 25));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26549);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 1) | this.int_4 << 31);
		binaryStream_0.smethod_9(this.HqOgbVfiGB);
		binaryStream_0.smethod_4(U.smethod_0(this.JdwguWhuYb, 7) | this.JdwguWhuYb << 25);
	}

	public int int_4;

	public double HqOgbVfiGB;

	public int JdwguWhuYb;
}
