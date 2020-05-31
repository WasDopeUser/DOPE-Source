using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass220 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16206;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 126;
		}
	}

	public GClass220(int int_18 = 0, string string_2 = "", string string_3 = "", int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0, int int_26 = 0, int int_27 = 0, int int_28 = 0, int int_29 = 0, int int_30 = 0, int int_31 = 0, int int_32 = 0, int int_33 = 0, bool bool_3 = false, double double_1 = 0.0, double double_2 = 0.0, int int_34 = 0, double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_35 = 0, string string_4 = "", int int_36 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, Vector<GClass187> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		this.PqfpYrsegr = "";
		base..ctor();
		this.int_7 = int_18;
		this.string_1 = string_2;
		this.string_0 = string_3;
		this.int_9 = int_19;
		this.int_12 = int_20;
		this.int_1 = int_21;
		this.int_2 = int_22;
		this.int_14 = int_23;
		this.int_16 = int_24;
		this.int_15 = int_25;
		this.int_10 = int_26;
		this.int_11 = int_27;
		this.int_13 = int_28;
		this.int_17 = int_29;
		this.MapId = int_30;
		this.int_0 = int_31;
		this.int_5 = int_32;
		this.int_6 = int_33;
		this.bool_2 = bool_3;
		this.Experience = double_1;
		this.Honor = double_2;
		this.int_4 = int_34;
		this.Credits = double_3;
		this.Uridium = double_4;
		this.double_0 = double_5;
		this.int_8 = int_35;
		this.PqfpYrsegr = string_4;
		this.int_3 = int_36;
		this.bool_0 = bool_4;
		this.bool_1 = bool_5;
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
		return 16206;
	}

	public virtual int vmethod_1()
	{
		return 126;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Experience = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass187 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass187;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Credits = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 5 | U.smethod_0(this.int_4, 27));
		this.Honor = binaryStream_0.ReadDouble();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 5) | this.int_5 << 27);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 8 | U.smethod_0(this.int_6, 24));
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 10) | this.int_7 << 22);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 3) | this.int_8 << 29);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 8 | U.smethod_0(this.int_9, 24));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 2) | this.int_10 << 30);
		this.Uridium = binaryStream_0.ReadDouble();
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (this.int_11 << 1 | U.smethod_0(this.int_11, 31));
		this.Reset = binaryStream_0.ReadBoolean();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 1) | this.MapId << 31);
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 14 | U.smethod_0(this.int_12, 18));
		this.int_13 = binaryStream_0.smethod_0();
		this.int_13 = (this.int_13 << 13 | U.smethod_0(this.int_13, 19));
		this.int_14 = binaryStream_0.smethod_0();
		this.int_14 = (U.smethod_0(this.int_14, 12) | this.int_14 << 20);
		this.int_15 = binaryStream_0.smethod_0();
		this.int_15 = (this.int_15 << 7 | U.smethod_0(this.int_15, 25));
		binaryStream_0.smethod_1();
		this.int_16 = binaryStream_0.smethod_0();
		this.int_16 = (this.int_16 << 16 | U.smethod_0(this.int_16, 16));
		this.PqfpYrsegr = binaryStream_0.smethod_2();
		this.int_17 = binaryStream_0.smethod_0();
		this.int_17 = (U.smethod_0(this.int_17, 9) | this.int_17 << 23);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16206);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.Experience);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass187 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.Credits);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_4(this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 5) | this.int_4 << 27);
		binaryStream_0.WriteDouble(this.Honor);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_5 << 5 | U.smethod_0(this.int_5, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 8) | this.int_6 << 24);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(this.int_7 << 10 | U.smethod_0(this.int_7, 22));
		binaryStream_0.smethod_4(this.int_8 << 3 | U.smethod_0(this.int_8, 29));
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 8) | this.int_9 << 24);
		binaryStream_0.smethod_4(this.int_10 << 2 | U.smethod_0(this.int_10, 30));
		binaryStream_0.WriteDouble(this.Uridium);
		binaryStream_0.smethod_4(U.smethod_0(this.int_11, 1) | this.int_11 << 31);
		binaryStream_0.WriteBoolean(this.Reset);
		binaryStream_0.smethod_4(this.MapId << 1 | U.smethod_0(this.MapId, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_12, 14) | this.int_12 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_13, 13) | this.int_13 << 19);
		binaryStream_0.smethod_4(this.int_14 << 12 | U.smethod_0(this.int_14, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_15, 7) | this.int_15 << 25);
		binaryStream_0.smethod_7(-7569);
		binaryStream_0.smethod_4(U.smethod_0(this.int_16, 16) | this.int_16 << 16);
		binaryStream_0.smethod_3(this.PqfpYrsegr);
		binaryStream_0.smethod_4(this.int_17 << 9 | U.smethod_0(this.int_17, 23));
	}

	public double Experience;

	public string string_0;

	public Vector<GClass187> vector_0;

	public double Credits;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;

	public int int_4;

	public double Honor;

	public string string_1;

	public int int_5;

	public int int_6;

	public bool bool_1;

	public double double_0;

	public int int_7;

	public int int_8;

	public bool bool_2;

	public int int_9;

	public int int_10;

	public double Uridium;

	public int int_11;

	public bool Reset;

	public int MapId;

	public int int_12;

	public int int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public string PqfpYrsegr;

	public int int_17;
}
