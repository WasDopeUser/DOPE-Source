using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass224 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9206;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass224(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", int int_17 = 0, int int_18 = 0, int int_19 = 0, GClass774 gclass774_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.Name = "";
		base..ctor();
		this.int_7 = int_10;
		this.int_8 = int_11;
		this.int_0 = int_12;
		this.int_9 = int_13;
		this.Name = string_1;
		this.int_3 = int_14;
		this.int_6 = int_15;
		this.int_5 = int_16;
		this.string_0 = string_2;
		this.int_4 = int_17;
		this.int_1 = int_18;
		this.int_2 = int_19;
		if (gclass774_1 == null)
		{
			this.gclass774_0 = new GClass774(0U);
			return;
		}
		this.gclass774_0 = gclass774_1;
	}

	public virtual int vmethod_0()
	{
		return 9206;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_1();
		this.int_3 = (int)binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 6) | this.int_4 << 26);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_5 = (int)binaryStream_0.smethod_1();
		this.gclass774_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass774);
		this.gclass774_0.HrqIugnatr8(binaryStream_0);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 2) | this.int_6 << 30);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 11 | U.smethod_0(this.int_7, 21));
		this.Name = binaryStream_0.smethod_2();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 3 | U.smethod_0(this.int_8, 29));
		this.int_9 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9206);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.smethod_7(30594);
		binaryStream_0.smethod_7(this.int_3);
		binaryStream_0.smethod_4(this.int_4 << 6 | U.smethod_0(this.int_4, 26));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.int_5);
		this.gclass774_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_6 << 2 | U.smethod_0(this.int_6, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 11) | this.int_7 << 21);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 3) | this.int_8 << 29);
		binaryStream_0.smethod_7(this.int_9);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public string string_0;

	public int int_5;

	public GClass774 gclass774_0;

	public int int_6;

	public int int_7;

	public string Name;

	public int int_8;

	public int int_9;
}
