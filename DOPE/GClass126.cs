using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass126 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31008;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass126(GClass130 gclass130_1 = null, string string_2 = "", int int_6 = 0, string string_3 = "", int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, GClass139 gclass139_1 = null, Vector<GClass186> vector_1 = null)
	{
		Class13.nIxas2ezryi9b();
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
		this.int_4 = int_6;
		this.string_0 = string_3;
		this.int_0 = int_7;
		this.int_3 = int_8;
		this.int_2 = int_9;
		this.int_5 = int_10;
		this.UaDsQsiKsT = int_11;
		this.int_1 = int_12;
		this.bool_0 = bool_4;
		this.bool_2 = bool_5;
		this.bool_1 = bool_6;
		this.bool_3 = bool_7;
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
			this.vector_0 = new Vector<GClass186>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 31008;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.gclass130_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass130);
		this.gclass130_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		this.UaDsQsiKsT = binaryStream_0.smethod_0();
		this.UaDsQsiKsT = (this.UaDsQsiKsT << 5 | U.smethod_0(this.UaDsQsiKsT, 27));
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_2 = binaryStream_0.ReadBoolean();
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
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		this.string_1 = binaryStream_0.smethod_2();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 8) | this.int_5 << 24);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31008);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass139_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		this.gclass130_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.UaDsQsiKsT, 5) | this.UaDsQsiKsT << 27);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass186 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.smethod_4(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_5 << 8 | U.smethod_0(this.int_5, 24));
	}

	public GClass139 gclass139_0;

	public bool bool_0;

	public bool bool_1;

	public GClass130 gclass130_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int UaDsQsiKsT;

	public string string_0;

	public bool bool_2;

	public Vector<GClass186> vector_0;

	public bool bool_3;

	public int int_3;

	public int int_4;

	public string string_1;

	public int int_5;
}
