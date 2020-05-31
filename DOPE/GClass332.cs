using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass332 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18038;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass332(Vector<GClass349> vector_1 = null, GClass349 gclass349_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass349>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass349_1 == null)
		{
			this.gclass349_0 = new GClass349(0, "", "", 0);
			return;
		}
		this.gclass349_0 = gclass349_1;
	}

	public virtual int vmethod_0()
	{
		return 18038;
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
			GClass349 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass349;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass349_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass349);
		this.gclass349_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18038);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass349 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		this.gclass349_0.imethod_1(binaryStream_0);
	}

	public Vector<GClass349> vector_0;

	public GClass349 gclass349_0;
}
