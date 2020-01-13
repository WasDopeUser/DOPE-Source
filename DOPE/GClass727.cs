using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass727 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25101;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 32;
		}
	}

	public GClass727(int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_4 = int_8;
		this.int_5 = int_9;
		this.int_7 = int_10;
		this.int_3 = int_11;
		this.int_2 = int_12;
		this.int_1 = int_13;
		this.int_6 = int_14;
		this.int_0 = int_15;
	}

	public virtual int vmethod_0()
	{
		return 25101;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 5 | U.smethod_0(this.int_6, 27));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 14 | U.smethod_0(this.int_7, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25101);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_4(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.smethod_4(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		binaryStream_0.smethod_4(this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 5) | this.int_6 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 14) | this.int_7 << 18);
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
