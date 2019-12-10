using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass241 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28299;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass241(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", GClass135 gclass135_1 = null, int int_17 = 0, int int_18 = 0, int int_19 = 0, bool bool_2 = false, bool bool_3 = false, GClass750 gclass750_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.Name = "";
		base..ctor();
		this.int_9 = int_10;
		this.int_7 = int_11;
		this.int_0 = int_12;
		this.int_2 = int_13;
		this.Name = string_1;
		this.int_8 = int_14;
		this.int_1 = int_15;
		this.int_6 = int_16;
		this.string_0 = string_2;
		if (gclass135_1 == null)
		{
			this.gclass135_0 = new GClass135(0U);
		}
		else
		{
			this.gclass135_0 = gclass135_1;
		}
		this.int_5 = int_17;
		this.int_4 = int_18;
		this.int_3 = int_19;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		if (gclass750_1 == null)
		{
			this.gclass750_0 = new GClass750(0U);
			return;
		}
		this.gclass750_0 = gclass750_1;
	}

	public virtual int vmethod_0()
	{
		return 28299;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass750_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass750);
		this.gclass750_0.imethod_1(binaryStream_0);
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		this.int_6 = (int)binaryStream_0.smethod_1();
		this.gclass135_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass135);
		this.gclass135_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.Name = binaryStream_0.smethod_2();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 8) | this.int_7 << 24);
		this.int_8 = (int)binaryStream_0.smethod_1();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 14) | this.int_9 << 18);
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(28299);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass750_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(this.int_0);
		binaryStream_0.fUeiimuocMk(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_5(this.int_2);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		binaryStream_0.fUeiimuocMk(this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		binaryStream_0.fUeiimuocMk(this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		binaryStream_0.smethod_5(this.int_6);
		this.gclass135_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.fUeiimuocMk(this.int_7 << 8 | U.smethod_0(this.int_7, 24));
		binaryStream_0.smethod_5(this.int_8);
		binaryStream_0.fUeiimuocMk(this.int_9 << 14 | U.smethod_0(this.int_9, 18));
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public bool bool_0;

	public GClass750 gclass750_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public GClass135 gclass135_0;

	public string string_0;

	public string Name;

	public int int_7;

	public int int_8;

	public int int_9;

	public bool bool_1;
}
