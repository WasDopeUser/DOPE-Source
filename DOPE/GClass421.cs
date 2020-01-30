using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass421 : GClass420, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29167;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass421(string string_1 = "", bool bool_1 = false, GClass359 gclass359_1 = null, string string_2 = "", int int_2 = 0, int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_2 = false, GClass359 gclass359_2 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.xsUeWashvg = "";
		base..ctor(string_1, bool_1, gclass359_1);
		this.xsUeWashvg = string_2;
		this.int_0 = int_2;
		this.pFmeUhwTy4 = int_3;
		this.Width = int_4;
		this.int_1 = int_5;
		this.bool_0 = bool_2;
		if (gclass359_2 == null)
		{
			this.gclass359_0 = new GClass359(null);
			return;
		}
		this.gclass359_0 = gclass359_2;
	}

	public override int vmethod_0()
	{
		return 29167;
	}

	public override int vmethod_1()
	{
		return 25;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.xsUeWashvg = binaryStream_0.smethod_2();
		this.Width = binaryStream_0.smethod_0();
		this.Width = (U.smethod_0(this.Width, 8) | this.Width << 24);
		binaryStream_0.smethod_1();
		this.pFmeUhwTy4 = binaryStream_0.smethod_0();
		this.pFmeUhwTy4 = (U.smethod_0(this.pFmeUhwTy4, 3) | this.pFmeUhwTy4 << 29);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_1();
		this.gclass359_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.gclass359_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29167);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.xsUeWashvg);
		binaryStream_0.smethod_4(this.Width << 8 | U.smethod_0(this.Width, 24));
		binaryStream_0.smethod_7(30599);
		binaryStream_0.smethod_4(this.pFmeUhwTy4 << 3 | U.smethod_0(this.pFmeUhwTy4, 29));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_7(-11708);
		this.gclass359_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public string xsUeWashvg;

	public int Width;

	public int pFmeUhwTy4;

	public bool bool_0;

	public int int_0;

	public GClass359 gclass359_0;

	public int int_1;
}
