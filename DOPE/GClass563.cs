using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass563 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5119;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass563(Vector<GClass559> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass559>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 5119;
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
			GClass559 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass559;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5119);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass559 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-14369);
	}

	public Vector<GClass559> vector_0;
}
