using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass548 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1379;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass548(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_0 = int_10;
		this.int_6 = int_11;
		this.int_8 = int_12;
		this.int_7 = int_13;
		this.int_3 = int_14;
		this.int_1 = int_15;
		this.int_5 = int_16;
		this.int_2 = int_17;
		this.int_4 = int_18;
		this.int_9 = int_19;
	}

	public virtual int vmethod_0()
	{
		return 1379;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 7) | this.int_6 << 25);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 8) | this.int_7 << 24);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 10 | U.smethod_0(this.int_8, 22));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 16 | U.smethod_0(this.int_9, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1379);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		binaryStream_0.smethod_4(this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		binaryStream_0.smethod_4(this.int_6 << 7 | U.smethod_0(this.int_6, 25));
		binaryStream_0.smethod_4(this.int_7 << 8 | U.smethod_0(this.int_7, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 10) | this.int_8 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 16) | this.int_9 << 16);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;
}
