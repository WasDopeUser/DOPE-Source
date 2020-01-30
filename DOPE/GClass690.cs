using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass690 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10576;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass690(GClass783 gclass783_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass783_1 == null)
		{
			this.gclass783_0 = new GClass783(0U);
			return;
		}
		this.gclass783_0 = gclass783_1;
	}

	public virtual int vmethod_0()
	{
		return 10576;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass783_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass783);
		this.gclass783_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10576);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass783_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(3543);
	}

	public GClass783 gclass783_0;
}
