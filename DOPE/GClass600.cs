using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass600 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21620;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass600(GClass458 gclass458_1 = null, GClass351 gclass351_1 = null, Vector<GClass753> vector_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass458_1 == null)
		{
			this.gclass458_0 = new GClass458(false, 0);
		}
		else
		{
			this.gclass458_0 = gclass458_1;
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
			this.vector_0 = new Vector<GClass753>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 21620;
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
			GClass753 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass753;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.gclass458_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass458);
		this.gclass458_0.imethod_1(binaryStream_0);
		this.gclass351_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass351);
		this.gclass351_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21620);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass753 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(9960);
		this.gclass458_0.imethod_2(binaryStream_0);
		this.gclass351_0.imethod_2(binaryStream_0);
	}

	public Vector<GClass753> vector_0;

	public GClass458 gclass458_0;

	public GClass351 gclass351_0;
}
