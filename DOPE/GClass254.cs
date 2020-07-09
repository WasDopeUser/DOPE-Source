using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass254 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 232;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass254(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", GClass139 gclass139_1 = null, int int_17 = 0, int int_18 = 0, int int_19 = 0, bool bool_2 = false, bool bool_3 = false, GClass821 gclass821_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_10;
		this.int_1 = int_11;
		this.int_2 = int_12;
		this.int_3 = int_13;
		this.Name = string_1;
		this.int_4 = int_14;
		this.int_5 = int_15;
		this.int_6 = int_16;
		this.string_0 = string_2;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.int_7 = int_17;
		this.int_8 = int_18;
		this.int_9 = int_19;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		if (gclass821_1 == null)
		{
			this.gclass821_0 = new GClass821(0);
			return;
		}
		this.gclass821_0 = gclass821_1;
	}

	public virtual int vmethod_0()
	{
		return 232;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_2 = (65535 & ((65535 & this.int_2) << 13 | U.smethod_0(65535 & this.int_2, 3)));
		this.int_2 = ((this.int_2 > 32767) ? (this.int_2 - 65536) : this.int_2);
		this.int_3 = (int)binaryStream_0.smethod_1();
		this.int_3 = (65535 & ((65535 & this.int_3) << 6 | U.smethod_0(65535 & this.int_3, 10)));
		this.int_3 = ((this.int_3 > 32767) ? (this.int_3 - 65536) : this.int_3);
		this.Name = binaryStream_0.smethod_2();
		this.int_4 = (int)binaryStream_0.smethod_1();
		this.int_4 = (65535 & (U.smethod_0(65535 & this.int_4, 5) | (65535 & this.int_4) << 11));
		this.int_4 = ((this.int_4 > 32767) ? (this.int_4 - 65536) : this.int_4);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		this.int_6 = (int)binaryStream_0.smethod_1();
		this.int_6 = (65535 & (U.smethod_0(65535 & this.int_6, 8) | (65535 & this.int_6) << 8));
		this.int_6 = ((this.int_6 > 32767) ? (this.int_6 - 65536) : this.int_6);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass139_0 = (GClass139)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_1(binaryStream_0);
		}
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 2 | U.smethod_0(this.int_7, 30));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 5) | this.int_8 << 27);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 11 | U.smethod_0(this.int_9, 21));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.gclass821_0 = (GClass821)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass821_0 != null)
		{
			this.gclass821_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(232);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_2, 13) | (65535 & this.int_2) << 3));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_3, 6) | (65535 & this.int_3) << 10));
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_4) << 5 | U.smethod_0(65535 & this.int_4, 11)));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_6) << 8 | U.smethod_0(65535 & this.int_6, 8)));
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 2) | this.int_7 << 30);
		binaryStream_0.smethod_4(this.int_8 << 5 | U.smethod_0(this.int_8, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 11) | this.int_9 << 21);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		if (this.gclass821_0 != null)
		{
			this.gclass821_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public string Name;

	public int int_4;

	public int int_5;

	public int int_6;

	public string string_0;

	public GClass139 gclass139_0;

	public int int_7;

	public int int_8;

	public int int_9;

	public bool bool_0;

	public bool bool_1;

	public GClass821 gclass821_0;
}
