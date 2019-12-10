using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass251 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26613;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 56;
		}
	}

	public GClass251(int int_9 = 0, string string_4 = "", int int_10 = 0, string string_5 = "", string string_6 = "", int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, bool bool_4 = false, GClass135 gclass135_0 = null, int int_16 = 0, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, int int_17 = 0, int int_18 = 0, string string_7 = "", Vector<GClass179> vector_1 = null, GClass750 gclass750_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		base..ctor();
		this.int_8 = int_9;
		this.string_3 = string_4;
		this.Unknown = int_10;
		this.string_0 = string_5;
		this.string_1 = string_6;
		this.int_4 = int_11;
		this.int_1 = int_12;
		this.int_7 = int_13;
		this.int_3 = int_14;
		this.int_5 = int_15;
		this.bool_0 = bool_4;
		if (gclass135_0 == null)
		{
			this.OgZjSfgjs8 = new GClass135(0U);
		}
		else
		{
			this.OgZjSfgjs8 = gclass135_0;
		}
		this.int_0 = int_16;
		this.bool_3 = bool_5;
		this.bool_1 = bool_6;
		this.bool_2 = bool_7;
		this.int_6 = int_17;
		this.int_2 = int_18;
		this.string_2 = string_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass179>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass750_1 == null)
		{
			this.gclass750_0 = new GClass750(0U);
			return;
		}
		this.gclass750_0 = gclass750_1;
	}

	public virtual int vmethod_0()
	{
		return 26613;
	}

	public virtual int vmethod_1()
	{
		return 56;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (U.smethod_0(this.Unknown, 11) | this.Unknown << 21);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass750_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass750);
		this.gclass750_0.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		this.OgZjSfgjs8 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass135);
		this.OgZjSfgjs8.imethod_1(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		this.string_1 = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_2 = binaryStream_0.smethod_2();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		this.string_3 = binaryStream_0.smethod_2();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 15) | this.int_6 << 17);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 14) | this.int_7 << 18);
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
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 2) | this.int_8 << 30);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(26613);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.fUeiimuocMk(this.Unknown << 11 | U.smethod_0(this.Unknown, 21));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass750_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		this.OgZjSfgjs8.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.fUeiimuocMk(this.int_4 << 7 | U.smethod_0(this.int_4, 25));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		binaryStream_0.smethod_3(this.string_3);
		binaryStream_0.fUeiimuocMk(this.int_6 << 15 | U.smethod_0(this.int_6, 17));
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.fUeiimuocMk(this.int_7 << 14 | U.smethod_0(this.int_7, 18));
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass179 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.fUeiimuocMk(this.int_8 << 2 | U.smethod_0(this.int_8, 30));
		binaryStream_0.smethod_5(-16143);
	}

	public int int_0;

	public int int_1;

	public int Unknown;

	public bool bool_0;

	public string string_0;

	public GClass750 gclass750_0;

	public int int_2;

	public GClass135 OgZjSfgjs8;

	public int int_3;

	public string string_1;

	public bool bool_1;

	public string string_2;

	public int int_4;

	public int int_5;

	public string string_3;

	public int int_6;

	public bool bool_2;

	public int int_7;

	public Vector<GClass179> vector_0;

	public bool bool_3;

	public int int_8;
}
