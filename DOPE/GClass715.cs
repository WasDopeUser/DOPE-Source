using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass715 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21769;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass715(int int_3 = 0, int int_4 = 0, string string_3 = "", int int_5 = 0, string string_4 = "", string string_5 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.string_1 = string_3;
		this.int_0 = int_5;
		this.string_0 = string_4;
		this.string_2 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 21769;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21769);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_6(-31956);
		binaryStream_0.smethod_6(20863);
		binaryStream_0.smethod_3(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.MoioCjQkqp0(this.string_2);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public string string_1;

	public string string_2;

	public int int_2;
}
