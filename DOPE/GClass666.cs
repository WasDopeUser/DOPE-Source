using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass666 : GClass662, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23681;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass666(string string_1 = "", int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor(string_1);
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 23681;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(23681);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-20824);
		binaryStream_0.smethod_3(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_6(5949);
	}

	public int int_0;
}
