using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass223 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3970;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass223(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", int int_17 = 0, int int_18 = 0, int int_19 = 0, GClass761 gclass761_1 = null)
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_10;
		this.int_4 = int_11;
		this.int_6 = int_12;
		this.int_5 = int_13;
		this.Name = string_1;
		this.int_8 = int_14;
		this.int_1 = int_15;
		this.int_9 = int_16;
		this.string_0 = string_2;
		this.int_3 = int_17;
		this.int_2 = int_18;
		this.int_7 = int_19;
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0U);
			return;
		}
		this.gclass761_0 = gclass761_1;
	}

	public virtual int vmethod_0()
	{
		return 3970;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		this.Name = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 14) | this.int_4 << 18);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_5 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_6 = (int)binaryStream_0.smethod_1();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 7) | this.int_7 << 25);
		this.int_8 = (int)binaryStream_0.smethod_1();
		this.int_9 = (int)binaryStream_0.smethod_1();
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(3970);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-32233);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_3(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_3(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		binaryStream_0.MoioCjQkqp0(this.Name);
		binaryStream_0.smethod_3(this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		binaryStream_0.smethod_3(this.int_4 << 14 | U.smethod_0(this.int_4, 18));
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_6(this.int_5);
		binaryStream_0.smethod_6(6941);
		binaryStream_0.smethod_6(this.int_6);
		binaryStream_0.smethod_3(this.int_7 << 7 | U.smethod_0(this.int_7, 25));
		binaryStream_0.smethod_6(this.int_8);
		binaryStream_0.smethod_6(this.int_9);
		this.gclass761_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string Name;

	public int int_3;

	public int int_4;

	public string string_0;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public GClass761 gclass761_0;
}
