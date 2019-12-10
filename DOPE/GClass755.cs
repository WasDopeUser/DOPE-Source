using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass755 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26857;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass755(GClass752 gclass752_1 = null, Vector<GClass131> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass752_1 == null)
		{
			this.gclass752_0 = new GClass752(0U);
		}
		else
		{
			this.gclass752_0 = gclass752_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass131>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 26857;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass752_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass752);
		this.gclass752_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass131 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass131;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(26857);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass752_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass131 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public GClass752 gclass752_0;

	public Vector<GClass131> vector_0;
}
