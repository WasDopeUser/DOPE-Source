using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass129 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 80;
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
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_7;
		if (gclass130_1 == null)
		{
			this.gclass130_0 = new GClass130(0);
		}
		else
		{
			this.gclass130_0 = gclass130_1;
		}
		this.int_1 = int_8;
		this.int_2 = int_9;
		this.int_3 = int_10;
		this.int_4 = int_11;
		this.bool_0 = bool_1;
		this.int_5 = int_12;
		this.int_6 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 80;
	}

	public virtual int vmethod_1()
	{
		return 29;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.gclass130_0 = (GClass130)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass130_0 != null)
		{
			this.gclass130_0.imethod_1(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 5 | U.smethod_0(this.int_4, 27));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 11 | U.smethod_0(this.int_5, 21));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 12 | U.smethod_0(this.int_6, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(80);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		if (this.gclass130_0 != null)
		{
			this.gclass130_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_4(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 5) | this.int_4 << 27);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 11) | this.int_5 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 12) | this.int_6 << 20);
	}

	public int int_0;

	public GClass130 gclass130_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public bool bool_0;

	public int int_5;

	public int int_6;
}
