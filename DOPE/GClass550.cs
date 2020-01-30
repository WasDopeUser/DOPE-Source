using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass550 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21581;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass550(int int_12 = 0, int int_13 = 0, string string_1 = "", bool bool_2 = false, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, GClass709 gclass709_1 = null, bool bool_3 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.int_10 = int_12;
		this.int_4 = int_13;
		this.string_0 = string_1;
		this.bool_1 = bool_2;
		this.int_7 = int_14;
		this.int_0 = int_15;
		this.int_2 = int_16;
		this.int_3 = int_17;
		this.int_8 = int_18;
		this.int_1 = int_19;
		this.int_6 = int_20;
		this.int_5 = int_21;
		this.int_9 = int_22;
		this.int_11 = int_23;
		if (gclass709_1 == null)
		{
			this.gclass709_0 = new GClass709(null);
		}
		else
		{
			this.gclass709_0 = gclass709_1;
		}
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 21581;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.gclass709_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass709);
		this.gclass709_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 6 | U.smethod_0(this.int_4, 26));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 16 | U.smethod_0(this.int_6, 16));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 10) | this.int_7 << 22);
		binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 10 | U.smethod_0(this.int_8, 22));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 9) | this.int_9 << 23);
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 15 | U.smethod_0(this.int_10, 17));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (this.int_11 << 12 | U.smethod_0(this.int_11, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21581);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.gclass709_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_7(-12825);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 6) | this.int_4 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 16) | this.int_6 << 16);
		binaryStream_0.smethod_4(this.int_7 << 10 | U.smethod_0(this.int_7, 22));
		binaryStream_0.smethod_7(26328);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 10) | this.int_8 << 22);
		binaryStream_0.smethod_4(this.int_9 << 9 | U.smethod_0(this.int_9, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_10, 15) | this.int_10 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_11, 12) | this.int_11 << 20);
	}

	public int int_0;

	public GClass709 gclass709_0;

	public string string_0;

	public bool bool_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public bool bool_1;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;
}
