using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass467 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3328;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 32;
		}
	}

	public GClass467(int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, string string_2 = "", int int_12 = 0, string string_3 = "", int int_13 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_3 = int_7;
		this.int_1 = int_8;
		this.int_2 = int_9;
		this.int_0 = int_10;
		this.int_6 = int_11;
		this.string_1 = string_2;
		this.int_5 = int_12;
		this.string_0 = string_3;
		this.int_4 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 3328;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.string_1 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 8 | U.smethod_0(this.int_4, 24));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 9 | U.smethod_0(this.int_5, 23));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 7 | U.smethod_0(this.int_6, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(3328);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_6(13281);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		binaryStream_0.smethod_3(U.smethod_0(this.int_4, 8) | this.int_4 << 24);
		binaryStream_0.smethod_3(U.smethod_0(this.int_5, 9) | this.int_5 << 23);
		binaryStream_0.smethod_3(U.smethod_0(this.int_6, 7) | this.int_6 << 25);
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
