using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass412 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6938;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass412(Vector<GClass729> vector_3 = null, Vector<GClass649> vector_4 = null, Vector<GClass649> vector_5 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass729>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_2 = new Vector<GClass649>();
		}
		else
		{
			this.vector_2 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_0 = new Vector<GClass649>();
			return;
		}
		this.vector_0 = vector_5;
	}

	public virtual int vmethod_0()
	{
		return 6938;
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
			GClass649 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass649;
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
			GClass729 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass729;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass649 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass649;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6938);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass649 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass729 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_2.Length);
		foreach (GClass649 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(-461);
	}

	public Vector<GClass649> vector_0;

	public Vector<GClass729> vector_1;

	public Vector<GClass649> vector_2;
}
