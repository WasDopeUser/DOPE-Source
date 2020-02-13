using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass423 : GClass422, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11036;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass423(string string_2 = "", bool bool_1 = false, GClass361 gclass361_1 = null, string string_3 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, GClass361 gclass361_2 = null)
	{
		Class13.igxcIukzfpare();
		this.string_1 = "";
		base..ctor(string_2, bool_1, gclass361_1);
		this.string_1 = string_3;
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.Width = int_5;
		this.int_0 = int_6;
		this.bool_0 = bool_2;
		if (gclass361_2 == null)
		{
			this.gclass361_0 = new GClass361(null);
			return;
		}
		this.gclass361_0 = gclass361_2;
	}

	public override int vmethod_0()
	{
		return 11036;
	}

	public override int vmethod_1()
	{
		return 25;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass361_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361);
		this.gclass361_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.Width = binaryStream_0.smethod_0();
		this.Width = (this.Width << 16 | U.smethod_0(this.Width, 16));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11036);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		this.gclass361_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(1883);
		binaryStream_0.smethod_3(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_3(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(28653);
		binaryStream_0.smethod_3(U.smethod_0(this.Width, 16) | this.Width << 16);
	}

	public int int_0;

	public string string_1;

	public GClass361 gclass361_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public int Width;
}
