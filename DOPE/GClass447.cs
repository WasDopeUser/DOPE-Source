using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass447 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10667;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass447(GClass482 gclass482_1 = null, Vector<GClass635> vector_1 = null, GClass635 gclass635_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass482_1 == null)
		{
			this.gclass482_0 = new GClass482(0, null, null, null, null, "", "");
		}
		else
		{
			this.gclass482_0 = gclass482_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass635>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass635_1 == null)
		{
			this.gclass635_0 = new GClass635("", "", 0, 0, 0);
			return;
		}
		this.gclass635_0 = gclass635_1;
	}

	public virtual int vmethod_0()
	{
		return 10667;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass482_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass482);
		this.gclass482_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass635 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass635;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass635_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass635);
		this.gclass635_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10667);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass482_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass635 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass635_0.imethod_2(binaryStream_0);
	}

	public GClass482 gclass482_0;

	public Vector<GClass635> vector_0;

	public GClass635 gclass635_0;
}
