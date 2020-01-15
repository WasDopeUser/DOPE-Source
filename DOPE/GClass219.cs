using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass219 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10024;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 126;
		}
	}

	public GClass219(int int_16 = 0, string string_3 = "", string string_4 = "", int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0, int int_25 = 0, int int_26 = 0, int int_27 = 0, int int_28 = 0, int int_29 = 0, int int_30 = 0, int int_31 = 0, bool bool_3 = false, double double_1 = 0.0, double double_2 = 0.0, int int_32 = 0, double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_33 = 0, string string_5 = "", int int_34 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, Vector<GClass186> vector_1 = null)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_14 = int_16;
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.int_0 = int_17;
		this.int_11 = int_18;
		this.int_10 = int_19;
		this.lmvcWfReej = int_20;
		this.int_5 = int_21;
		this.int_6 = int_22;
		this.int_3 = int_23;
		this.RxfcedgeVO = int_24;
		this.int_2 = int_25;
		this.int_13 = int_26;
		this.int_7 = int_27;
		this.MapId = int_28;
		this.int_12 = int_29;
		this.int_15 = int_30;
		this.int_1 = int_31;
		this.bool_2 = bool_3;
		this.Experience = double_1;
		this.Honor = double_2;
		this.int_4 = int_32;
		this.Credits = double_3;
		this.Uridium = double_4;
		this.double_0 = double_5;
		this.int_8 = int_33;
		this.string_2 = string_5;
		this.int_9 = int_34;
		this.bool_0 = bool_4;
		this.bool_1 = bool_5;
		this.Reset = bool_6;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass186>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 10024;
	}

	public virtual int vmethod_1()
	{
		return 126;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 3) | this.MapId << 29);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.RxfcedgeVO = binaryStream_0.smethod_0();
		this.RxfcedgeVO = (U.smethod_0(this.RxfcedgeVO, 16) | this.RxfcedgeVO << 16);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass186 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass186;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.lmvcWfReej = binaryStream_0.smethod_0();
		this.lmvcWfReej = (this.lmvcWfReej << 7 | U.smethod_0(this.lmvcWfReej, 25));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		this.string_1 = binaryStream_0.smethod_2();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 9 | U.smethod_0(this.int_5, 23));
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 14) | this.int_6 << 18);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 14) | this.int_7 << 18);
		this.Reset = binaryStream_0.ReadBoolean();
		this.Honor = binaryStream_0.ReadDouble();
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 14) | this.int_8 << 18);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 3 | U.smethod_0(this.int_9, 29));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 12) | this.int_10 << 20);
		this.Experience = binaryStream_0.ReadDouble();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 2) | this.int_11 << 30);
		this.string_2 = binaryStream_0.smethod_2();
		this.Uridium = binaryStream_0.ReadDouble();
		this.int_12 = binaryStream_0.smethod_0();
		this.int_12 = (this.int_12 << 9 | U.smethod_0(this.int_12, 23));
		this.int_13 = binaryStream_0.smethod_0();
		this.int_13 = (U.smethod_0(this.int_13, 6) | this.int_13 << 26);
		this.Credits = binaryStream_0.ReadDouble();
		this.int_14 = binaryStream_0.smethod_0();
		this.int_14 = (this.int_14 << 7 | U.smethod_0(this.int_14, 25));
		this.int_15 = binaryStream_0.smethod_0();
		this.int_15 = (U.smethod_0(this.int_15, 10) | this.int_15 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10024);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.MapId << 3 | U.smethod_0(this.MapId, 29));
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.smethod_4(this.RxfcedgeVO << 16 | U.smethod_0(this.RxfcedgeVO, 16));
		binaryStream_0.smethod_4(this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass186 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.lmvcWfReej, 7) | this.lmvcWfReej << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 9) | this.int_5 << 23);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.int_6 << 14 | U.smethod_0(this.int_6, 18));
		binaryStream_0.smethod_4(this.int_7 << 14 | U.smethod_0(this.int_7, 18));
		binaryStream_0.WriteBoolean(this.Reset);
		binaryStream_0.WriteDouble(this.Honor);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(this.int_8 << 14 | U.smethod_0(this.int_8, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 3) | this.int_9 << 29);
		binaryStream_0.smethod_4(this.int_10 << 12 | U.smethod_0(this.int_10, 20));
		binaryStream_0.WriteDouble(this.Experience);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(this.int_11 << 2 | U.smethod_0(this.int_11, 30));
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.WriteDouble(this.Uridium);
		binaryStream_0.smethod_4(U.smethod_0(this.int_12, 9) | this.int_12 << 23);
		binaryStream_0.smethod_4(this.int_13 << 6 | U.smethod_0(this.int_13, 26));
		binaryStream_0.WriteDouble(this.Credits);
		binaryStream_0.smethod_4(U.smethod_0(this.int_14, 7) | this.int_14 << 25);
		binaryStream_0.smethod_4(this.int_15 << 10 | U.smethod_0(this.int_15, 22));
	}

	public string string_0;

	public int MapId;

	public int int_0;

	public int int_1;

	public int RxfcedgeVO;

	public int int_2;

	public Vector<GClass186> vector_0;

	public int lmvcWfReej;

	public int int_3;

	public bool bool_0;

	public int int_4;

	public string string_1;

	public int int_5;

	public bool bool_1;

	public int int_6;

	public int int_7;

	public bool Reset;

	public double Honor;

	public double double_0;

	public int int_8;

	public int int_9;

	public int int_10;

	public double Experience;

	public bool bool_2;

	public int int_11;

	public string string_2;

	public double Uridium;

	public int int_12;

	public int int_13;

	public double Credits;

	public int int_14;

	public int int_15;
}
