using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass301 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6007;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass301(Vector<GClass647> vector_3 = null, Vector<GClass647> vector_4 = null, Vector<GClass647> vector_5 = null, GClass647 gclass647_1 = null, GClass201 gclass201_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass647>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass647>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass647>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		if (gclass647_1 == null)
		{
			this.gclass647_0 = new GClass647(0, 0, "", "", "", 0);
		}
		else
		{
			this.gclass647_0 = gclass647_1;
		}
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
			return;
		}
		this.gclass201_0 = gclass201_1;
	}

	public virtual int vmethod_0()
	{
		return 6007;
	}

	public virtual int vmethod_1()
	{
		return 12;
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
			GClass647 gclass = (GClass647)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
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
			GClass647 gclass2 = (GClass647)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass647 gclass3 = (GClass647)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			i++;
		}
		this.gclass647_0 = (GClass647)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass647_0 != null)
		{
			this.gclass647_0.imethod_1(binaryStream_0);
		}
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6007);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass647 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass647 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_2.Length);
		foreach (GClass647 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		if (this.gclass647_0 != null)
		{
			this.gclass647_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass647> vector_0;

	public Vector<GClass647> vector_1;

	public Vector<GClass647> vector_2;

	public GClass647 gclass647_0;

	public GClass201 gclass201_0;
}
