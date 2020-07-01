using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass378 : GClass376, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1725;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass378(string string_1 = "", int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 1725;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1725);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
	}

	public string string_0;

	public int int_0;
}
