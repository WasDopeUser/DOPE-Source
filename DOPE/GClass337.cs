using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass337 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29961;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass337(Vector<GClass485> vector_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass485>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 29961;
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
			GClass485 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass485;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29961);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24145);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass485 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass485> vector_0;
}
