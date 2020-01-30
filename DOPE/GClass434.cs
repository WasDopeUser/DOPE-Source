using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass434 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3757;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass434(int int_2 = 0, Vector<GClass633> vector_2 = null, Vector<GClass545> vector_3 = null, int int_3 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_1 = int_2;
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<GClass633>();
		}
		else
		{
			this.vector_1 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass545>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 3757;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass545 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass545;
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
			GClass633 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass633;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3757);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass545 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass633 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-19292);
	}

	public int int_0;

	public int int_1;

	public Vector<GClass545> vector_0;

	public Vector<GClass633> vector_1;
}
