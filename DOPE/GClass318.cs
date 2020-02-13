using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass318 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19121;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass318(int int_6 = 0, uint uint_1 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_5 = int_6;
		this.uint_0 = uint_1;
		this.int_4 = int_7;
		this.int_2 = int_8;
		this.int_0 = int_9;
		this.int_1 = int_10;
		this.int_3 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 19121;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 14) | this.int_3 << 18);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 1) | this.int_4 << 31);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 6 | U.smethod_0(this.int_5, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(19121);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-4730);
		binaryStream_0.smethod_3(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_3(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.smethod_3(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(24487);
		binaryStream_0.smethod_3(this.int_3 << 14 | U.smethod_0(this.int_3, 18));
		binaryStream_0.smethod_3(this.int_4 << 1 | U.smethod_0(this.int_4, 31));
		binaryStream_0.smethod_3(U.smethod_0(this.int_5, 6) | this.int_5 << 26);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public uint uint_0;

	public int int_3;

	public int int_4;

	public int int_5;
}
