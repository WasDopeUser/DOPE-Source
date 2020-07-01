using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass774 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -13264;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass774(int int_3 = 0, int int_4 = 0, string string_3 = "", int int_5 = 0, string string_4 = "", string string_5 = "")
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_5;
		this.int_2 = int_4;
		this.string_0 = string_4;
		this.string_1 = string_5;
		this.string_2 = string_3;
	}

	public virtual int vmethod_0()
	{
		return -13264;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-13264);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_4(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public string string_1;

	public string string_2;
}
