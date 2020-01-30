using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass443 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28230;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass443(GClass318 gclass318_1 = null, int int_1 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass318_1 == null)
		{
			this.gclass318_0 = new GClass318(0U);
		}
		else
		{
			this.gclass318_0 = gclass318_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 28230;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass318_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318);
		this.gclass318_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28230);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass318_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-20077);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
	}

	public GClass318 gclass318_0;

	public int int_0;
}
