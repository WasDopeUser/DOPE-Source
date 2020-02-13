using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass389 : GClass388, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1051;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass389(uint uint_1 = 0U, int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 1051;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1051);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_5(this.uint_0);
	}

	public int int_0;

	public uint uint_0;
}
