using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass730 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15148;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass730(int int_1 = 0, Vector<GClass309> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass309>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 15148;
	}

	public virtual int vmethod_1()
	{
		return 8;
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
			GClass309 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass309;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(15148);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass309 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_6(18930);
		binaryStream_0.smethod_6(-21161);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
	}

	public Vector<GClass309> vector_0;

	public int int_0;
}
