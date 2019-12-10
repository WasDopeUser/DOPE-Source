using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass421 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23778;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass421(int int_2 = 0, Vector<GClass620> vector_2 = null, Vector<GClass532> vector_3 = null, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_2;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass620>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass532>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 23778;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass620 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass620;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass532 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass532;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(23778);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-28596);
		binaryStream_0.fUeiimuocMk(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_5(20722);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass620 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass532 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public Vector<GClass620> vector_0;

	public int int_1;

	public Vector<GClass532> vector_1;
}
