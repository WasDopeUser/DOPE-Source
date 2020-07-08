using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass325 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 523;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass325(int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_7;
		this.int_1 = int_8;
		this.int_2 = int_9;
		this.int_3 = int_10;
		this.int_4 = int_11;
		this.int_5 = int_12;
		this.int_6 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 523;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 1) | this.int_4 << 31);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 7) | this.int_6 << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(523);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_7(this.int_1);
		binaryStream_0.smethod_4(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		binaryStream_0.smethod_4(this.int_4 << 1 | U.smethod_0(this.int_4, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		binaryStream_0.smethod_4(this.int_6 << 7 | U.smethod_0(this.int_6, 25));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;
}
