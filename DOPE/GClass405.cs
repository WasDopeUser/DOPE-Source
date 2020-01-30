using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass405 : GClass401, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27552;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass405(string string_2 = "", string string_3 = "", int int_2 = 0, int int_3 = 0, GClass549 gclass549_1 = null, GClass432 gclass432_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (gclass549_1 == null)
		{
			this.gclass549_0 = new GClass549(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass549_0 = gclass549_1;
		}
		if (gclass432_1 == null)
		{
			this.gclass432_0 = new GClass432(0, 0U);
			return;
		}
		this.gclass432_0 = gclass432_1;
	}

	public override int vmethod_0()
	{
		return 27552;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass432_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass432);
		this.gclass432_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass549_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass549);
		this.gclass549_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27552);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		this.gclass432_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-3091);
		this.gclass549_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
	}

	public int int_0;

	public string string_0;

	public string string_1;

	public GClass432 gclass432_0;

	public GClass549 gclass549_0;

	public int int_1;
}
