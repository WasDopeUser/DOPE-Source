using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass388 : GClass387, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16903;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass388(uint uint_0 = 0U, int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.fauLonwUil = uint_0;
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 16903;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_1();
		this.fauLonwUil = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16903);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_7(24724);
		binaryStream_0.smethod_6(this.fauLonwUil);
	}

	public int int_0;

	public uint fauLonwUil;
}
