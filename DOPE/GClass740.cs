using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass740 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13401;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass740(int int_5 = 0, int int_6 = 0, string string_2 = "", string string_3 = "", GClass201 gclass201_1 = null, GClass549 gclass549_0 = null, GClass720 gclass720_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0, bool bool_1 = false)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_4 = int_5;
		this.int_0 = int_6;
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass549_0 == null)
		{
			this.State = new GClass549(0, 0, "", false, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null, false);
		}
		else
		{
			this.State = gclass549_0;
		}
		if (gclass720_1 == null)
		{
			this.gclass720_0 = new GClass720(null);
		}
		else
		{
			this.gclass720_0 = gclass720_1;
		}
		this.int_1 = int_7;
		this.int_3 = int_8;
		this.int_2 = int_9;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 13401;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass549);
		this.State.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.gclass720_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass720);
		this.gclass720_0.imethod_1(binaryStream_0);
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 3 | U.smethod_0(this.int_4, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13401);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_4(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.gclass720_0.imethod_2(binaryStream_0);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(-12971);
		binaryStream_0.smethod_4(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		binaryStream_0.smethod_4(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 3) | this.int_4 << 29);
	}

	public GClass549 State;

	public bool bool_0;

	public string string_0;

	public int int_0;

	public int int_1;

	public GClass720 gclass720_0;

	public GClass201 gclass201_0;

	public string string_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
