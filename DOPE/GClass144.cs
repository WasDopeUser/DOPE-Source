using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass144 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 463;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass144(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.hmoLahxotH = int_3;
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 463;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		binaryStream_0.smethod_1();
		this.hmoLahxotH = binaryStream_0.smethod_0();
		this.hmoLahxotH = (U.smethod_0(this.hmoLahxotH, 3) | this.hmoLahxotH << 29);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(463);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_4(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		binaryStream_0.smethod_7(-30672);
		binaryStream_0.smethod_4(this.hmoLahxotH << 3 | U.smethod_0(this.hmoLahxotH, 29));
		binaryStream_0.smethod_7(-4560);
	}

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;

	public int hmoLahxotH;
}
