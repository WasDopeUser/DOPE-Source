using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass268 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 50;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 33;
		}
	}

	public GClass268(int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_8;
		this.int_1 = int_9;
		this.int_2 = int_10;
		this.int_3 = int_11;
		this.int_4 = int_12;
		this.int_5 = int_13;
		this.int_6 = int_14;
		this.int_7 = int_15;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 50;
	}

	public virtual int vmethod_1()
	{
		return 33;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 13 | U.smethod_0(this.int_5, 19));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 1 | U.smethod_0(this.int_6, 31));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 3 | U.smethod_0(this.int_7, 29));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(50);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 13) | this.int_5 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 1) | this.int_6 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 3) | this.int_7 << 29);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public bool bool_0;
}
