using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass572 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6005;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass572(int int_12 = 0, int int_13 = 0, string string_1 = "", bool bool_2 = false, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, GClass769 gclass769_1 = null, bool bool_3 = false)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_12;
		this.int_1 = int_13;
		this.string_0 = string_1;
		this.bool_0 = bool_2;
		this.int_2 = int_14;
		this.int_3 = int_15;
		this.int_4 = int_16;
		this.int_5 = int_17;
		this.int_6 = int_18;
		this.int_7 = int_19;
		this.int_8 = int_20;
		this.int_9 = int_21;
		this.int_10 = int_22;
		this.int_11 = int_23;
		if (gclass769_1 == null)
		{
			this.gclass769_0 = new GClass769(null);
		}
		else
		{
			this.gclass769_0 = gclass769_1;
		}
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 6005;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 7 | U.smethod_0(this.int_4, 25));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 7 | U.smethod_0(this.int_5, 25));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 1) | this.int_6 << 31);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 7) | this.int_7 << 25);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 16) | this.int_8 << 16);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 3 | U.smethod_0(this.int_9, 29));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 16 | U.smethod_0(this.int_10, 16));
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 8) | this.int_11 << 24);
		this.gclass769_0 = (GClass769)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass769_0 != null)
		{
			this.gclass769_0.imethod_0(binaryStream_0);
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6005);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_4(this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 7) | this.int_5 << 25);
		binaryStream_0.smethod_4(this.int_6 << 1 | U.smethod_0(this.int_6, 31));
		binaryStream_0.smethod_4(this.int_7 << 7 | U.smethod_0(this.int_7, 25));
		binaryStream_0.smethod_4(this.int_8 << 16 | U.smethod_0(this.int_8, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 3) | this.int_9 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_10, 16) | this.int_10 << 16);
		binaryStream_0.smethod_4(this.int_11 << 8 | U.smethod_0(this.int_11, 24));
		if (this.gclass769_0 != null)
		{
			this.gclass769_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public bool bool_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public GClass769 gclass769_0;

	public bool bool_1;
}
