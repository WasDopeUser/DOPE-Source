using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass515 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4131;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass515(GClass488 gclass488_1 = null, Vector<GClass647> vector_2 = null, Vector<GClass647> vector_3 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass488_1 == null)
		{
			this.gclass488_0 = new GClass488(0, 0, 0);
		}
		else
		{
			this.gclass488_0 = gclass488_1;
		}
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<GClass647>();
		}
		else
		{
			this.vector_1 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass647>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 4131;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass647 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass647;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass488_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass488);
		this.gclass488_0.imethod_1(binaryStream_0);
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass647 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass647;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(4131);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(3327);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass647 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass488_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass647 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public Vector<GClass647> vector_0;

	public GClass488 gclass488_0;

	public Vector<GClass647> vector_1;

	public double double_0;

	public double double_1;
}
