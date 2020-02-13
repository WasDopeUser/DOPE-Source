using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass709 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7878;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass709(GClass763 gclass763_1 = null, int int_1 = 0)
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
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 7878;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass763_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass763);
		this.gclass763_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(7878);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(8831);
		this.gclass763_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-19572);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
	}

	public GClass763 gclass763_0;

	public int int_0;
}
