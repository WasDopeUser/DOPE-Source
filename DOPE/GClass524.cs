using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass524 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22178;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 31;
		}
	}

	public GClass524(int int_1 = 0, string string_13 = "", string string_14 = "", string string_15 = "", string string_16 = "", string string_17 = "", string string_18 = "", string string_19 = "", string string_20 = "", string string_21 = "", string string_22 = "", string string_23 = "", string string_24 = "", string string_25 = "", bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		this.string_4 = "";
		this.string_5 = "";
		this.string_6 = "";
		this.string_7 = "";
		this.string_8 = "";
		this.string_9 = "";
		this.string_10 = "";
		this.string_11 = "";
		this.string_12 = "";
		base..ctor();
		this.int_0 = int_1;
		this.string_3 = string_13;
		this.string_6 = string_14;
		this.string_0 = string_15;
		this.string_9 = string_16;
		this.string_5 = string_17;
		this.string_12 = string_18;
		this.string_4 = string_19;
		this.string_8 = string_20;
		this.string_2 = string_21;
		this.string_11 = string_22;
		this.string_10 = string_23;
		this.string_1 = string_24;
		this.string_7 = string_25;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 22178;
	}

	public virtual int vmethod_1()
	{
		return 31;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_1();
		this.string_3 = binaryStream_0.smethod_2();
		this.string_4 = binaryStream_0.smethod_2();
		this.string_5 = binaryStream_0.smethod_2();
		this.string_6 = binaryStream_0.smethod_2();
		this.string_7 = binaryStream_0.smethod_2();
		this.string_8 = binaryStream_0.smethod_2();
		this.string_9 = binaryStream_0.smethod_2();
		this.string_10 = binaryStream_0.smethod_2();
		this.string_11 = binaryStream_0.smethod_2();
		this.string_12 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22178);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_7(-17066);
		binaryStream_0.smethod_3(this.string_3);
		binaryStream_0.smethod_3(this.string_4);
		binaryStream_0.smethod_3(this.string_5);
		binaryStream_0.smethod_3(this.string_6);
		binaryStream_0.smethod_3(this.string_7);
		binaryStream_0.smethod_3(this.string_8);
		binaryStream_0.smethod_3(this.string_9);
		binaryStream_0.smethod_3(this.string_10);
		binaryStream_0.smethod_3(this.string_11);
		binaryStream_0.smethod_3(this.string_12);
	}

	public bool bool_0;

	public string string_0;

	public string string_1;

	public string string_2;

	public int int_0;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	public string string_7;

	public string string_8;

	public string string_9;

	public string string_10;

	public string string_11;

	public string string_12;
}
