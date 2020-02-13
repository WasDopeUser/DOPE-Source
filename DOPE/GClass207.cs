using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass207 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27238;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass207(uint uint_0 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.ldwIvZeOfb = uint_0;
	}

	public override int vmethod_0()
	{
		return 27238;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.ldwIvZeOfb = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27238);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(this.ldwIvZeOfb);
		binaryStream_0.smethod_6(31914);
	}

	public uint ldwIvZeOfb;
}
