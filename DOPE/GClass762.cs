using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass762 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25075;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass762(int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_9 = int_13;
		this.int_1 = int_14;
		this.int_2 = int_15;
		this.int_3 = int_16;
		this.int_5 = int_17;
		this.int_10 = int_18;
		this.int_4 = int_19;
		this.int_6 = int_20;
		this.int_11 = int_21;
		this.int_7 = int_22;
		this.int_0 = int_23;
		this.int_12 = int_24;
		this.int_8 = int_25;
	}

	public virtual int vmethod_0()
	{
		return 25075;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 16 | U.smethod_0(this.int_4, 16));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 8 | U.smethod_0(this.int_6, 24));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 6 | U.smethod_0(this.int_7, 26));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 13) | this.int_8 << 19);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 7 | U.smethod_0(this.int_9, 25));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 6) | this.int_10 << 26);
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 16) | this.int_11 << 16);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 6 | U.smethod_0(this.int_12, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25075);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 16) | this.int_4 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 8) | this.int_6 << 24);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 6) | this.int_7 << 26);
		binaryStream_0.smethod_4(this.int_8 << 13 | U.smethod_0(this.int_8, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 7) | this.int_9 << 25);
		binaryStream_0.smethod_4(this.int_10 << 6 | U.smethod_0(this.int_10, 26));
		binaryStream_0.smethod_4(this.int_11 << 16 | U.smethod_0(this.int_11, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_12, 6) | this.int_12 << 26);
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

	public int int_10;

	public int int_11;

	public int int_12;
}
