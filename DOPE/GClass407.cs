using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass407 : GClass406, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10667;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass407(string string_2 = "", bool bool_1 = false, GClass343 gclass343_1 = null, string string_3 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, GClass343 gclass343_2 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_1 = "";
		base..ctor(string_2, bool_1, gclass343_1);
		this.string_1 = string_3;
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.Width = int_5;
		this.int_2 = int_6;
		this.bool_0 = bool_2;
		if (gclass343_2 == null)
		{
			this.gclass343_0 = new GClass343(null);
			return;
		}
		this.gclass343_0 = gclass343_2;
	}

	public override int vmethod_0()
	{
		return 10667;
	}

	public override int vmethod_1()
	{
		return 25;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.gclass343_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass343);
		this.gclass343_0.imethod_1(binaryStream_0);
		this.Width = binaryStream_0.smethod_0();
		this.Width = (this.Width << 5 | U.smethod_0(this.Width, 27));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(10667);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.fUeiimuocMk(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.gclass343_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Width, 5) | this.Width << 27);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		binaryStream_0.smethod_5(2854);
	}

	public string string_1;

	public int int_0;

	public GClass343 gclass343_0;

	public int Width;

	public bool bool_0;

	public int int_1;

	public int int_2;
}
