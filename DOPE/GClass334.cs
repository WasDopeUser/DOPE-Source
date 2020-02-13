using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass334 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28435;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass334(GClass461 gclass461_1 = null, GClass484 gclass484_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass461_1 == null)
		{
			this.gclass461_0 = new GClass461(0U);
		}
		else
		{
			this.gclass461_0 = gclass461_1;
		}
		if (gclass484_1 == null)
		{
			this.gclass484_0 = new GClass484(0, null, null, null, null, "", "");
			return;
		}
		this.gclass484_0 = gclass484_1;
	}

	public virtual int vmethod_0()
	{
		return 28435;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass484_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass484);
		this.gclass484_0.imethod_1(binaryStream_0);
		this.gclass461_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass461);
		this.gclass461_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(28435);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25650);
		this.gclass484_0.imethod_2(binaryStream_0);
		this.gclass461_0.imethod_2(binaryStream_0);
	}

	public GClass484 gclass484_0;

	public GClass461 gclass461_0;
}
