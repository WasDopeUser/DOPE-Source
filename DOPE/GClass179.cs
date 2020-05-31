using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass179 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5587;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 37;
		}
	}

	public GClass179(GClass132 gclass132_1 = null, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass132_1 == null)
		{
			this.gclass132_0 = new GClass132(0U);
		}
		else
		{
			this.gclass132_0 = gclass132_1;
		}
		this.int_7 = int_8;
		this.int_1 = int_9;
		this.int_6 = int_10;
		this.int_4 = int_11;
		this.int_5 = int_12;
		this.int_3 = int_13;
		this.int_2 = int_14;
		this.int_0 = int_15;
		this.YyNslfukKj = int_16;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 5587;
	}

	public virtual int vmethod_1()
	{
		return 37;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 9) | this.int_4 << 23);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 9 | U.smethod_0(this.int_5, 23));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 9) | this.int_6 << 23);
		this.gclass132_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass132);
		this.gclass132_0.HrqIugnatr8(binaryStream_0);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 9 | U.smethod_0(this.int_7, 23));
		this.YyNslfukKj = binaryStream_0.smethod_0();
		this.YyNslfukKj = (U.smethod_0(this.YyNslfukKj, 11) | this.YyNslfukKj << 21);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5587);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.smethod_4(this.int_4 << 9 | U.smethod_0(this.int_4, 23));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 9) | this.int_5 << 23);
		binaryStream_0.smethod_4(this.int_6 << 9 | U.smethod_0(this.int_6, 23));
		this.gclass132_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 9) | this.int_7 << 23);
		binaryStream_0.smethod_4(this.YyNslfukKj << 11 | U.smethod_0(this.YyNslfukKj, 21));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public bool bool_0;

	public int int_5;

	public int int_6;

	public GClass132 gclass132_0;

	public int int_7;

	public int YyNslfukKj;
}
