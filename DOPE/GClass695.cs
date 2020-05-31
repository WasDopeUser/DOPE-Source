using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass695 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19842;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass695(int int_4 = 0, int int_5 = 0, string string_2 = "", int int_6 = 0, int int_7 = 0, string string_3 = "", GClass202 gclass202_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.string_1 = string_2;
		this.int_0 = int_6;
		this.int_3 = int_7;
		this.string_0 = string_3;
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
			return;
		}
		this.gclass202_0 = gclass202_1;
	}

	public virtual int vmethod_0()
	{
		return 19842;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19842);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass202_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(14817);
		binaryStream_0.smethod_7(19391);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.smethod_3(this.string_1);
	}

	public GClass202 gclass202_0;

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public string string_1;
}
