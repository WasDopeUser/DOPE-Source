using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass204 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31125;
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
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_3;
		this.MapId = int_2;
	}

	public override int vmethod_0()
	{
		return 31125;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 5 | U.smethod_0(this.MapId, 27));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31125);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 5) | this.MapId << 27);
	}

	public int int_0;

	public int int_1;

	public int MapId;
}
