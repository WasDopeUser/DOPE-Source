using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass259 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13882;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass259(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", GClass139 gclass139_1 = null, int int_17 = 0, int int_18 = 0, int int_19 = 0, bool bool_2 = false, bool bool_3 = false, GClass774 gclass774_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_5 = int_10;
		this.int_3 = int_11;
		this.int_9 = int_12;
		this.int_2 = int_13;
		this.Name = string_1;
		this.int_8 = int_14;
		this.int_0 = int_15;
		this.int_7 = int_16;
		this.string_0 = string_2;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0U);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.int_1 = int_17;
		this.int_6 = int_18;
		this.int_4 = int_19;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		if (gclass774_1 == null)
		{
			this.gclass774_0 = new GClass774(0U);
			return;
		}
		this.gclass774_0 = gclass774_1;
	}

	public virtual int vmethod_0()
	{
		return 13882;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.gclass774_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass774);
		this.gclass774_0.HrqIugnatr8(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 14) | this.int_3 << 18);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 4 | U.smethod_0(this.int_4, 28));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 9 | U.smethod_0(this.int_5, 23));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 13 | U.smethod_0(this.int_6, 19));
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.HrqIugnatr8(binaryStream_0);
		this.int_7 = (int)binaryStream_0.smethod_1();
		this.int_8 = (int)binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_9 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13882);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_7(32165);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.gclass774_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_7(this.int_2);
		binaryStream_0.smethod_4(this.int_3 << 14 | U.smethod_0(this.int_3, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 4) | this.int_4 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 9) | this.int_5 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 13) | this.int_6 << 19);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass139_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(this.int_7);
		binaryStream_0.smethod_7(this.int_8);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_7(this.int_9);
		binaryStream_0.smethod_7(7411);
	}

	public string Name;

	public bool bool_0;

	public int int_0;

	public GClass774 gclass774_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public string string_0;

	public GClass139 gclass139_0;

	public int int_7;

	public int int_8;

	public bool bool_1;

	public int int_9;
}
