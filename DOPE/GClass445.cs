using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass445 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3611;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass445(GClass320 gclass320_1 = null, int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass320_1 == null)
		{
			this.gclass320_0 = new GClass320(0U);
		}
		else
		{
			this.gclass320_0 = gclass320_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 3611;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.gclass320_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass320);
		this.gclass320_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(3611);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.gclass320_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass320 gclass320_0;
}
