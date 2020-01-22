using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass264 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25548;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass264(GClass132 gclass132_1 = null, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, bool bool_0 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass132_1 == null)
		{
			this.gclass132_0 = new GClass132(0U);
		}
		else
		{
			this.gclass132_0 = gclass132_1;
		}
		this.nutcYalmlN = int_5;
		this.int_4 = int_6;
		this.int_2 = int_7;
		this.int_0 = int_8;
		this.int_1 = int_9;
		this.int_3 = int_10;
		this.Unknown = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 25548;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass132_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass132);
		this.gclass132_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 2) | this.int_3 << 30);
		this.Unknown = binaryStream_0.ReadBoolean();
		this.nutcYalmlN = binaryStream_0.smethod_0();
		this.nutcYalmlN = (U.smethod_0(this.nutcYalmlN, 11) | this.nutcYalmlN << 21);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 6) | this.int_4 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25548);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass132_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-4531);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		binaryStream_0.smethod_4(this.int_3 << 2 | U.smethod_0(this.int_3, 30));
		binaryStream_0.WriteBoolean(this.Unknown);
		binaryStream_0.smethod_4(this.nutcYalmlN << 11 | U.smethod_0(this.nutcYalmlN, 21));
		binaryStream_0.smethod_4(this.int_4 << 6 | U.smethod_0(this.int_4, 26));
	}

	public GClass132 gclass132_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool Unknown;

	public int nutcYalmlN;

	public int int_4;
}
