using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass269 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1854;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 56;
		}
	}

	public GClass269(int int_9 = 0, string string_4 = "", int int_10 = 0, string string_5 = "", string string_6 = "", int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, bool bool_4 = false, GClass139 gclass139_1 = null, int int_16 = 0, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, int int_17 = 0, int int_18 = 0, string string_7 = "", Vector<GClass187> vector_1 = null, GClass774 gclass774_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		base..ctor();
		this.int_2 = int_9;
		this.string_0 = string_4;
		this.Unknown = int_10;
		this.string_2 = string_5;
		this.string_1 = string_6;
		this.int_1 = int_11;
		this.int_6 = int_12;
		this.int_8 = int_13;
		this.int_7 = int_14;
		this.int_0 = int_15;
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
		this.bool_2 = bool_5;
		this.bool_0 = bool_6;
		this.bool_3 = bool_7;
		this.int_4 = int_17;
		this.int_5 = int_18;
		this.string_3 = string_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass187>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass774_1 == null)
		{
			this.gclass774_0 = new GClass774(0U);
			return;
		}
		this.gclass774_0 = gclass774_1;
	}

	public virtual int vmethod_0()
	{
		return 1854;
	}

	public virtual int vmethod_1()
	{
		return 56;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		this.gclass774_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass774);
		this.gclass774_0.HrqIugnatr8(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 4 | U.smethod_0(this.int_4, 28));
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
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.HrqIugnatr8(binaryStream_0);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 9 | U.smethod_0(this.int_5, 23));
		this.string_1 = binaryStream_0.smethod_2();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 4) | this.int_6 << 28);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_2 = binaryStream_0.smethod_2();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 14) | this.int_7 << 18);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 6 | U.smethod_0(this.int_8, 26));
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (this.Unknown << 16 | U.smethod_0(this.Unknown, 16));
		this.string_3 = binaryStream_0.smethod_2();
		this.bool_3 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1854);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		this.gclass774_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 4) | this.int_4 << 28);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass187 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		this.gclass139_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 9) | this.int_5 << 23);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_6 << 4 | U.smethod_0(this.int_6, 28));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_4(this.int_7 << 14 | U.smethod_0(this.int_7, 18));
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 6) | this.int_8 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.Unknown, 16) | this.Unknown << 16);
		binaryStream_0.smethod_3(this.string_3);
		binaryStream_0.WriteBoolean(this.bool_3);
	}

	public bool bool_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass774 gclass774_0;

	public int int_3;

	public int int_4;

	public string string_0;

	public Vector<GClass187> vector_0;

	public GClass139 gclass139_0;

	public int int_5;

	public string string_1;

	public int int_6;

	public bool bool_1;

	public string string_2;

	public int int_7;

	public bool bool_2;

	public int int_8;

	public int Unknown;

	public string string_3;

	public bool bool_3;
}
