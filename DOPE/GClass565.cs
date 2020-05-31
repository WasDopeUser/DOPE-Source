using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass565 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10478;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass565(int int_12 = 0, int int_13 = 0, string string_1 = "", bool bool_2 = false, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, GClass724 gclass724_1 = null, bool bool_3 = false)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.int_9 = int_12;
		this.int_7 = int_13;
		this.string_0 = string_1;
		this.bool_0 = bool_2;
		this.int_11 = int_14;
		this.int_6 = int_15;
		this.int_0 = int_16;
		this.int_2 = int_17;
		this.int_10 = int_18;
		this.int_8 = int_19;
		this.int_3 = int_20;
		this.int_1 = int_21;
		this.int_4 = int_22;
		this.int_5 = int_23;
		if (gclass724_1 == null)
		{
			this.gclass724_0 = new GClass724(null);
		}
		else
		{
			this.gclass724_0 = gclass724_1;
		}
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 10478;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 5 | U.smethod_0(this.int_4, 27));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 4) | this.int_5 << 28);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 8 | U.smethod_0(this.int_6, 24));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 11) | this.int_7 << 21);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 5) | this.int_8 << 27);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 11 | U.smethod_0(this.int_9, 21));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 4) | this.int_10 << 28);
		this.gclass724_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass724);
		this.gclass724_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (this.int_11 << 3 | U.smethod_0(this.int_11, 29));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10478);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.smethod_4(this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 5) | this.int_4 << 27);
		binaryStream_0.smethod_4(this.int_5 << 4 | U.smethod_0(this.int_5, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 8) | this.int_6 << 24);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_7 << 11 | U.smethod_0(this.int_7, 21));
		binaryStream_0.smethod_4(this.int_8 << 5 | U.smethod_0(this.int_8, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 11) | this.int_9 << 21);
		binaryStream_0.smethod_4(this.int_10 << 4 | U.smethod_0(this.int_10, 28));
		this.gclass724_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(3141);
		binaryStream_0.smethod_7(10043);
		binaryStream_0.smethod_4(U.smethod_0(this.int_11, 3) | this.int_11 << 29);
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_1;

	public int int_4;

	public int int_5;

	public int int_6;

	public string string_0;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public GClass724 gclass724_0;

	public int int_11;
}
