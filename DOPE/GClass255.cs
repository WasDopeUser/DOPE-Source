using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass255 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20019;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass255(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", GClass139 gclass139_1 = null, int int_17 = 0, int int_18 = 0, int int_19 = 0, bool bool_2 = false, bool bool_3 = false, GClass760 gclass760_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_7 = int_10;
		this.int_3 = int_11;
		this.int_4 = int_12;
		this.int_2 = int_13;
		this.Name = string_1;
		this.int_5 = int_14;
		this.int_8 = int_15;
		this.int_9 = int_16;
		this.string_0 = string_2;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0U);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.int_6 = int_17;
		this.int_0 = int_18;
		this.int_1 = int_19;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		if (gclass760_1 == null)
		{
			this.gclass760_0 = new GClass760(0U);
			return;
		}
		this.gclass760_0 = gclass760_1;
	}

	public virtual int vmethod_0()
	{
		return 20019;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.Name = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.imethod_1(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		this.gclass760_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass760);
		this.gclass760_0.imethod_1(binaryStream_0);
		this.int_4 = (int)binaryStream_0.smethod_1();
		this.int_5 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 15 | U.smethod_0(this.int_6, 17));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 16) | this.int_7 << 16);
		this.bool_1 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 15 | U.smethod_0(this.int_8, 17));
		this.int_9 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20019);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.int_2);
		this.gclass139_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		this.gclass760_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(this.int_4);
		binaryStream_0.smethod_7(this.int_5);
		binaryStream_0.smethod_7(8501);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 15) | this.int_6 << 17);
		binaryStream_0.smethod_4(this.int_7 << 16 | U.smethod_0(this.int_7, 16));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_7(-6219);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 15) | this.int_8 << 17);
		binaryStream_0.smethod_7(this.int_9);
	}

	public int int_0;

	public string Name;

	public bool bool_0;

	public int int_1;

	public string string_0;

	public int int_2;

	public GClass139 gclass139_0;

	public int int_3;

	public GClass760 gclass760_0;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public bool bool_1;

	public int int_8;

	public int int_9;
}
