using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass792 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -29054;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass792(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_12;
		this.JlZglPunly = int_20;
		this.int_1 = int_11;
		this.int_2 = int_15;
		this.int_3 = int_19;
		this.int_4 = int_18;
		this.int_5 = int_17;
		this.int_6 = int_16;
		this.int_7 = int_14;
		this.int_8 = int_10;
		this.int_9 = int_13;
	}

	public virtual int vmethod_0()
	{
		return -29054;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.JlZglPunly = binaryStream_0.smethod_0();
		this.JlZglPunly = (U.smethod_0(this.JlZglPunly, 11) | this.JlZglPunly << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 13 | U.smethod_0(this.int_3, 19));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 10 | U.smethod_0(this.int_4, 22));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 11 | U.smethod_0(this.int_5, 21));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 12) | this.int_6 << 20);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 4 | U.smethod_0(this.int_7, 28));
		this.int_8 = (int)binaryStream_0.smethod_1();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 16) | this.int_9 << 16);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-29054);
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_4(this.JlZglPunly << 11 | U.smethod_0(this.JlZglPunly, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_4(this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 13) | this.int_3 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 10) | this.int_4 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 11) | this.int_5 << 21);
		binaryStream_0.smethod_4(this.int_6 << 12 | U.smethod_0(this.int_6, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 4) | this.int_7 << 28);
		binaryStream_0.smethod_7(this.int_8);
		binaryStream_0.smethod_4(this.int_9 << 16 | U.smethod_0(this.int_9, 16));
	}

	public int int_0;

	public int JlZglPunly;

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
