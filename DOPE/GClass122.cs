using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass122 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14765;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass122(GClass126 gclass126_1 = null, string string_2 = "", int int_7 = 0, string string_3 = "", int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, bool bool_3 = false, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, GClass135 gclass135_1 = null, Vector<GClass179> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		if (gclass126_1 == null)
		{
			this.gclass126_0 = new GClass126(0U);
		}
		else
		{
			this.gclass126_0 = gclass126_1;
		}
		this.string_0 = string_2;
		this.int_5 = int_7;
		this.string_1 = string_3;
		this.int_1 = int_8;
		this.int_2 = int_9;
		this.int_6 = int_10;
		this.int_3 = int_11;
		this.int_0 = int_12;
		this.int_4 = int_13;
		this.bool_0 = bool_3;
		this.bool_1 = bool_4;
		this.bool_2 = bool_5;
		this.nmeOlhWaui = bool_6;
		if (gclass135_1 == null)
		{
			this.gclass135_0 = new GClass135(0U);
		}
		else
		{
			this.gclass135_0 = gclass135_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass179>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 14765;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_1 = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
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
		this.gclass135_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass135);
		this.gclass135_0.imethod_1(binaryStream_0);
		this.nmeOlhWaui = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 2) | this.int_4 << 30);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 15 | U.smethod_0(this.int_5, 17));
		this.gclass126_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass126);
		this.gclass126_0.imethod_1(binaryStream_0);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 13) | this.int_6 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(14765);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.fUeiimuocMk(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass179 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass135_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.nmeOlhWaui);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.fUeiimuocMk(this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		binaryStream_0.fUeiimuocMk(this.int_4 << 2 | U.smethod_0(this.int_4, 30));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 15) | this.int_5 << 17);
		this.gclass126_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_6 << 13 | U.smethod_0(this.int_6, 19));
	}

	public string string_0;

	public bool bool_0;

	public string string_1;

	public bool bool_1;

	public int int_0;

	public int int_1;

	public Vector<GClass179> vector_0;

	public GClass135 gclass135_0;

	public bool nmeOlhWaui;

	public bool bool_2;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public GClass126 gclass126_0;

	public int int_6;
}
