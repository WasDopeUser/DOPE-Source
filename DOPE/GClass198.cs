using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass198 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22010;
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
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_6;
		this.int_1 = int_7;
		this.int_2 = int_11;
		this.int_3 = int_10;
		this.int_4 = int_8;
		this.int_5 = int_9;
	}

	public override int vmethod_0()
	{
		return 22010;
	}

	public override int vmethod_1()
	{
		return 24;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 16 | U.smethod_0(this.int_4, 16));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 14 | U.smethod_0(this.int_5, 18));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22010);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_4(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.smethod_4(this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 16) | this.int_4 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 14) | this.int_5 << 18);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;
}
