using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass221 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 155;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass221(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", int int_17 = 0, int int_18 = 0, int int_19 = 0, GClass821 gclass821_1 = null)
	{
		Class13.F93tSdiz1aNIA();
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
		this.int_7 = int_17;
		this.int_8 = int_18;
		this.int_9 = int_19;
		if (gclass821_1 == null)
		{
			this.gclass821_0 = new GClass821(0);
			return;
		}
		this.gclass821_0 = gclass821_1;
	}

	public virtual int vmethod_0()
	{
		return 155;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_2 = (65535 & ((65535 & this.int_2) << 1 | U.smethod_0(65535 & this.int_2, 15)));
		this.int_2 = ((this.int_2 > 32767) ? (this.int_2 - 65536) : this.int_2);
		this.int_3 = (int)binaryStream_0.smethod_1();
		this.int_3 = (65535 & (U.smethod_0(65535 & this.int_3, 11) | (65535 & this.int_3) << 5));
		this.int_3 = ((this.int_3 > 32767) ? (this.int_3 - 65536) : this.int_3);
		this.Name = binaryStream_0.smethod_2();
		this.int_4 = (int)binaryStream_0.smethod_1();
		this.int_4 = (65535 & ((65535 & this.int_4) << 1 | U.smethod_0(65535 & this.int_4, 15)));
		this.int_4 = ((this.int_4 > 32767) ? (this.int_4 - 65536) : this.int_4);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 12) | this.int_5 << 20);
		this.int_6 = (int)binaryStream_0.smethod_1();
		this.int_6 = (65535 & (U.smethod_0(65535 & this.int_6, 7) | (65535 & this.int_6) << 9));
		this.int_6 = ((this.int_6 > 32767) ? (this.int_6 - 65536) : this.int_6);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 12 | U.smethod_0(this.int_7, 20));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 11) | this.int_8 << 21);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 9) | this.int_9 << 23);
		this.gclass821_0 = (GClass821)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass821_0 != null)
		{
			this.gclass821_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(155);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_2, 1) | (65535 & this.int_2) << 15));
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_3) << 11 | U.smethod_0(65535 & this.int_3, 5)));
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_4, 1) | (65535 & this.int_4) << 15));
		binaryStream_0.smethod_4(this.int_5 << 12 | U.smethod_0(this.int_5, 20));
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_6) << 7 | U.smethod_0(65535 & this.int_6, 9)));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 12) | this.int_7 << 20);
		binaryStream_0.smethod_4(this.int_8 << 11 | U.smethod_0(this.int_8, 21));
		binaryStream_0.smethod_4(this.int_9 << 9 | U.smethod_0(this.int_9, 23));
		if (this.gclass821_0 != null)
		{
			this.gclass821_0.imethod_1(binaryStream_0);
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

	public int int_7;

	public int int_8;

	public int int_9;

	public GClass821 gclass821_0;
}
