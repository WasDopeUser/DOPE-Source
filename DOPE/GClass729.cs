using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass729 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11925;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 32;
		}
	}

	public GClass729(int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_2 = int_8;
		this.int_6 = int_9;
		this.int_3 = int_10;
		this.int_1 = int_11;
		this.int_5 = int_12;
		this.int_0 = int_13;
		this.int_4 = int_14;
		this.int_7 = int_15;
	}

	public virtual int vmethod_0()
	{
		return 11925;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 2 | U.smethod_0(this.int_5, 30));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 5 | U.smethod_0(this.int_6, 27));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 9 | U.smethod_0(this.int_7, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11925);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_3(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		binaryStream_0.smethod_3(U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		binaryStream_0.smethod_3(U.smethod_0(this.int_5, 2) | this.int_5 << 30);
		binaryStream_0.smethod_3(U.smethod_0(this.int_6, 5) | this.int_6 << 27);
		binaryStream_0.smethod_3(U.smethod_0(this.int_7, 9) | this.int_7 << 23);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;
}
