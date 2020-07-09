using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass573 : GInterface0
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

	public GClass573(int int_11 = 0, int int_12 = 0, string string_1 = "", bool bool_2 = false, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, GClass769 gclass769_1 = null, bool bool_3 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_11;
		this.int_1 = int_12;
		this.string_0 = string_1;
		this.bool_0 = bool_2;
		this.int_2 = int_13;
		this.int_3 = int_14;
		this.int_4 = int_15;
		this.QoIeSfyas8 = int_16;
		this.int_5 = int_17;
		this.int_6 = int_18;
		this.int_7 = int_19;
		this.int_8 = int_20;
		this.int_9 = int_21;
		this.int_10 = int_22;
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

	public virtual void imethod_1(BinaryStream binaryStream_0)
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
		this.QoIeSfyas8 = binaryStream_0.smethod_0();
		this.QoIeSfyas8 = (this.QoIeSfyas8 << 7 | U.smethod_0(this.QoIeSfyas8, 25));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 7) | this.int_6 << 25);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 16) | this.int_7 << 16);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 3 | U.smethod_0(this.int_8, 29));
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 16 | U.smethod_0(this.int_9, 16));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 8) | this.int_10 << 24);
		this.gclass769_0 = (GClass769)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass769_0 != null)
		{
			this.gclass769_0.imethod_1(binaryStream_0);
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6005);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_4(this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.QoIeSfyas8, 7) | this.QoIeSfyas8 << 25);
		binaryStream_0.smethod_4(this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		binaryStream_0.smethod_4(this.int_6 << 7 | U.smethod_0(this.int_6, 25));
		binaryStream_0.smethod_4(this.int_7 << 16 | U.smethod_0(this.int_7, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 3) | this.int_8 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_9, 16) | this.int_9 << 16);
		binaryStream_0.smethod_4(this.int_10 << 8 | U.smethod_0(this.int_10, 24));
		if (this.gclass769_0 != null)
		{
			this.gclass769_0.imethod_2(binaryStream_0);
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

	public int QoIeSfyas8;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public GClass769 gclass769_0;

	public bool bool_1;
}
