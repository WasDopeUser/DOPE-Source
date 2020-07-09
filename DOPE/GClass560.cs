using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass560 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -7064;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass560(Vector<GClass292> vector_1 = null, GClass292 gclass292_3 = null, GClass292 gclass292_4 = null, GClass292 gclass292_5 = null, GClass499 gclass499_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass292_4 == null)
		{
			this.gclass292_0 = new GClass292(0, 0);
		}
		else
		{
			this.gclass292_0 = gclass292_4;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass292>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass499_1 == null)
		{
			this.gclass499_0 = new GClass499(0);
		}
		else
		{
			this.gclass499_0 = gclass499_1;
		}
		if (gclass292_5 == null)
		{
			this.gclass292_1 = new GClass292(0, 0);
		}
		else
		{
			this.gclass292_1 = gclass292_5;
		}
		if (gclass292_3 == null)
		{
			this.gclass292_2 = new GClass292(0, 0);
			return;
		}
		this.gclass292_2 = gclass292_3;
	}

	public virtual int vmethod_0()
	{
		return -7064;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass292_0 = (GClass292)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass292_0 != null)
		{
			this.gclass292_0.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass292 gclass = (GClass292)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass499_0 = (GClass499)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass499_0 != null)
		{
			this.gclass499_0.imethod_1(binaryStream_0);
		}
		this.gclass292_1 = (GClass292)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass292_1 != null)
		{
			this.gclass292_1.imethod_1(binaryStream_0);
		}
		this.gclass292_2 = (GClass292)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass292_2 != null)
		{
			this.gclass292_2.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-7064);
		if (this.gclass292_0 != null)
		{
			this.gclass292_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass292 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass499_0 != null)
		{
			this.gclass499_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass292_1 != null)
		{
			this.gclass292_1.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass292_2 != null)
		{
			this.gclass292_2.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass292 gclass292_0;

	public Vector<GClass292> vector_0;

	public GClass499 gclass499_0;

	public GClass292 gclass292_1;

	public GClass292 gclass292_2;
}
