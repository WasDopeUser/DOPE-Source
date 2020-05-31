using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass617 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18107;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass617(GClass465 gclass465_1 = null, GClass359 gclass359_1 = null, Vector<GClass768> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass465_1 == null)
		{
			this.gclass465_0 = new GClass465(false, 0);
		}
		else
		{
			this.gclass465_0 = gclass465_1;
		}
		if (gclass359_1 == null)
		{
			this.gclass359_0 = new GClass359(0, 0);
		}
		else
		{
			this.gclass359_0 = gclass359_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass768>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 18107;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass359_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.gclass359_0.HrqIugnatr8(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass768 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass768;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass465_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass465);
		this.gclass465_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18107);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass359_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass768 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		this.gclass465_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-8364);
		binaryStream_0.smethod_7(-29500);
	}

	public GClass359 gclass359_0;

	public Vector<GClass768> vector_0;

	public GClass465 gclass465_0;
}
