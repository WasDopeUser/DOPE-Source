using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass531 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 269;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass531(bool bool_2 = false, int int_9 = 0, int int_10 = 0, int int_11 = 0, bool bool_3 = false, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.bool_0 = bool_2;
		this.int_0 = int_9;
		this.int_1 = int_10;
		this.int_2 = int_11;
		this.bool_1 = bool_3;
		this.int_3 = int_12;
		this.int_4 = int_13;
		this.int_5 = int_14;
		this.int_6 = int_15;
		this.int_7 = int_16;
		this.int_8 = int_17;
	}

	public virtual int vmethod_0()
	{
		return 269;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_0 = (65535 & ((65535 & this.int_0) << 13 | U.smethod_0(65535 & this.int_0, 3)));
		this.int_0 = ((this.int_0 > 32767) ? (this.int_0 - 65536) : this.int_0);
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_1 = (65535 & (U.smethod_0(65535 & this.int_1, 13) | (65535 & this.int_1) << 3));
		this.int_1 = ((this.int_1 > 32767) ? (this.int_1 - 65536) : this.int_1);
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_2 = (65535 & ((65535 & this.int_2) << 10 | U.smethod_0(65535 & this.int_2, 6)));
		this.int_2 = ((this.int_2 > 32767) ? (this.int_2 - 65536) : this.int_2);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_3 = (int)binaryStream_0.smethod_1();
		this.int_3 = (65535 & (U.smethod_0(65535 & this.int_3, 5) | (65535 & this.int_3) << 11));
		this.int_3 = ((this.int_3 > 32767) ? (this.int_3 - 65536) : this.int_3);
		this.int_4 = (int)binaryStream_0.smethod_1();
		this.int_4 = (65535 & ((65535 & this.int_4) << 11 | U.smethod_0(65535 & this.int_4, 5)));
		this.int_4 = ((this.int_4 > 32767) ? (this.int_4 - 65536) : this.int_4);
		this.int_5 = (int)binaryStream_0.smethod_1();
		this.int_5 = (65535 & ((65535 & this.int_5) << 13 | U.smethod_0(65535 & this.int_5, 3)));
		this.int_5 = ((this.int_5 > 32767) ? (this.int_5 - 65536) : this.int_5);
		this.int_6 = (int)binaryStream_0.smethod_1();
		this.int_6 = (65535 & ((65535 & this.int_6) << 10 | U.smethod_0(65535 & this.int_6, 6)));
		this.int_6 = ((this.int_6 > 32767) ? (this.int_6 - 65536) : this.int_6);
		this.int_7 = (int)binaryStream_0.smethod_1();
		this.int_7 = (65535 & ((65535 & this.int_7) << 1 | U.smethod_0(65535 & this.int_7, 15)));
		this.int_7 = ((this.int_7 > 32767) ? (this.int_7 - 65536) : this.int_7);
		this.int_8 = (int)binaryStream_0.smethod_1();
		this.int_8 = (65535 & ((65535 & this.int_8) << 10 | U.smethod_0(65535 & this.int_8, 6)));
		this.int_8 = ((this.int_8 > 32767) ? (this.int_8 - 65536) : this.int_8);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(269);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_0, 13) | (65535 & this.int_0) << 3));
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_1) << 13 | U.smethod_0(65535 & this.int_1, 3)));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_2, 10) | (65535 & this.int_2) << 6));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_3) << 5 | U.smethod_0(65535 & this.int_3, 11)));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_4, 11) | (65535 & this.int_4) << 5));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_5, 13) | (65535 & this.int_5) << 3));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_6, 10) | (65535 & this.int_6) << 6));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_7, 1) | (65535 & this.int_7) << 15));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_8, 10) | (65535 & this.int_8) << 6));
	}

	public bool bool_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_1;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;
}
