using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass562 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20226;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass562(string string_3 = "", int int_2 = 0, string string_4 = "", int int_3 = 0, string string_5 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_0 = string_3;
		this.int_0 = int_2;
		this.string_2 = string_4;
		this.int_1 = int_3;
		this.string_1 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 20226;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.string_2 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(20226);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_3(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.MoioCjQkqp0(this.string_2);
		binaryStream_0.smethod_6(-12511);
	}

	public string string_0;

	public string string_1;

	public int int_0;

	public int int_1;

	public string string_2;
}
