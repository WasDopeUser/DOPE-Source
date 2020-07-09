using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass577 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 264;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass577(int int_9 = 0, int int_10 = 0, int int_11 = 0, bool bool_1 = false, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_9;
		this.int_1 = int_10;
		this.int_2 = int_11;
		this.bool_0 = bool_1;
		this.int_3 = int_12;
		this.int_4 = int_13;
		this.int_5 = int_14;
		this.int_6 = int_15;
		this.int_7 = int_16;
		this.int_8 = int_17;
	}

	public virtual int vmethod_0()
	{
		return 264;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_0 = (65535 & ((65535 & this.int_0) << 3 | U.smethod_0(65535 & this.int_0, 13)));
		this.int_0 = ((this.int_0 > 32767) ? (this.int_0 - 65536) : this.int_0);
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_1 = (65535 & (U.smethod_0(65535 & this.int_1, 9) | (65535 & this.int_1) << 7));
		this.int_1 = ((this.int_1 > 32767) ? (this.int_1 - 65536) : this.int_1);
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_2 = (65535 & ((65535 & this.int_2) << 11 | U.smethod_0(65535 & this.int_2, 5)));
		this.int_2 = ((this.int_2 > 32767) ? (this.int_2 - 65536) : this.int_2);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_3 = (int)binaryStream_0.smethod_1();
		this.int_3 = (65535 & ((65535 & this.int_3) << 1 | U.smethod_0(65535 & this.int_3, 15)));
		this.int_3 = ((this.int_3 > 32767) ? (this.int_3 - 65536) : this.int_3);
		this.int_4 = (int)binaryStream_0.smethod_1();
		this.int_4 = (65535 & ((65535 & this.int_4) << 14 | U.smethod_0(65535 & this.int_4, 2)));
		this.int_4 = ((this.int_4 > 32767) ? (this.int_4 - 65536) : this.int_4);
		this.int_5 = (int)binaryStream_0.smethod_1();
		this.int_5 = (65535 & ((65535 & this.int_5) << 10 | U.smethod_0(65535 & this.int_5, 6)));
		this.int_5 = ((this.int_5 > 32767) ? (this.int_5 - 65536) : this.int_5);
		this.int_6 = (int)binaryStream_0.smethod_1();
		this.int_6 = (65535 & (U.smethod_0(65535 & this.int_6, 8) | (65535 & this.int_6) << 8));
		this.int_6 = ((this.int_6 > 32767) ? (this.int_6 - 65536) : this.int_6);
		this.int_7 = (int)binaryStream_0.smethod_1();
		this.int_7 = (65535 & ((65535 & this.int_7) << 4 | U.smethod_0(65535 & this.int_7, 12)));
		this.int_7 = ((this.int_7 > 32767) ? (this.int_7 - 65536) : this.int_7);
		this.int_8 = (int)binaryStream_0.smethod_1();
		this.int_8 = (65535 & (U.smethod_0(65535 & this.int_8, 5) | (65535 & this.int_8) << 11));
		this.int_8 = ((this.int_8 > 32767) ? (this.int_8 - 65536) : this.int_8);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(264);
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_0, 3) | (65535 & this.int_0) << 13));
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_1) << 9 | U.smethod_0(65535 & this.int_1, 7)));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_2, 11) | (65535 & this.int_2) << 5));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_3, 1) | (65535 & this.int_3) << 15));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_4, 14) | (65535 & this.int_4) << 2));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_5, 10) | (65535 & this.int_5) << 6));
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_6) << 8 | U.smethod_0(65535 & this.int_6, 8)));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_7, 4) | (65535 & this.int_7) << 12));
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_8) << 5 | U.smethod_0(65535 & this.int_8, 11)));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;
}
