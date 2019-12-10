using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass587 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5397;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 56;
		}
	}

	public GClass587(bool bool_24 = false, bool bool_25 = false, bool bool_26 = false, bool bool_27 = false, bool bool_28 = false, bool bool_29 = false, bool bool_30 = false, bool bool_31 = false, bool bool_32 = false, bool bool_33 = false, bool bool_34 = false, bool bool_35 = false, bool bool_36 = false, bool bool_37 = false, bool bool_38 = false, bool bool_39 = false, bool bool_40 = false, bool bool_41 = false, bool bool_42 = false, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, bool bool_43 = false, bool bool_44 = false, bool bool_45 = false, bool bool_46 = false, bool bool_47 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.bool_18 = bool_24;
		this.bool_14 = bool_25;
		this.bool_22 = bool_26;
		this.bool_0 = bool_27;
		this.bool_13 = bool_28;
		this.bool_19 = bool_29;
		this.bool_1 = bool_30;
		this.bool_20 = bool_31;
		this.bool_16 = bool_32;
		this.bool_17 = bool_33;
		this.bool_2 = bool_34;
		this.bool_5 = bool_35;
		this.bool_10 = bool_36;
		this.bool_12 = bool_37;
		this.bool_23 = bool_38;
		this.bool_11 = bool_39;
		this.bool_15 = bool_40;
		this.bool_4 = bool_41;
		this.bool_6 = bool_42;
		this.int_7 = int_8;
		this.int_1 = int_9;
		this.int_0 = int_10;
		this.int_5 = int_11;
		this.int_3 = int_12;
		this.int_2 = int_13;
		this.int_4 = int_14;
		this.int_6 = int_15;
		this.bool_9 = bool_43;
		this.bool_7 = bool_44;
		this.bool_8 = bool_45;
		this.bool_3 = bool_46;
		this.bool_21 = bool_47;
	}

	public virtual int vmethod_0()
	{
		return 5397;
	}

	public virtual int vmethod_1()
	{
		return 56;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
		this.bool_5 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		this.bool_6 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 2) | this.int_3 << 30);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 10 | U.smethod_0(this.int_4, 22));
		this.bool_7 = binaryStream_0.ReadBoolean();
		this.bool_8 = binaryStream_0.ReadBoolean();
		this.bool_9 = binaryStream_0.ReadBoolean();
		this.bool_10 = binaryStream_0.ReadBoolean();
		this.bool_11 = binaryStream_0.ReadBoolean();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 8) | this.int_5 << 24);
		this.bool_12 = binaryStream_0.ReadBoolean();
		this.bool_13 = binaryStream_0.ReadBoolean();
		this.bool_14 = binaryStream_0.ReadBoolean();
		this.bool_15 = binaryStream_0.ReadBoolean();
		this.bool_16 = binaryStream_0.ReadBoolean();
		this.bool_17 = binaryStream_0.ReadBoolean();
		this.bool_18 = binaryStream_0.ReadBoolean();
		this.bool_19 = binaryStream_0.ReadBoolean();
		this.bool_20 = binaryStream_0.ReadBoolean();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 4 | U.smethod_0(this.int_6, 28));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 8) | this.int_7 << 24);
		this.bool_21 = binaryStream_0.ReadBoolean();
		this.bool_22 = binaryStream_0.ReadBoolean();
		this.bool_23 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5397);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.fUeiimuocMk(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.WriteBoolean(this.bool_5);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.WriteBoolean(this.bool_6);
		binaryStream_0.fUeiimuocMk(this.int_3 << 2 | U.smethod_0(this.int_3, 30));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 10) | this.int_4 << 22);
		binaryStream_0.WriteBoolean(this.bool_7);
		binaryStream_0.WriteBoolean(this.bool_8);
		binaryStream_0.WriteBoolean(this.bool_9);
		binaryStream_0.WriteBoolean(this.bool_10);
		binaryStream_0.WriteBoolean(this.bool_11);
		binaryStream_0.fUeiimuocMk(this.int_5 << 8 | U.smethod_0(this.int_5, 24));
		binaryStream_0.WriteBoolean(this.bool_12);
		binaryStream_0.WriteBoolean(this.bool_13);
		binaryStream_0.WriteBoolean(this.bool_14);
		binaryStream_0.WriteBoolean(this.bool_15);
		binaryStream_0.WriteBoolean(this.bool_16);
		binaryStream_0.WriteBoolean(this.bool_17);
		binaryStream_0.WriteBoolean(this.bool_18);
		binaryStream_0.WriteBoolean(this.bool_19);
		binaryStream_0.WriteBoolean(this.bool_20);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_6, 4) | this.int_6 << 28);
		binaryStream_0.fUeiimuocMk(this.int_7 << 8 | U.smethod_0(this.int_7, 24));
		binaryStream_0.WriteBoolean(this.bool_21);
		binaryStream_0.WriteBoolean(this.bool_22);
		binaryStream_0.WriteBoolean(this.bool_23);
	}

	public int int_0;

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public int int_1;

	public bool bool_3;

	public bool bool_4;

	public bool bool_5;

	public int int_2;

	public bool bool_6;

	public int int_3;

	public int int_4;

	public bool bool_7;

	public bool bool_8;

	public bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public int int_5;

	public bool bool_12;

	public bool bool_13;

	public bool bool_14;

	public bool bool_15;

	public bool bool_16;

	public bool bool_17;

	public bool bool_18;

	public bool bool_19;

	public bool bool_20;

	public int int_6;

	public int int_7;

	public bool bool_21;

	public bool bool_22;

	public bool bool_23;
}
