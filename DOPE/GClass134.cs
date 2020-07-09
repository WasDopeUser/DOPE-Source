using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass134 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1150;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass134(double double_1 = 0.0, Vector<GClass339> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.double_0 = double_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass339>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 1150;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass339 gclass = (GClass339)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1150);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass339 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public double double_0;

	public Vector<GClass339> vector_0;
}
