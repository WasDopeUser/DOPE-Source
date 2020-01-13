using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass323 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16962;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass323(Vector<GClass598> vector_0 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (vector_0 == null)
		{
			this.CgawEawvc7 = new Vector<GClass598>();
			return;
		}
		this.CgawEawvc7 = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 16962;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.CgawEawvc7.Length > 0)
		{
			this.CgawEawvc7.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass598 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass598;
			gclass.imethod_1(binaryStream_0);
			this.CgawEawvc7.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16962);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.CgawEawvc7.Length);
		foreach (GClass598 gclass in this.CgawEawvc7)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass598> CgawEawvc7;
}
