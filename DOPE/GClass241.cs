using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass241 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25361;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass241(int int_3 = 0, int int_4 = 0, string string_2 = "", string string_3 = "", int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 25361;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_1();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25361);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_6(28661);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_6(this.int_1);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
	}

	public string string_0;

	public int int_0;

	public string string_1;

	public int int_1;

	public int int_2;
}
