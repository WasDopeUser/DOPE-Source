using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass129 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5407;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 29;
		}
	}

	public GClass129(int int_6 = 0, GClass130 gclass130_0 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, bool bool_1 = false, int int_11 = 0, int int_12 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_6;
		if (gclass130_0 == null)
		{
			this.lCgvsWuIwU = new GClass130(0U);
		}
		else
		{
			this.lCgvsWuIwU = gclass130_0;
		}
		this.twnvAxlyUy = int_7;
		this.int_4 = int_8;
		this.int_1 = int_9;
		this.int_5 = int_10;
		this.bool_0 = bool_1;
		this.int_2 = int_11;
		this.int_3 = int_12;
	}

	public virtual int vmethod_0()
	{
		return 5407;
	}

	public virtual int vmethod_1()
	{
		return 29;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.lCgvsWuIwU = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass130);
		this.lCgvsWuIwU.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 4) | this.int_4 << 28);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 11 | U.smethod_0(this.int_5, 21));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.twnvAxlyUy = binaryStream_0.smethod_0();
		this.twnvAxlyUy = (this.twnvAxlyUy << 3 | U.smethod_0(this.twnvAxlyUy, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5407);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.lCgvsWuIwU.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.smethod_7(20374);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_4(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_4(this.int_4 << 4 | U.smethod_0(this.int_4, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 11) | this.int_5 << 21);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.twnvAxlyUy, 3) | this.twnvAxlyUy << 29);
	}

	public GClass130 lCgvsWuIwU;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public bool bool_0;

	public int twnvAxlyUy;
}
