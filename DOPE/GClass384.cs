using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass384 : GClass381, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2617;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass384(int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public override int vmethod_0()
	{
		return 2617;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(2617);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.fUeiimuocMk(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_5(-18819);
		binaryStream_0.smethod_5(22837);
	}

	public int int_0;

	public int int_1;
}
