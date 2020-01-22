using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass406 : GClass402, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16586;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass406(string string_1 = "", string string_2 = "", int int_2 = 0, int int_3 = 0, GClass548 gclass548_1 = null, GClass433 gclass433_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.kuGgMycftU = "";
		this.string_0 = "";
		base..ctor();
		this.kuGgMycftU = string_1;
		this.string_0 = string_2;
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (gclass548_1 == null)
		{
			this.gclass548_0 = new GClass548(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass548_0 = gclass548_1;
		}
		if (gclass433_1 == null)
		{
			this.gclass433_0 = new GClass433(0, 0U);
			return;
		}
		this.gclass433_0 = gclass433_1;
	}

	public override int vmethod_0()
	{
		return 16586;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.kuGgMycftU = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass433_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass433);
		this.gclass433_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass548_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass548);
		this.gclass548_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16586);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_3(this.kuGgMycftU);
		binaryStream_0.smethod_7(-4207);
		this.gclass433_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(26588);
		this.gclass548_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
	}

	public int int_0;

	public string kuGgMycftU;

	public GClass433 gclass433_0;

	public string string_0;

	public GClass548 gclass548_0;

	public int int_1;
}
