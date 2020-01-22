using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass129 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13185;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 29;
		}
	}

	public GClass129(int int_7 = 0, GClass130 gclass130_1 = null, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, bool bool_1 = false, int int_12 = 0, int int_13 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_5 = int_7;
		if (gclass130_1 == null)
		{
			this.gclass130_0 = new GClass130(0U);
		}
		else
		{
			this.gclass130_0 = gclass130_1;
		}
		this.int_1 = int_8;
		this.int_6 = int_9;
		this.int_0 = int_10;
		this.int_3 = int_11;
		this.bool_0 = bool_1;
		this.int_2 = int_12;
		this.int_4 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 13185;
	}

	public virtual int vmethod_1()
	{
		return 29;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass130_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass130);
		this.gclass130_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 2 | U.smethod_0(this.int_4, 30));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 16 | U.smethod_0(this.int_5, 16));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 4 | U.smethod_0(this.int_6, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13185);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass130_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		binaryStream_0.smethod_7(-18989);
		binaryStream_0.smethod_4(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.smethod_7(4903);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 2) | this.int_4 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 16) | this.int_5 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 4) | this.int_6 << 28);
	}

	public GClass130 gclass130_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;

	public int int_4;

	public int int_5;

	public int int_6;
}
