using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass204 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26425;
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
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public override int vmethod_0()
	{
		return 26425;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 16 | U.smethod_0(this.MapId, 16));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(26425);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.MapId, 16) | this.MapId << 16);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public int MapId;

	public int int_0;

	public int int_1;
}
