using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass268 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10604;
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
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_5 = int_8;
		this.int_1 = int_9;
		this.int_2 = int_10;
		this.int_7 = int_11;
		this.int_4 = int_12;
		this.int_6 = int_13;
		this.int_3 = int_14;
		this.int_0 = int_15;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 10604;
	}

	public virtual int vmethod_1()
	{
		return 33;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 14) | this.int_4 << 18);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 16) | this.int_5 << 16);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 2 | U.smethod_0(this.int_6, 30));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 11 | U.smethod_0(this.int_7, 21));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10604);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_7(1864);
		binaryStream_0.smethod_4(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.smethod_4(this.int_4 << 14 | U.smethod_0(this.int_4, 18));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_5 << 16 | U.smethod_0(this.int_5, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 2) | this.int_6 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 11) | this.int_7 << 21);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public bool bool_0;

	public int int_5;

	public int int_6;

	public int int_7;
}
