using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass597 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -23060;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass597(Vector<GClass196> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass196>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return -23060;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass196 gclass = (GClass196)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-23060);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass196 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass196> vector_0;
}
