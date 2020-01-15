using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass720 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16683;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass720(Vector<GClass366> vector_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass366>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 16683;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass366 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass366;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16683);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-4462);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass366 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass366> vector_0;
}
