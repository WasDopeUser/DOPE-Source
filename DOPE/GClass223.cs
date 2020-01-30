using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass223 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5758;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass223(int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, string string_1 = "", int int_14 = 0, int int_15 = 0, int int_16 = 0, string string_2 = "", int int_17 = 0, int int_18 = 0, int int_19 = 0, GClass760 gclass760_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_3 = int_10;
		this.int_6 = int_11;
		this.int_9 = int_12;
		this.int_0 = int_13;
		this.Name = string_1;
		this.int_7 = int_14;
		this.int_5 = int_15;
		this.int_4 = int_16;
		this.string_0 = string_2;
		this.int_1 = int_17;
		this.int_8 = int_18;
		this.int_2 = int_19;
		if (gclass760_1 == null)
		{
			this.gclass760_0 = new GClass760(0U);
			return;
		}
		this.gclass760_0 = gclass760_1;
	}

	public virtual int vmethod_0()
	{
		return 5758;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		this.gclass760_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass760);
		this.gclass760_0.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_4 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 7) | this.int_5 << 25);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 7) | this.int_6 << 25);
		this.int_7 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 9) | this.int_8 << 23);
		this.int_9 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5758);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.gclass760_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.smethod_4(this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.int_4);
		binaryStream_0.smethod_7(-19663);
		binaryStream_0.smethod_4(this.int_5 << 7 | U.smethod_0(this.int_5, 25));
		binaryStream_0.smethod_4(this.int_6 << 7 | U.smethod_0(this.int_6, 25));
		binaryStream_0.smethod_7(this.int_7);
		binaryStream_0.smethod_7(29687);
		binaryStream_0.smethod_4(this.int_8 << 9 | U.smethod_0(this.int_8, 23));
		binaryStream_0.smethod_7(this.int_9);
	}

	public int int_0;

	public string Name;

	public int int_1;

	public GClass760 gclass760_0;

	public int int_2;

	public int int_3;

	public string string_0;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;
}
