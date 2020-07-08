using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass826 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -19424;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass826(GClass569 gclass569_1 = null, GClass551 gclass551_1 = null, Vector<GClass692> vector_0 = null, GClass559 gclass559_1 = null, GClass348 gclass348_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass559_1 == null)
		{
			this.gclass559_0 = new GClass559(null, null, null, null, null);
		}
		else
		{
			this.gclass559_0 = gclass559_1;
		}
		if (gclass551_1 == null)
		{
			this.gclass551_0 = new GClass551(0);
		}
		else
		{
			this.gclass551_0 = gclass551_1;
		}
		if (gclass569_1 == null)
		{
			this.gclass569_0 = new GClass569(0, 0, 0);
		}
		else
		{
			this.gclass569_0 = gclass569_1;
		}
		if (vector_0 == null)
		{
			this.yiUgfFjTai = new Vector<GClass692>();
		}
		else
		{
			this.yiUgfFjTai = vector_0;
		}
		if (gclass348_1 == null)
		{
			this.gclass348_0 = new GClass348(null, null);
			return;
		}
		this.gclass348_0 = gclass348_1;
	}

	public virtual int vmethod_0()
	{
		return -19424;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass559_0 = (GClass559)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass559_0 != null)
		{
			this.gclass559_0.imethod_1(binaryStream_0);
		}
		this.gclass551_0 = (GClass551)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass551_0 != null)
		{
			this.gclass551_0.imethod_1(binaryStream_0);
		}
		this.gclass569_0 = (GClass569)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass569_0 != null)
		{
			this.gclass569_0.imethod_1(binaryStream_0);
		}
		while (this.yiUgfFjTai.Length > 0)
		{
			this.yiUgfFjTai.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass692 gclass = (GClass692)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.yiUgfFjTai.method_0(gclass);
			i++;
		}
		this.gclass348_0 = (GClass348)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass348_0 != null)
		{
			this.gclass348_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-19424);
		if (this.gclass559_0 != null)
		{
			this.gclass559_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass551_0 != null)
		{
			this.gclass551_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass569_0 != null)
		{
			this.gclass569_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.yiUgfFjTai.Length);
		foreach (GClass692 gclass in this.yiUgfFjTai)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass348_0 != null)
		{
			this.gclass348_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass559 gclass559_0;

	public GClass551 gclass551_0;

	public GClass569 gclass569_0;

	public Vector<GClass692> yiUgfFjTai;

	public GClass348 gclass348_0;
}
