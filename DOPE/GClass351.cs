using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass351 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29316;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass351(Vector<GClass546> vector_1 = null, GClass546 gclass546_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass546>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass546_1 == null)
		{
			this.gclass546_0 = new GClass546(0, "", "", 0);
			return;
		}
		this.gclass546_0 = gclass546_1;
	}

	public virtual int vmethod_0()
	{
		return 29316;
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
			GClass546 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass546;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass546_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass546);
		this.gclass546_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29316);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass546 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		this.gclass546_0.imethod_1(binaryStream_0);
	}

	public Vector<GClass546> vector_0;

	public GClass546 gclass546_0;
}
