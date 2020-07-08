using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass829 : GClass828, GInterface0
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

	public GClass829(double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor(double_3, double_4, double_5);
		this.int_0 = int_4;
		this.ajOhCucXtj = int_2;
		this.int_1 = int_3;
	}

	public override int vmethod_0()
	{
		return -30968;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.ajOhCucXtj = binaryStream_0.smethod_0();
		this.ajOhCucXtj = (this.ajOhCucXtj << 7 | U.smethod_0(this.ajOhCucXtj, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-30968);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.ajOhCucXtj, 7) | this.ajOhCucXtj << 25);
		binaryStream_0.smethod_4(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public int int_0;

	public int ajOhCucXtj;

	public int int_1;
}
