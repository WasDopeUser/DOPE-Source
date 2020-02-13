using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass366 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14082;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass366(string string_1 = "", int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.int_3 = int_6;
		this.int_0 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 14082;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(14082);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		binaryStream_0.smethod_6(-4072);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.smethod_6(8784);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public int int_2;

	public int int_3;
}
