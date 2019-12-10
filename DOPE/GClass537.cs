using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass537 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22956;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass537(int int_11 = 0, int int_12 = 0, string string_1 = "", bool bool_2 = false, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, int int_22 = 0, GClass698 gclass698_1 = null, bool bool_3 = false)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_11;
		this.int_3 = int_12;
		this.string_0 = string_1;
		this.bool_0 = bool_2;
		this.yefmMgUmMF = int_13;
		this.int_5 = int_14;
		this.int_10 = int_15;
		this.int_9 = int_16;
		this.int_1 = int_17;
		this.int_7 = int_18;
		this.int_4 = int_19;
		this.int_8 = int_20;
		this.int_2 = int_21;
		this.int_6 = int_22;
		if (gclass698_1 == null)
		{
			this.gclass698_0 = new GClass698(null);
		}
		else
		{
			this.gclass698_0 = gclass698_1;
		}
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 22956;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 7 | U.smethod_0(this.int_6, 25));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 4) | this.int_7 << 28);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 5) | this.int_8 << 27);
		this.string_0 = binaryStream_0.smethod_2();
		this.yefmMgUmMF = binaryStream_0.smethod_0();
		this.yefmMgUmMF = (U.smethod_0(this.yefmMgUmMF, 7) | this.yefmMgUmMF << 25);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (U.smethod_0(this.int_9, 7) | this.int_9 << 25);
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (this.int_10 << 8 | U.smethod_0(this.int_10, 24));
		this.gclass698_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass698);
		this.gclass698_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(22956);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		binaryStream_0.fUeiimuocMk(this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_6, 7) | this.int_6 << 25);
		binaryStream_0.fUeiimuocMk(this.int_7 << 4 | U.smethod_0(this.int_7, 28));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.fUeiimuocMk(this.int_8 << 5 | U.smethod_0(this.int_8, 27));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.yefmMgUmMF << 7 | U.smethod_0(this.yefmMgUmMF, 25));
		binaryStream_0.fUeiimuocMk(this.int_9 << 7 | U.smethod_0(this.int_9, 25));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_10, 8) | this.int_10 << 24);
		this.gclass698_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public bool bool_0;

	public bool bool_1;

	public int int_8;

	public string string_0;

	public int yefmMgUmMF;

	public int int_9;

	public int int_10;

	public GClass698 gclass698_0;
}
