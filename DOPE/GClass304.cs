using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass304 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21818;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass304(GClass201 gclass201_1 = null, GClass201 gclass201_2 = null, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.fvwbnbHoTm = new GClass201(0U);
		}
		else
		{
			this.fvwbnbHoTm = gclass201_1;
		}
		if (gclass201_2 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_2;
		}
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.int_3 = int_6;
		this.int_1 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 21818;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.fvwbnbHoTm = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.fvwbnbHoTm.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21818);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14448);
		this.fvwbnbHoTm.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		this.gclass201_0.imethod_2(binaryStream_0);
	}

	public GClass201 fvwbnbHoTm;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public GClass201 gclass201_0;
}
