using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass261 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 266;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 55;
		}
	}

	public GClass261(bool bool_21 = false, bool bool_22 = false, bool bool_23 = false, bool bool_24 = false, bool bool_25 = false, bool bool_26 = false, bool bool_27 = false, bool bool_28 = false, bool bool_29 = false, bool bool_30 = false, bool bool_31 = false, bool bool_32 = false, bool bool_33 = false, bool bool_34 = false, bool bool_35 = false, bool bool_36 = false, bool bool_37 = false, bool bool_38 = false, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, bool bool_39 = false, bool bool_40 = false, bool bool_41 = false, bool bool_42 = false, bool bool_43 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.bool_0 = bool_21;
		this.bool_1 = bool_22;
		this.bool_2 = bool_23;
		this.bool_3 = bool_24;
		this.bool_4 = bool_25;
		this.bool_5 = bool_26;
		this.bool_6 = bool_27;
		this.bool_7 = bool_28;
		this.bool_8 = bool_29;
		this.bool_9 = bool_30;
		this.bool_10 = bool_31;
		this.bool_11 = bool_32;
		this.wPouWwMoqk = bool_33;
		this.bool_12 = bool_34;
		this.bool_13 = bool_35;
		this.bool_14 = bool_36;
		this.bool_15 = bool_37;
		this.bool_16 = bool_38;
		this.int_0 = int_8;
		this.int_1 = int_9;
		this.int_2 = int_10;
		this.int_3 = int_11;
		this.int_4 = int_12;
		this.int_5 = int_13;
		this.int_6 = int_14;
		this.int_7 = int_15;
		this.ajjuhvNsms = bool_39;
		this.bool_17 = bool_40;
		this.bool_18 = bool_41;
		this.bool_19 = bool_42;
		this.bool_20 = bool_43;
	}

	public virtual int vmethod_0()
	{
		return 266;
	}

	public virtual int vmethod_1()
	{
		return 55;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
		this.bool_5 = binaryStream_0.ReadBoolean();
		this.bool_6 = binaryStream_0.ReadBoolean();
		this.bool_7 = binaryStream_0.ReadBoolean();
		this.bool_8 = binaryStream_0.ReadBoolean();
		this.bool_9 = binaryStream_0.ReadBoolean();
		this.bool_10 = binaryStream_0.ReadBoolean();
		this.bool_11 = binaryStream_0.ReadBoolean();
		this.wPouWwMoqk = binaryStream_0.ReadBoolean();
		this.bool_12 = binaryStream_0.ReadBoolean();
		this.bool_13 = binaryStream_0.ReadBoolean();
		this.bool_14 = binaryStream_0.ReadBoolean();
		this.bool_15 = binaryStream_0.ReadBoolean();
		this.bool_16 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 2 | U.smethod_0(this.int_4, 30));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 4 | U.smethod_0(this.int_5, 28));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 1) | this.int_6 << 31);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 8) | this.int_7 << 24);
		this.ajjuhvNsms = binaryStream_0.ReadBoolean();
		this.bool_17 = binaryStream_0.ReadBoolean();
		this.bool_18 = binaryStream_0.ReadBoolean();
		this.bool_19 = binaryStream_0.ReadBoolean();
		this.bool_20 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(266);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.WriteBoolean(this.bool_5);
		binaryStream_0.WriteBoolean(this.bool_6);
		binaryStream_0.WriteBoolean(this.bool_7);
		binaryStream_0.WriteBoolean(this.bool_8);
		binaryStream_0.WriteBoolean(this.bool_9);
		binaryStream_0.WriteBoolean(this.bool_10);
		binaryStream_0.WriteBoolean(this.bool_11);
		binaryStream_0.WriteBoolean(this.wPouWwMoqk);
		binaryStream_0.WriteBoolean(this.bool_12);
		binaryStream_0.WriteBoolean(this.bool_13);
		binaryStream_0.WriteBoolean(this.bool_14);
		binaryStream_0.WriteBoolean(this.bool_15);
		binaryStream_0.WriteBoolean(this.bool_16);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		binaryStream_0.smethod_4(this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 2) | this.int_4 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 4) | this.int_5 << 28);
		binaryStream_0.smethod_4(this.int_6 << 1 | U.smethod_0(this.int_6, 31));
		binaryStream_0.smethod_4(this.int_7 << 8 | U.smethod_0(this.int_7, 24));
		binaryStream_0.WriteBoolean(this.ajjuhvNsms);
		binaryStream_0.WriteBoolean(this.bool_17);
		binaryStream_0.WriteBoolean(this.bool_18);
		binaryStream_0.WriteBoolean(this.bool_19);
		binaryStream_0.WriteBoolean(this.bool_20);
	}

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4;

	public bool bool_5;

	public bool bool_6;

	public bool bool_7;

	public bool bool_8;

	public bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool wPouWwMoqk;

	public bool bool_12;

	public bool bool_13;

	public bool bool_14;

	public bool bool_15;

	public bool bool_16;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public bool ajjuhvNsms;

	public bool bool_17;

	public bool bool_18;

	public bool bool_19;

	public bool bool_20;
}
