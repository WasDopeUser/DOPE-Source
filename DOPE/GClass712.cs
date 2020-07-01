using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass712 : GClass708, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -11309;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass712(string string_1 = "", int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(string_1);
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return -11309;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-11309);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
	}

	public int int_0;
}
