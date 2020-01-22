using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass255 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20067;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass255(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", GClass139 gclass139_1 = null, int int_17 = 0, int int_18 = 0, int int_19 = 0, bool bool_2 = false, bool bool_3 = false, GClass759 gclass759_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_6 = int_10;
		this.int_1 = int_11;
		this.int_4 = int_12;
		this.int_2 = int_13;
		this.Name = string_1;
		this.int_0 = int_14;
		this.int_9 = int_15;
		this.int_3 = int_16;
		this.string_0 = string_2;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0U);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.int_7 = int_17;
		this.int_5 = int_18;
		this.int_8 = int_19;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		if (gclass759_1 == null)
		{
			this.gclass759_0 = new GClass759(0U);
			return;
		}
		this.gclass759_0 = gclass759_1;
	}

	public virtual int vmethod_0()
	{
		return 20067;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_3 = (int)binaryStream_0.smethod_1();
		this.int_4 = (int)binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 11 | U.smethod_0(this.int_5, 21));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 12) | this.int_6 << 20);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 6 | U.smethod_0(this.int_7, 26));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 14) | this.int_8 << 18);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 13) | this.int_9 << 19);
		this.gclass759_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass759);
		this.gclass759_0.imethod_1(binaryStream_0);
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20067);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-18691);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.int_2);
		binaryStream_0.smethod_7(this.int_3);
		binaryStream_0.smethod_7(this.int_4);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 11) | this.int_5 << 21);
		binaryStream_0.smethod_4(this.int_6 << 12 | U.smethod_0(this.int_6, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 6) | this.int_7 << 26);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.int_8 << 14 | U.smethod_0(this.int_8, 18));
		binaryStream_0.smethod_4(this.int_9 << 13 | U.smethod_0(this.int_9, 19));
		this.gclass759_0.imethod_2(binaryStream_0);
		this.gclass139_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public string Name;

	public int int_1;

	public string string_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public bool bool_0;

	public bool bool_1;

	public int int_8;

	public int int_9;

	public GClass759 gclass759_0;

	public GClass139 gclass139_0;
}
