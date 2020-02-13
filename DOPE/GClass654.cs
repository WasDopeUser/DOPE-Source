using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass654 : GClass653, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23852;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass654(int int_0 = 0, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_0;
		this.uint_0 = uint_1;
	}

	public override int vmethod_0()
	{
		return 23852;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 13) | this.MapId << 19);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(23852);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(21929);
		binaryStream_0.smethod_6(10930);
		binaryStream_0.smethod_3(this.MapId << 13 | U.smethod_0(this.MapId, 19));
		binaryStream_0.smethod_5(this.uint_0);
	}

	public int MapId;

	public uint uint_0;
}
