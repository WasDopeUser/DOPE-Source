using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass366 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -23669;
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
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_7;
		this.int_2 = int_5;
		this.string_0 = string_1;
		this.int_3 = int_6;
	}

	public virtual int vmethod_0()
	{
		return -23669;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 10 | U.smethod_0(this.int_3, 22));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-23669);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_4(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 10) | this.int_3 << 22);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public int int_3;
}
