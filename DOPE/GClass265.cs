using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass265 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17035;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 56;
		}
	}

	public GClass265(int int_9 = 0, string string_4 = "", int int_10 = 0, string string_5 = "", string string_6 = "", int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, bool bool_4 = false, GClass139 gclass139_1 = null, int int_16 = 0, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, int int_17 = 0, int int_18 = 0, string string_7 = "", Vector<GClass186> vector_1 = null, GClass760 gclass760_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		base..ctor();
		this.int_2 = int_9;
		this.string_2 = string_4;
		this.Unknown = int_10;
		this.string_3 = string_5;
		this.string_1 = string_6;
		this.int_6 = int_11;
		this.int_8 = int_12;
		this.int_5 = int_13;
		this.int_0 = int_14;
		this.int_1 = int_15;
		this.bool_1 = bool_4;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0U);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.int_3 = int_16;
		this.bool_0 = bool_5;
		this.bool_3 = bool_6;
		this.bool_2 = bool_7;
		this.int_4 = int_17;
		this.int_7 = int_18;
		this.string_0 = string_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass186>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass760_1 == null)
		{
			this.gclass760_0 = new GClass760(0U);
			return;
		}
		this.gclass760_0 = gclass760_1;
	}

	public virtual int vmethod_0()
	{
		return 17035;
	}

	public virtual int vmethod_1()
	{
		return 56;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_2 = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (this.Unknown << 15 | U.smethod_0(this.Unknown, 17));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 9) | this.int_4 << 23);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 12) | this.int_5 << 20);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 2 | U.smethod_0(this.int_6, 30));
		this.gclass760_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass760);
		this.gclass760_0.imethod_1(binaryStream_0);
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
		binaryStream_0.smethod_1();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 16 | U.smethod_0(this.int_7, 16));
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 16 | U.smethod_0(this.int_8, 16));
		this.string_3 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17035);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27474);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.gclass139_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		binaryStream_0.smethod_4(this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(U.smethod_0(this.Unknown, 15) | this.Unknown << 17);
		binaryStream_0.smethod_4(this.int_4 << 9 | U.smethod_0(this.int_4, 23));
		binaryStream_0.smethod_4(this.int_5 << 12 | U.smethod_0(this.int_5, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 2) | this.int_6 << 30);
		this.gclass760_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass186 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(13135);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 16) | this.int_7 << 16);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 16) | this.int_8 << 16);
		binaryStream_0.smethod_3(this.string_3);
	}

	public string string_0;

	public int int_0;

	public GClass139 gclass139_0;

	public string string_1;

	public int int_1;

	public bool bool_0;

	public string string_2;

	public bool bool_1;

	public int int_2;

	public int int_3;

	public bool bool_2;

	public int Unknown;

	public int int_4;

	public int int_5;

	public int int_6;

	public GClass760 gclass760_0;

	public Vector<GClass186> vector_0;

	public int int_7;

	public bool bool_3;

	public int int_8;

	public string string_3;
}
