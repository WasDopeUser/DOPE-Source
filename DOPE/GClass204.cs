using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass204 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21185;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass204(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.MapId = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
	}

	public override int vmethod_0()
	{
		return 21185;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 15 | U.smethod_0(this.MapId, 17));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21185);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 15) | this.MapId << 17);
		binaryStream_0.smethod_7(-27254);
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
	}

	public int int_0;

	public int MapId;

	public int int_1;
}
