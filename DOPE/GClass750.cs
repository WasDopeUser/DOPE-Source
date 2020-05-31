using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass750 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32230;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 30;
		}
	}

	public GClass750(uint uint_1 = 0U, uint uint_2 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, string string_1 = "", int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.Status = uint_2;
		this.int_2 = int_7;
		this.int_3 = int_8;
		this.int_1 = int_9;
		this.string_0 = string_1;
		this.int_5 = int_10;
		this.int_4 = int_11;
		this.int_0 = int_12;
		this.int_6 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 32230;
	}

	public virtual int vmethod_1()
	{
		return 30;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 8 | U.smethod_0(this.int_5, 24));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 15 | U.smethod_0(this.int_6, 17));
		this.Status = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32230);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		binaryStream_0.smethod_4(this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 8) | this.int_5 << 24);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 15) | this.int_6 << 17);
		binaryStream_0.smethod_6(this.Status);
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public uint uint_0;

	public int int_6;

	public uint Status;
}
