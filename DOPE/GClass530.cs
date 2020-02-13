using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass530 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26833;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass530(Vector<GClass377> vector_1 = null, GClass647 gclass647_1 = null, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass377>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass647_1 == null)
		{
			this.gclass647_0 = new GClass647(0, 0);
		}
		else
		{
			this.gclass647_0 = gclass647_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 26833;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass377 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass377;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass647_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass647);
		this.gclass647_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(26833);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass377 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass647_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-19743);
		binaryStream_0.smethod_5(this.uint_0);
	}

	public Vector<GClass377> vector_0;

	public GClass647 gclass647_0;

	public uint uint_0;
}
