using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass639 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -22845;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass639(GClass467 gclass467_1 = null, GClass357 gclass357_1 = null, Vector<GClass815> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass815>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass467_1 == null)
		{
			this.gclass467_0 = new GClass467(false, 0);
		}
		else
		{
			this.gclass467_0 = gclass467_1;
		}
		if (gclass357_1 == null)
		{
			this.gclass357_0 = new GClass357(0, 0);
			return;
		}
		this.gclass357_0 = gclass357_1;
	}

	public virtual int vmethod_0()
	{
		return -22845;
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
			GClass815 gclass = (GClass815)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass467_0 = (GClass467)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass467_0 != null)
		{
			this.gclass467_0.imethod_1(binaryStream_0);
		}
		this.gclass357_0 = (GClass357)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass357_0 != null)
		{
			this.gclass357_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-22845);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass815 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass467_0 != null)
		{
			this.gclass467_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass357_0 != null)
		{
			this.gclass357_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass815> vector_0;

	public GClass467 gclass467_0;

	public GClass357 gclass357_0;
}
