using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass653 : GClass652, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1123;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass653(int int_0 = 0, uint uint_1 = 0U)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.MapId = int_0;
		this.uint_0 = uint_1;
	}

	public override int vmethod_0()
	{
		return 1123;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 14) | this.MapId << 18);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1123);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.MapId << 14 | U.smethod_0(this.MapId, 18));
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(1826);
	}

	public int MapId;

	public uint uint_0;
}
