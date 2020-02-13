using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass144 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30910;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass144(string string_1 = "", int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.int_3 = int_6;
		this.int_1 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 30910;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 4 | U.smethod_0(this.int_3, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30910);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_3(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 4) | this.int_3 << 28);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public int int_3;
}
