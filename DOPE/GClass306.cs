using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass306 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11185;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass306(uint uint_1 = 0U, double double_2 = 0.0, double double_3 = 0.0, Vector<GClass566> vector_2 = null, Vector<GClass566> vector_3 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<GClass566>();
		}
		else
		{
			this.vector_1 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass566>();
			return;
		}
		this.vector_0 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 11185;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass566 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass566;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.double_1 = binaryStream_0.ReadDouble();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass566 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass566;
			gclass2.HrqIugnatr8(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11185);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass566 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_7(19068);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass566 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
	}

	public Vector<GClass566> vector_0;

	public double double_0;

	public uint uint_0;

	public double double_1;

	public Vector<GClass566> vector_1;
}
