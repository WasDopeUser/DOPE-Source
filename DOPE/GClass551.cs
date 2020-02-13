using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass551 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18831;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 52;
		}
	}

	public GClass551(int int_10 = 0, int int_11 = 0, string string_1 = "", bool bool_2 = false, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, int int_20 = 0, int int_21 = 0, GClass710 gclass710_1 = null, bool bool_3 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.int_3 = int_10;
		this.QjTyhxDrIc = int_11;
		this.string_0 = string_1;
		this.bool_1 = bool_2;
		this.hddyMdaJgN = int_12;
		this.int_5 = int_13;
		this.int_4 = int_14;
		this.int_6 = int_15;
		this.int_2 = int_16;
		this.int_9 = int_17;
		this.int_8 = int_18;
		this.int_7 = int_19;
		this.int_0 = int_20;
		this.int_1 = int_21;
		if (gclass710_1 == null)
		{
			this.gclass710_0 = new GClass710(null);
		}
		else
		{
			this.gclass710_0 = gclass710_1;
		}
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 18831;
	}

	public virtual int vmethod_1()
	{
		return 52;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.string_0 = binaryStream_0.smethod_2();
		this.hddyMdaJgN = binaryStream_0.smethod_0();
		this.hddyMdaJgN = (this.hddyMdaJgN << 2 | U.smethod_0(this.hddyMdaJgN, 30));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		this.gclass710_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass710);
		this.gclass710_0.imethod_1(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		this.QjTyhxDrIc = binaryStream_0.smethod_0();
		this.QjTyhxDrIc = (U.smethod_0(this.QjTyhxDrIc, 11) | this.QjTyhxDrIc << 21);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 8) | this.int_5 << 24);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 5) | this.int_6 << 27);
		binaryStream_0.smethod_1();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 13) | this.int_7 << 19);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 1) | this.int_8 << 31);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 4 | U.smethod_0(this.int_9, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(18831);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(U.smethod_0(this.hddyMdaJgN, 2) | this.hddyMdaJgN << 30);
		binaryStream_0.smethod_3(this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		this.gclass710_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		binaryStream_0.smethod_3(U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		binaryStream_0.smethod_3(this.QjTyhxDrIc << 11 | U.smethod_0(this.QjTyhxDrIc, 21));
		binaryStream_0.smethod_3(this.int_5 << 8 | U.smethod_0(this.int_5, 24));
		binaryStream_0.smethod_3(this.int_6 << 5 | U.smethod_0(this.int_6, 27));
		binaryStream_0.smethod_6(-28554);
		binaryStream_0.smethod_3(this.int_7 << 13 | U.smethod_0(this.int_7, 19));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.int_8 << 1 | U.smethod_0(this.int_8, 31));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(U.smethod_0(this.int_9, 4) | this.int_9 << 28);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public int hddyMdaJgN;

	public int int_2;

	public GClass710 gclass710_0;

	public int int_3;

	public int int_4;

	public int QjTyhxDrIc;

	public int int_5;

	public int int_6;

	public int int_7;

	public bool bool_0;

	public int int_8;

	public bool bool_1;

	public int int_9;
}
