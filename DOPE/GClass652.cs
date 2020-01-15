using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass652 : GClass651, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24363;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass652(int int_0 = 0, uint uint_1 = 0U)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.MapId = int_0;
		this.uint_0 = uint_1;
	}

	public override int vmethod_0()
	{
		return 24363;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 3 | U.smethod_0(this.MapId, 29));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24363);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 3) | this.MapId << 29);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public int MapId;

	public uint uint_0;
}
