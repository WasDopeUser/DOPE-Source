using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass466 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16259;
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
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_7;
		this.int_6 = int_8;
		this.int_5 = int_9;
		this.int_3 = int_10;
		this.int_2 = int_11;
		this.string_0 = string_2;
		this.int_1 = int_12;
		this.string_1 = string_3;
		this.int_4 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 16259;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.string_1 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 4 | U.smethod_0(this.int_5, 28));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 11) | this.int_6 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16259);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_4(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.smethod_7(23197);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 4) | this.int_5 << 28);
		binaryStream_0.smethod_4(this.int_6 << 11 | U.smethod_0(this.int_6, 21));
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public int int_2;

	public string string_1;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;
}
