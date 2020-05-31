using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass668 : GClass667, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16079;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass668(int int_0 = 0, uint uint_1 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.MapId = int_0;
		this.uint_0 = uint_1;
	}

	public override int vmethod_0()
	{
		return 16079;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 5) | this.MapId << 27);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16079);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-30448);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.MapId << 5 | U.smethod_0(this.MapId, 27));
	}

	public uint uint_0;

	public int MapId;
}
