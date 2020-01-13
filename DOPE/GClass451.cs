using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass451 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 446;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass451(Vector<GClass375> vector_1 = null, GClass645 gclass645_1 = null, uint uint_1 = 0U)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass375>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass645_1 == null)
		{
			this.gclass645_0 = new GClass645(0, 0);
		}
		else
		{
			this.gclass645_0 = gclass645_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 446;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass645_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass645);
		this.gclass645_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass375 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass375;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(446);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass645_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass375 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public uint uint_0;

	public GClass645 gclass645_0;

	public Vector<GClass375> vector_0;
}
