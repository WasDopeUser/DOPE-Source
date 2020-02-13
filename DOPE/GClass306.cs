using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass306 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8852;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass306(GClass201 gclass201_2 = null, GClass201 gclass201_3 = null, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass201_2 == null)
		{
			this.gclass201_1 = new GClass201(0U);
		}
		else
		{
			this.gclass201_1 = gclass201_2;
		}
		if (gclass201_3 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_3;
		}
		this.int_3 = int_4;
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.int_2 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 8852;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		this.gclass201_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_1.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(8852);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_3(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		binaryStream_0.smethod_6(28885);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		this.gclass201_1.imethod_2(binaryStream_0);
	}

	public GClass201 gclass201_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public GClass201 gclass201_1;
}
