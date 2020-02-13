using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass134 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2165;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass134(double double_1 = 0.0, Vector<GClass332> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.double_0 = double_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass332>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 2165;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass332 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass332;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(2165);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_6(30119);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass332 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public double double_0;

	public Vector<GClass332> vector_0;
}
