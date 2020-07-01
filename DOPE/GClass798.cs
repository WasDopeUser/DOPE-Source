using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass798 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16034;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 30;
		}
	}

	public GClass798(int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, string string_1 = "", int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.Status = int_8;
		this.int_0 = int_13;
		this.SfJggdscyf = int_9;
		this.int_1 = int_11;
		this.string_0 = string_1;
		this.int_2 = int_12;
		this.int_3 = int_14;
		this.int_4 = int_7;
		this.int_5 = int_10;
		this.int_6 = int_15;
	}

	public virtual int vmethod_0()
	{
		return 16034;
	}

	public virtual int vmethod_1()
	{
		return 30;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Status = (int)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.SfJggdscyf = binaryStream_0.smethod_0();
		this.SfJggdscyf = (U.smethod_0(this.SfJggdscyf, 4) | this.SfJggdscyf << 28);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 13) | this.int_3 << 19);
		this.int_4 = (int)binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 10 | U.smethod_0(this.int_5, 22));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 13 | U.smethod_0(this.int_6, 19));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16034);
		binaryStream_0.smethod_7(this.Status);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_4(this.SfJggdscyf << 4 | U.smethod_0(this.SfJggdscyf, 28));
		binaryStream_0.smethod_4(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		binaryStream_0.smethod_4(this.int_3 << 13 | U.smethod_0(this.int_3, 19));
		binaryStream_0.smethod_7(this.int_4);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 10) | this.int_5 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 13) | this.int_6 << 19);
	}

	public int Status;

	public int int_0;

	public int SfJggdscyf;

	public int int_1;

	public string string_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;
}
