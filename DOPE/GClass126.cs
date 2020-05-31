using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass126 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22149;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass126(GClass130 gclass130_1 = null, string string_2 = "", int int_7 = 0, string string_3 = "", int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, GClass139 gclass139_1 = null, Vector<GClass187> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		if (gclass130_1 == null)
		{
			this.gclass130_0 = new GClass130(0U);
		}
		else
		{
			this.gclass130_0 = gclass130_1;
		}
		this.string_1 = string_2;
		this.int_1 = int_7;
		this.string_0 = string_3;
		this.int_6 = int_8;
		this.int_4 = int_9;
		this.int_2 = int_10;
		this.int_5 = int_11;
		this.int_3 = int_12;
		this.int_0 = int_13;
		this.bool_0 = bool_4;
		this.bool_2 = bool_5;
		this.bool_3 = bool_6;
		this.bool_1 = bool_7;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0U);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass187>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 22149;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.HrqIugnatr8(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		this.gclass130_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass130);
		this.gclass130_0.HrqIugnatr8(binaryStream_0);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 4 | U.smethod_0(this.int_6, 28));
		this.string_1 = binaryStream_0.smethod_2();
		this.bool_3 = binaryStream_0.ReadBoolean();
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
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22149);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.gclass139_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		binaryStream_0.smethod_4(this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		this.gclass130_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 4) | this.int_6 << 28);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass187 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public int int_0;

	public int int_1;

	public GClass139 gclass139_0;

	public int int_2;

	public bool bool_0;

	public string string_0;

	public bool bool_1;

	public int int_3;

	public int int_4;

	public GClass130 gclass130_0;

	public bool bool_2;

	public int int_5;

	public int int_6;

	public string string_1;

	public bool bool_3;

	public Vector<GClass187> vector_0;
}
