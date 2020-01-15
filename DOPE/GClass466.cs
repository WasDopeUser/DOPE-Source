using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass466 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19155;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 32;
		}
	}

	public GClass466(int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, string string_2 = "", int int_12 = 0, string string_3 = "", int int_13 = 0)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_3 = int_7;
		this.int_1 = int_8;
		this.int_2 = int_9;
		this.int_5 = int_10;
		this.int_0 = int_11;
		this.string_0 = string_2;
		this.int_6 = int_12;
		this.string_1 = string_3;
		this.int_4 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 19155;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 16 | U.smethod_0(this.int_4, 16));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 16 | U.smethod_0(this.int_5, 16));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 12) | this.int_6 << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19155);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(9044);
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 16) | this.int_4 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 16) | this.int_5 << 16);
		binaryStream_0.smethod_4(this.int_6 << 12 | U.smethod_0(this.int_6, 20));
	}

	public int int_0;

	public string string_0;

	public int int_1;

	public string string_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;
}
