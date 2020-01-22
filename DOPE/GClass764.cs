using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass764 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32578;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass764(GClass761 gclass761_1 = null, Vector<GClass135> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0U);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass135>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 32578;
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
			GClass135 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass135;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32578);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass135 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-23006);
		this.gclass761_0.imethod_2(binaryStream_0);
	}

	public Vector<GClass135> vector_0;

	public GClass761 gclass761_0;
}
