using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass384 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19583;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass384(int int_3 = 0, int int_4 = 0, int int_5 = 0, Vector<GClass748> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass748>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 19583;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass748 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass748;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(19583);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass748 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.smethod_3(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
	}

	public int int_0;

	public Vector<GClass748> vector_0;

	public int int_1;

	public int int_2;
}
