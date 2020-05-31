using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass413 : GClass409, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7811;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass413(string string_2 = "", string string_3 = "", int int_2 = 0, int int_3 = 0, GClass564 gclass564_1 = null, GClass441 gclass441_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (gclass564_1 == null)
		{
			this.gclass564_0 = new GClass564(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass564_0 = gclass564_1;
		}
		if (gclass441_1 == null)
		{
			this.gclass441_0 = new GClass441(0, 0U);
			return;
		}
		this.gclass441_0 = gclass441_1;
	}

	public override int vmethod_0()
	{
		return 7811;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.gclass564_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass564);
		this.gclass564_0.HrqIugnatr8(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_1();
		this.gclass441_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass441);
		this.gclass441_0.HrqIugnatr8(binaryStream_0);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7811);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.gclass564_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.smethod_7(13468);
		this.gclass441_0.imethod_1(binaryStream_0);
	}

	public string string_0;

	public string string_1;

	public int int_0;

	public GClass564 gclass564_0;

	public int int_1;

	public GClass441 gclass441_0;
}
