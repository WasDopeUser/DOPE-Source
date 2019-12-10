using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass588 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23809;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass588(GClass444 gclass444_1 = null, GClass335 gclass335_1 = null, Vector<GClass744> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass444_1 == null)
		{
			this.gclass444_0 = new GClass444(false, 0);
		}
		else
		{
			this.gclass444_0 = gclass444_1;
		}
		if (gclass335_1 == null)
		{
			this.gclass335_0 = new GClass335(0, 0);
		}
		else
		{
			this.gclass335_0 = gclass335_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass744>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 23809;
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
			GClass744 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass744;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.gclass444_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass444);
		this.gclass444_0.imethod_1(binaryStream_0);
		this.gclass335_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass335);
		this.gclass335_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(23809);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass744 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(16580);
		this.gclass444_0.imethod_2(binaryStream_0);
		this.gclass335_0.imethod_2(binaryStream_0);
	}

	public Vector<GClass744> vector_0;

	public GClass444 gclass444_0;

	public GClass335 gclass335_0;
}
