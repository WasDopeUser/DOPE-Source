using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass217 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 49;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 126;
		}
	}

	public GClass217(int int_18 = 0, string string_3 = "", string string_4 = "", int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0, int int_26 = 0, int int_27 = 0, int int_28 = 0, int int_29 = 0, int int_30 = 0, int int_31 = 0, int int_32 = 0, int int_33 = 0, bool bool_3 = false, double double_1 = 0.0, double double_2 = 0.0, int int_34 = 0, double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_35 = 0, string string_5 = "", int int_36 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, Vector<GClass187> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_0 = int_18;
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.int_1 = int_19;
		this.int_2 = int_20;
		this.int_3 = int_21;
		this.int_4 = int_22;
		this.int_5 = int_23;
		this.int_6 = int_24;
		this.int_7 = int_25;
		this.int_8 = int_26;
		this.int_9 = int_27;
		this.int_10 = int_28;
		this.int_11 = int_29;
		this.MapId = int_30;
		this.int_12 = int_31;
		this.int_13 = int_32;
		this.int_14 = int_33;
		this.bool_0 = bool_3;
		this.Experience = double_1;
		this.Honor = double_2;
		this.int_15 = int_34;
		this.Credits = double_3;
		this.Uridium = double_4;
		this.double_0 = double_5;
		this.int_16 = int_35;
		this.string_2 = string_5;
		this.int_17 = int_36;
		this.bool_1 = bool_4;
		this.bool_2 = bool_5;
		this.Reset = bool_6;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass187>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 49;
	}

	public virtual int vmethod_1()
	{
		return 126;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 13 | U.smethod_0(this.int_3, 19));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 9 | U.smethod_0(this.int_4, 23));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 15 | U.smethod_0(this.int_5, 17));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 10 | U.smethod_0(this.int_6, 22));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 14) | this.int_7 << 18);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 11) | this.int_8 << 21);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 15) | this.int_9 << 17);
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 14) | this.int_10 << 18);
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 4) | this.int_11 << 28);
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 11 | U.smethod_0(this.MapId, 21));
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 5 | U.smethod_0(this.int_12, 27));
		this.int_13 = binaryStream_0.smethod_0();
		this.int_13 = (U.smethod_0(this.int_13, 3) | this.int_13 << 29);
		this.int_14 = binaryStream_0.smethod_0();
		this.int_14 = (U.smethod_0(this.int_14, 5) | this.int_14 << 27);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Experience = binaryStream_0.ReadDouble();
		this.Honor = binaryStream_0.ReadDouble();
		this.int_15 = binaryStream_0.smethod_0();
		this.int_15 = (U.smethod_0(this.int_15, 15) | this.int_15 << 17);
		this.Credits = binaryStream_0.ReadDouble();
		this.Uridium = binaryStream_0.ReadDouble();
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_16 = binaryStream_0.smethod_0();
		this.int_16 = (this.int_16 << 14 | U.smethod_0(this.int_16, 18));
		this.string_2 = binaryStream_0.smethod_2();
		this.int_17 = binaryStream_0.smethod_0();
		this.int_17 = (this.int_17 << 5 | U.smethod_0(this.int_17, 27));
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.Reset = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass187 gclass = (GClass187)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(49);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 13) | this.int_3 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 9) | this.int_4 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 15) | this.int_5 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 10) | this.int_6 << 22);
		binaryStream_0.smethod_4(this.int_7 << 14 | U.smethod_0(this.int_7, 18));
		binaryStream_0.smethod_4(this.int_8 << 11 | U.smethod_0(this.int_8, 21));
		binaryStream_0.smethod_4(this.int_9 << 15 | U.smethod_0(this.int_9, 17));
		binaryStream_0.smethod_4(this.int_10 << 14 | U.smethod_0(this.int_10, 18));
		binaryStream_0.smethod_4(this.int_11 << 4 | U.smethod_0(this.int_11, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 11) | this.MapId << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_12, 5) | this.int_12 << 27);
		binaryStream_0.smethod_4(this.int_13 << 3 | U.smethod_0(this.int_13, 29));
		binaryStream_0.smethod_4(this.int_14 << 5 | U.smethod_0(this.int_14, 27));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteDouble(this.Experience);
		binaryStream_0.WriteDouble(this.Honor);
		binaryStream_0.smethod_4(this.int_15 << 15 | U.smethod_0(this.int_15, 17));
		binaryStream_0.WriteDouble(this.Credits);
		binaryStream_0.WriteDouble(this.Uridium);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_16, 14) | this.int_16 << 18);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_17, 5) | this.int_17 << 27);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.Reset);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass187 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public int int_0;

	public string string_0;

	public string string_1;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int MapId;

	public int int_12;

	public int int_13;

	public int int_14;

	public bool bool_0;

	public double Experience;

	public double Honor;

	public int int_15;

	public double Credits;

	public double Uridium;

	public double double_0;

	public int int_16;

	public string string_2;

	public int int_17;

	public bool bool_1;

	public bool bool_2;

	public bool Reset;

	public Vector<GClass187> vector_0;
}
