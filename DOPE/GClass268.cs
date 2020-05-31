using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass268 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5406;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass268(GClass132 gclass132_1 = null, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, bool bool_0 = false)
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
		this.int_3 = int_5;
		this.int_1 = int_6;
		this.int_0 = int_7;
		this.int_2 = int_8;
		this.int_4 = int_9;
		this.kmbIjvYlVg = int_10;
		this.Unknown = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 5406;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.gclass132_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass132);
		this.gclass132_0.HrqIugnatr8(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		binaryStream_0.smethod_1();
		this.Unknown = binaryStream_0.ReadBoolean();
		this.kmbIjvYlVg = binaryStream_0.smethod_0();
		this.kmbIjvYlVg = (this.kmbIjvYlVg << 6 | U.smethod_0(this.kmbIjvYlVg, 26));
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 4 | U.smethod_0(this.int_4, 28));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5406);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		this.gclass132_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		binaryStream_0.smethod_4(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_7(6046);
		binaryStream_0.WriteBoolean(this.Unknown);
		binaryStream_0.smethod_4(U.smethod_0(this.kmbIjvYlVg, 6) | this.kmbIjvYlVg << 26);
		binaryStream_0.smethod_7(-28186);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 4) | this.int_4 << 28);
	}

	public int int_0;

	public int int_1;

	public GClass132 gclass132_0;

	public int int_2;

	public int int_3;

	public bool Unknown;

	public int kmbIjvYlVg;

	public int int_4;
}
