using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass549 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27449;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass549(int int_12 = 0, int int_13 = 0, string string_1 = "", bool bool_2 = false, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, GClass708 gclass708_1 = null, bool bool_3 = false)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.int_10 = int_12;
		this.int_7 = int_13;
		this.string_0 = string_1;
		this.bool_0 = bool_2;
		this.int_2 = int_14;
		this.int_8 = int_15;
		this.int_4 = int_16;
		this.int_5 = int_17;
		this.int_6 = int_18;
		this.int_3 = int_19;
		this.int_9 = int_20;
		this.int_1 = int_21;
		this.int_0 = int_22;
		this.int_11 = int_23;
		if (gclass708_1 == null)
		{
			this.gclass708_0 = new GClass708(null);
		}
		else
		{
			this.gclass708_0 = gclass708_1;
		}
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 27449;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 14 | U.smethod_0(this.int_3, 18));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 10) | this.int_4 << 22);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.gclass708_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass708);
		this.gclass708_0.imethod_1(binaryStream_0);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 12 | U.smethod_0(this.int_5, 20));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 14) | this.int_6 << 18);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 14 | U.smethod_0(this.int_7, 18));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 7 | U.smethod_0(this.int_8, 25));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 14) | this.int_9 << 18);
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 4 | U.smethod_0(this.int_10, 28));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (this.int_11 << 12 | U.smethod_0(this.int_11, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27449);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_4(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		binaryStream_0.smethod_7(31460);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 14) | this.int_3 << 18);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_4 << 10 | U.smethod_0(this.int_4, 22));
		binaryStream_0.WriteBoolean(this.bool_1);
		this.gclass708_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 12) | this.int_5 << 20);
		binaryStream_0.smethod_4(this.int_6 << 14 | U.smethod_0(this.int_6, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 14) | this.int_7 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 7) | this.int_8 << 25);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_9 << 14 | U.smethod_0(this.int_9, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_10, 4) | this.int_10 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_11, 12) | this.int_11 << 20);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;

	public int int_4;

	public bool bool_1;

	public GClass708 gclass708_0;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public string string_0;

	public int int_9;

	public int int_10;

	public int int_11;
}
