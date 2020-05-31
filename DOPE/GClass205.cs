using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass205 : GClass198, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22248;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass205(int int_1 = 0, int int_2 = 0, int int_3 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
		this.ByBszpfmUm = int_3;
	}

	public override int vmethod_0()
	{
		return 22248;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.ByBszpfmUm = binaryStream_0.smethod_0();
		this.ByBszpfmUm = (this.ByBszpfmUm << 10 | U.smethod_0(this.ByBszpfmUm, 22));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 1) | this.MapId << 31);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22248);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.ByBszpfmUm, 10) | this.ByBszpfmUm << 22);
		binaryStream_0.smethod_4(this.MapId << 1 | U.smethod_0(this.MapId, 31));
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_7(-18347);
	}

	public int ByBszpfmUm;

	public int MapId;

	public int int_0;
}
