using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass495 : GClass488, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16144;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass495(int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 16144;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16144);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_7(-27747);
		binaryStream_0.smethod_7(12440);
	}

	public int int_0;
}
