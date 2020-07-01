using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass510 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3366;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass510(int int_1 = 0, double double_2 = 0.0, double double_3 = 0.0, Vector<GClass573> vector_2 = null, Vector<GClass573> vector_3 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass573>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass573>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 3366;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass573 gclass = (GClass573)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass573 gclass2 = (GClass573)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_0(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3366);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass573 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass573 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
	}

	public int int_0;

	public double double_0;

	public double double_1;

	public Vector<GClass573> vector_0;

	public Vector<GClass573> vector_1;
}
