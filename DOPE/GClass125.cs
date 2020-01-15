using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass125 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10686;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass125(Vector<GClass739> vector_3 = null, Vector<GClass660> vector_4 = null, Vector<GClass660> vector_5 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_2 = new Vector<GClass739>();
		}
		else
		{
			this.vector_2 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass660>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_0 = new Vector<GClass660>();
			return;
		}
		this.vector_0 = vector_5;
	}

	public virtual int vmethod_0()
	{
		return 10686;
	}

	public virtual int vmethod_1()
	{
		return 12;
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
			GClass660 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass660;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass660 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass660;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		binaryStream_0.smethod_1();
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass739 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass739;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10686);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass660 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass660 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(8146);
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass739 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass660> vector_0;

	public Vector<GClass660> vector_1;

	public Vector<GClass739> vector_2;
}
