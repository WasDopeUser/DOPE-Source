using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass838 : GInterface0
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

	public GClass838(Vector<GClass376> vector_1 = null, GClass539 gclass539_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass376>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass539_1 == null)
		{
			this.gclass539_0 = new GClass539(0, 0, 0);
			return;
		}
		this.gclass539_0 = gclass539_1;
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
			GClass376 gclass = (GClass376)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass539_0 = (GClass539)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass539_0 != null)
		{
			this.gclass539_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-24962);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass376 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass539_0 != null)
		{
			this.gclass539_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass376> vector_0;

	public GClass539 gclass539_0;
}
