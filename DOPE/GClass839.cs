using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass839 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -24962;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass839(Vector<GClass377> vector_1 = null, GClass540 gclass540_0 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass377>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass540_0 == null)
		{
			this.PuDmqHehYi = new GClass540(0, 0, 0);
			return;
		}
		this.PuDmqHehYi = gclass540_0;
	}

	public virtual int vmethod_0()
	{
		return -24962;
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
			GClass377 gclass = (GClass377)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.PuDmqHehYi = (GClass540)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.PuDmqHehYi != null)
		{
			this.PuDmqHehYi.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-24962);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass377 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.PuDmqHehYi != null)
		{
			this.PuDmqHehYi.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass377> vector_0;

	public GClass540 PuDmqHehYi;
}
