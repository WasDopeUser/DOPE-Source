using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass198 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32257;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass198(int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_3 = int_6;
		this.int_1 = int_7;
		this.int_2 = int_8;
		this.int_5 = int_9;
		this.int_4 = int_10;
		this.int_0 = int_11;
	}

	public override int vmethod_0()
	{
		return 32257;
	}

	public override int vmethod_1()
	{
		return 24;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 4) | this.int_4 << 28);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 8) | this.int_5 << 24);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(32257);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_3(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.smethod_3(this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		binaryStream_0.smethod_3(this.int_4 << 4 | U.smethod_0(this.int_4, 28));
		binaryStream_0.smethod_3(this.int_5 << 8 | U.smethod_0(this.int_5, 24));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;
}
