using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass268 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3335;
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
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_5 = int_8;
		this.int_2 = int_9;
		this.int_4 = int_10;
		this.int_0 = int_11;
		this.int_3 = int_12;
		this.int_7 = int_13;
		this.int_1 = int_14;
		this.int_6 = int_15;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 3335;
	}

	public virtual int vmethod_1()
	{
		return 33;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 14) | this.int_4 << 18);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 10 | U.smethod_0(this.int_5, 22));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 12) | this.int_6 << 20);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 15 | U.smethod_0(this.int_7, 17));
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3335);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_4(this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		binaryStream_0.smethod_4(this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		binaryStream_0.smethod_4(this.int_4 << 14 | U.smethod_0(this.int_4, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 10) | this.int_5 << 22);
		binaryStream_0.smethod_4(this.int_6 << 12 | U.smethod_0(this.int_6, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 15) | this.int_7 << 17);
		binaryStream_0.smethod_7(-32395);
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
