using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass418 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20222;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass418(Vector<GClass383> vector_1 = null, GClass533 gclass533_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass383>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass533_1 == null)
		{
			this.gclass533_0 = new GClass533(0U, 0, 0);
			return;
		}
		this.gclass533_0 = gclass533_1;
	}

	public virtual int vmethod_0()
	{
		return 20222;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass383 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass383;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass533_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass533);
		this.gclass533_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20222);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass383 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		this.gclass533_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(26054);
		binaryStream_0.smethod_7(19633);
	}

	public Vector<GClass383> vector_0;

	public GClass533 gclass533_0;
}
