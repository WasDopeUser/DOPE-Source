using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass188 : GClass187, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18862;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass188(int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_3 = int_6;
		this.int_2 = int_7;
		this.int_1 = int_8;
		this.int_5 = int_9;
		this.int_0 = int_10;
		this.int_4 = int_11;
	}

	public override int vmethod_0()
	{
		return 18862;
	}

	public override int vmethod_1()
	{
		return 24;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 14) | this.int_4 << 18);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 10) | this.int_5 << 22);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(18862);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(25422);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.fUeiimuocMk(this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		binaryStream_0.fUeiimuocMk(this.int_4 << 14 | U.smethod_0(this.int_4, 18));
		binaryStream_0.fUeiimuocMk(this.int_5 << 10 | U.smethod_0(this.int_5, 22));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;
}
