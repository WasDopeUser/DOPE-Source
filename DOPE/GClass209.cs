using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass209 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5638;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 126;
		}
	}

	public GClass209(int int_16 = 0, string string_3 = "", string string_4 = "", int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0, int int_26 = 0, int int_27 = 0, int int_28 = 0, int int_29 = 0, int int_30 = 0, int int_31 = 0, bool bool_3 = false, double double_1 = 0.0, double double_2 = 0.0, int int_32 = 0, double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_33 = 0, string string_5 = "", int int_34 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, Vector<GClass179> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_6 = int_16;
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.int_0 = int_17;
		this.int_4 = int_18;
		this.int_7 = int_19;
		this.int_2 = int_20;
		this.int_13 = int_21;
		this.EqbnNuLyng = int_22;
		this.int_12 = int_23;
		this.int_3 = int_24;
		this.int_11 = int_25;
		this.VbQnreasOv = int_26;
		this.int_8 = int_27;
		this.EuknhfatvF = int_28;
		this.int_5 = int_29;
		this.int_10 = int_30;
		this.int_14 = int_31;
		this.bool_1 = bool_3;
		this.Experience = double_1;
		this.Honor = double_2;
		this.int_1 = int_32;
		this.Credits = double_3;
		this.Uridium = double_4;
		this.double_0 = double_5;
		this.int_15 = int_33;
		this.string_2 = string_5;
		this.int_9 = int_34;
		this.bool_0 = bool_4;
		this.bool_2 = bool_5;
		this.Reset = bool_6;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass179>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 5638;
	}

	public virtual int vmethod_1()
	{
		return 126;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass179 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass179;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		this.Reset = binaryStream_0.ReadBoolean();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 4 | U.smethod_0(this.int_5, 28));
		this.VbQnreasOv = binaryStream_0.smethod_0();
		this.VbQnreasOv = (this.VbQnreasOv << 4 | U.smethod_0(this.VbQnreasOv, 28));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 16 | U.smethod_0(this.int_6, 16));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 11) | this.int_7 << 21);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 1 | U.smethod_0(this.int_8, 31));
		this.string_0 = binaryStream_0.smethod_2();
		this.Credits = binaryStream_0.ReadDouble();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 6 | U.smethod_0(this.int_9, 26));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 1) | this.int_10 << 31);
		binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 16) | this.int_11 << 16);
		this.EuknhfatvF = binaryStream_0.smethod_0();
		this.EuknhfatvF = (U.smethod_0(this.EuknhfatvF, 15) | this.EuknhfatvF << 17);
		this.Uridium = binaryStream_0.ReadDouble();
		this.Experience = binaryStream_0.ReadDouble();
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 8 | U.smethod_0(this.int_12, 24));
		this.Honor = binaryStream_0.ReadDouble();
		this.EqbnNuLyng = binaryStream_0.smethod_0();
		this.EqbnNuLyng = (U.smethod_0(this.EqbnNuLyng, 8) | this.EqbnNuLyng << 24);
		this.int_13 = binaryStream_0.smethod_0();
		this.int_13 = (U.smethod_0(this.int_13, 10) | this.int_13 << 22);
		this.double_0 = (double)binaryStream_0.smethod_8();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		this.int_14 = binaryStream_0.smethod_0();
		this.int_14 = (this.int_14 << 3 | U.smethod_0(this.int_14, 29));
		this.int_15 = binaryStream_0.smethod_0();
		this.int_15 = (U.smethod_0(this.int_15, 12) | this.int_15 << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5638);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.fUeiimuocMk(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.fUeiimuocMk(this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.fUeiimuocMk(this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass179 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(16993);
		binaryStream_0.fUeiimuocMk(this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		binaryStream_0.WriteBoolean(this.Reset);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 4) | this.int_5 << 28);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.VbQnreasOv, 4) | this.VbQnreasOv << 28);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_6, 16) | this.int_6 << 16);
		binaryStream_0.fUeiimuocMk(this.int_7 << 11 | U.smethod_0(this.int_7, 21));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_8, 1) | this.int_8 << 31);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.Credits);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_9, 6) | this.int_9 << 26);
		binaryStream_0.fUeiimuocMk(this.int_10 << 1 | U.smethod_0(this.int_10, 31));
		binaryStream_0.smethod_5(-397);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.fUeiimuocMk(this.int_11 << 16 | U.smethod_0(this.int_11, 16));
		binaryStream_0.fUeiimuocMk(this.EuknhfatvF << 15 | U.smethod_0(this.EuknhfatvF, 17));
		binaryStream_0.WriteDouble(this.Uridium);
		binaryStream_0.WriteDouble(this.Experience);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_12, 8) | this.int_12 << 24);
		binaryStream_0.WriteDouble(this.Honor);
		binaryStream_0.fUeiimuocMk(this.EqbnNuLyng << 8 | U.smethod_0(this.EqbnNuLyng, 24));
		binaryStream_0.fUeiimuocMk(this.int_13 << 10 | U.smethod_0(this.int_13, 22));
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_14, 3) | this.int_14 << 29);
		binaryStream_0.fUeiimuocMk(this.int_15 << 12 | U.smethod_0(this.int_15, 20));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public int int_3;

	public Vector<GClass179> vector_0;

	public int int_4;

	public bool Reset;

	public int int_5;

	public int VbQnreasOv;

	public int int_6;

	public int int_7;

	public int int_8;

	public string string_0;

	public double Credits;

	public int int_9;

	public int int_10;

	public bool bool_1;

	public int int_11;

	public int EuknhfatvF;

	public double Uridium;

	public double Experience;

	public int int_12;

	public double Honor;

	public int EqbnNuLyng;

	public int int_13;

	public double double_0;

	public bool bool_2;

	public string string_1;

	public string string_2;

	public int int_14;

	public int int_15;
}
