using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass429 : GClass428, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20450;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass429(string string_2 = "", bool bool_1 = false, GClass367 gclass367_1 = null, string string_3 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, GClass367 gclass367_2 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_1 = "";
		base..ctor(string_2, bool_1, gclass367_1);
		this.string_1 = string_3;
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.Width = int_5;
		this.int_1 = int_6;
		this.bool_0 = bool_2;
		if (gclass367_2 == null)
		{
			this.gclass367_0 = new GClass367(null);
			return;
		}
		this.gclass367_0 = gclass367_2;
	}

	public override int vmethod_0()
	{
		return 20450;
	}

	public override int vmethod_1()
	{
		return 25;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Width = binaryStream_0.smethod_0();
		this.Width = (this.Width << 14 | U.smethod_0(this.Width, 18));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.gclass367_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass367);
		this.gclass367_0.HrqIugnatr8(binaryStream_0);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20450);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Width, 14) | this.Width << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.gclass367_0.imethod_1(binaryStream_0);
	}

	public string string_1;

	public bool bool_0;

	public int Width;

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass367 gclass367_0;
}
