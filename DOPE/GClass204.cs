using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass204 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22060;
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
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.MapId = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
	}

	public override int vmethod_0()
	{
		return 22060;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 9) | this.MapId << 23);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22060);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(202);
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_4(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.smethod_4(this.MapId << 9 | U.smethod_0(this.MapId, 23));
	}

	public int int_0;

	public int int_1;

	public int MapId;
}
