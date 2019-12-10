using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass501 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11868;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass501(GClass473 gclass473_1 = null, Vector<GClass634> vector_2 = null, Vector<GClass634> vector_3 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass473_1 == null)
		{
			this.gclass473_0 = new GClass473(0, 0, 0);
		}
		else
		{
			this.gclass473_0 = gclass473_1;
		}
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass634>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass634>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 11868;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.gclass473_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass473);
		this.gclass473_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass634 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass634 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11868);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_5(-9220);
		this.gclass473_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass634 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(7681);
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass634 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.double_1);
	}

	public double double_0;

	public GClass473 gclass473_0;

	public Vector<GClass634> vector_0;

	public Vector<GClass634> vector_1;

	public double double_1;
}
