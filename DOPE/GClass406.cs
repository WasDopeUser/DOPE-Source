using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass406 : GClass402, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3653;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass406(string string_2 = "", string string_3 = "", int int_2 = 0, int int_3 = 0, GClass548 gclass548_1 = null, GClass433 gclass433_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_1 = string_2;
		this.string_0 = string_3;
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
		return 3653;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.gclass433_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass433);
		this.gclass433_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass548_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass548);
		this.gclass548_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3653);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.gclass433_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-5496);
		this.gclass548_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-6562);
		binaryStream_0.smethod_4(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.smethod_3(this.string_1);
	}

	public string string_0;

	public int int_0;

	public GClass433 gclass433_0;

	public GClass548 gclass548_0;

	public int int_1;

	public string string_1;
}
