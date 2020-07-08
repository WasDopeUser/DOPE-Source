using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass394 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -28258;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass394(Vector<GClass351> vector_1 = null, double double_0 = 0.0, int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass351>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Timestamp = double_0;
	}

	public virtual int vmethod_0()
	{
		return -28258;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass351 gclass = (GClass351)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.Timestamp = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-28258);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass351 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.Timestamp);
	}

	public int int_0;

	public Vector<GClass351> vector_0;

	public double Timestamp;
}
