using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass735 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23704;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 30;
		}
	}

	public GClass735(uint uint_1 = 0U, uint uint_2 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, string string_1 = "", int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.Status = uint_2;
		this.int_2 = int_7;
		this.int_6 = int_8;
		this.int_3 = int_9;
		this.string_0 = string_1;
		this.int_1 = int_10;
		this.int_4 = int_11;
		this.int_0 = int_12;
		this.int_5 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 23704;
	}

	public virtual int vmethod_1()
	{
		return 30;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.Status = (uint)binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 4 | U.smethod_0(this.int_5, 28));
		binaryStream_0.smethod_1();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 7) | this.int_6 << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23704);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_6(this.Status);
		binaryStream_0.smethod_4(this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 4) | this.int_5 << 28);
		binaryStream_0.smethod_7(18729);
		binaryStream_0.smethod_4(this.int_6 << 7 | U.smethod_0(this.int_6, 25));
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public uint uint_0;

	public uint Status;

	public int int_4;

	public int int_5;

	public int int_6;
}
