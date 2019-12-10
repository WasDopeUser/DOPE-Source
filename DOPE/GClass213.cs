using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass213 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27991;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass213(int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, string string_1 = "", int int_10 = 0, int int_11 = 0, int int_12 = 0, string string_2 = "", int int_13 = 0, int int_14 = 0, int int_15 = 0, GClass750 gclass750_0 = null)
	{
		Class8.xDph7tozmh5WD();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_5 = int_6;
		this.emTnBfukst = int_7;
		this.int_0 = int_8;
		this.qbpnoTqPut = int_9;
		this.Name = string_1;
		this.int_2 = int_10;
		this.cgInIijfrs = int_11;
		this.int_1 = int_12;
		this.string_0 = string_2;
		this.int_3 = int_13;
		this.XnanpDfuYR = int_14;
		this.int_4 = int_15;
		if (gclass750_0 == null)
		{
			this.Ceknqvtddb = new GClass750(0U);
			return;
		}
		this.Ceknqvtddb = gclass750_0;
	}

	public virtual int vmethod_0()
	{
		return 27991;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Ceknqvtddb = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass750);
		this.Ceknqvtddb.imethod_1(binaryStream_0);
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.cgInIijfrs = binaryStream_0.smethod_0();
		this.cgInIijfrs = (this.cgInIijfrs << 2 | U.smethod_0(this.cgInIijfrs, 30));
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		this.XnanpDfuYR = binaryStream_0.smethod_0();
		this.XnanpDfuYR = (this.XnanpDfuYR << 12 | U.smethod_0(this.XnanpDfuYR, 20));
		this.string_0 = binaryStream_0.smethod_2();
		this.qbpnoTqPut = (int)binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 8 | U.smethod_0(this.int_4, 24));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 9) | this.int_5 << 23);
		this.emTnBfukst = binaryStream_0.smethod_0();
		this.emTnBfukst = (this.emTnBfukst << 13 | U.smethod_0(this.emTnBfukst, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27991);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Ceknqvtddb.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(this.int_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.cgInIijfrs, 2) | this.cgInIijfrs << 30);
		binaryStream_0.smethod_5(this.int_1);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_5(this.int_2);
		binaryStream_0.fUeiimuocMk(this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.XnanpDfuYR, 12) | this.XnanpDfuYR << 20);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(this.qbpnoTqPut);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 8) | this.int_4 << 24);
		binaryStream_0.fUeiimuocMk(this.int_5 << 9 | U.smethod_0(this.int_5, 23));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.emTnBfukst, 13) | this.emTnBfukst << 19);
	}

	public GClass750 Ceknqvtddb;

	public int int_0;

	public int cgInIijfrs;

	public int int_1;

	public string Name;

	public int int_2;

	public int int_3;

	public int XnanpDfuYR;

	public string string_0;

	public int qbpnoTqPut;

	public int int_4;

	public int int_5;

	public int emTnBfukst;
}
