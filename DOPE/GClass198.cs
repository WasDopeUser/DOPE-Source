using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass198 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2470;
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
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_4 = int_6;
		this.int_2 = int_7;
		this.int_5 = int_8;
		this.int_3 = int_9;
		this.int_0 = int_10;
		this.int_1 = int_11;
	}

	public override int vmethod_0()
	{
		return 2470;
	}

	public override int vmethod_1()
	{
		return 24;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 14 | U.smethod_0(this.int_4, 18));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 10) | this.int_5 << 22);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2470);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_4(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 14) | this.int_4 << 18);
		binaryStream_0.smethod_4(this.int_5 << 10 | U.smethod_0(this.int_5, 22));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;
}
