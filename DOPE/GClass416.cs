using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass416 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8048;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass416(Vector<GClass377> vector_1 = null, uint uint_1 = 0U)
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
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 8048;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
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
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(8048);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-19778);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass377 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public uint uint_0;

	public Vector<GClass377> vector_0;
}
