using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass601 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19243;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass601(GClass457 gclass457_1 = null, GClass351 gclass351_1 = null, Vector<GClass754> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass457_1 == null)
		{
			this.gclass457_0 = new GClass457(false, 0);
		}
		else
		{
			this.gclass457_0 = gclass457_1;
		}
		if (gclass351_1 == null)
		{
			this.gclass351_0 = new GClass351(0, 0);
		}
		else
		{
			this.gclass351_0 = gclass351_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass754>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 19243;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass457_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass457);
		this.gclass457_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass754 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass754;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass351_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass351);
		this.gclass351_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19243);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31396);
		this.gclass457_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass754 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass351_0.imethod_2(binaryStream_0);
	}

	public GClass457 gclass457_0;

	public Vector<GClass754> vector_0;

	public GClass351 gclass351_0;
}
