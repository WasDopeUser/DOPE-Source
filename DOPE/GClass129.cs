using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass129 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19623;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 29;
		}
	}

	public GClass129(int int_6 = 0, GClass130 gclass130_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, bool bool_1 = false, int int_11 = 0, int int_12 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_2 = int_6;
		if (gclass130_1 == null)
		{
			this.gclass130_0 = new GClass130(0U);
		}
		else
		{
			this.gclass130_0 = gclass130_1;
		}
		this.int_1 = int_7;
		this.int_5 = int_8;
		this.int_4 = int_9;
		this.sNjsssBijs = int_10;
		this.bool_0 = bool_1;
		this.int_0 = int_11;
		this.int_3 = int_12;
	}

	public virtual int vmethod_0()
	{
		return 19623;
	}

	public virtual int vmethod_1()
	{
		return 29;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.sNjsssBijs = binaryStream_0.smethod_0();
		this.sNjsssBijs = (U.smethod_0(this.sNjsssBijs, 10) | this.sNjsssBijs << 22);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_1();
		this.gclass130_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass130);
		this.gclass130_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 16) | this.int_5 << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19623);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_4(this.sNjsssBijs << 10 | U.smethod_0(this.sNjsssBijs, 22));
		binaryStream_0.smethod_7(22550);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_7(23302);
		this.gclass130_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		binaryStream_0.smethod_4(this.int_5 << 16 | U.smethod_0(this.int_5, 16));
	}

	public int int_0;

	public int int_1;

	public int sNjsssBijs;

	public int int_2;

	public GClass130 gclass130_0;

	public bool bool_0;

	public int int_3;

	public int int_4;

	public int int_5;
}
