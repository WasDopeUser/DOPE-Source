using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass183 : GClass180, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -7014;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass183(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(string_1, int_3, int_4);
		this.int_2 = int_5;
	}

	public override int vmethod_0()
	{
		return -7014;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-7014);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
	}

	public int int_2;
}
