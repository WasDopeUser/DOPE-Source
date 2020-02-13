using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass638 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18292;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass638(GClass763 gclass763_1 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass763_1 == null)
		{
			this.gclass763_0 = new GClass763(0U);
		}
		else
		{
			this.gclass763_0 = gclass763_1;
		}
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.int_1 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 18292;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.gclass763_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass763);
		this.gclass763_0.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(18292);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-13954);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_3(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.gclass763_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		binaryStream_0.smethod_6(-7280);
	}

	public int int_0;

	public int int_1;

	public GClass763 gclass763_0;

	public int int_2;
}
