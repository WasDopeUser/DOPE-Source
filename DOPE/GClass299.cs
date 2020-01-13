using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass299 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8648;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass299(uint uint_1 = 0U, double double_2 = 0.0, double double_3 = 0.0, Vector<GClass550> vector_2 = null, Vector<GClass550> vector_3 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.uint_0 = uint_1;
		this.double_1 = double_2;
		this.double_0 = double_3;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass550>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass550>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 8648;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass550 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass550;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.double_1 = binaryStream_0.ReadDouble();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass550 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass550;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8648);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass550 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass550 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_6(this.uint_0);
	}

	public double double_0;

	public Vector<GClass550> vector_0;

	public double double_1;

	public Vector<GClass550> vector_1;

	public uint uint_0;
}
