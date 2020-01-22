using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass652 : GClass651, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12993;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass652(int int_0 = 0, uint uint_0 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.MapId = int_0;
		this.OyVgocdOiE = uint_0;
	}

	public override int vmethod_0()
	{
		return 12993;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 16) | this.MapId << 16);
		this.OyVgocdOiE = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12993);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-14337);
		binaryStream_0.smethod_4(this.MapId << 16 | U.smethod_0(this.MapId, 16));
		binaryStream_0.smethod_6(this.OyVgocdOiE);
	}

	public int MapId;

	public uint OyVgocdOiE;
}
